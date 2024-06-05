/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.MOS300MI;
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
	/// Name: MOS300MI
	/// Component Name: ServiceDefinition
	/// Description: Service definition interface
	/// Version Release: 5ea4
	///</summary>
	public partial class MOS300MIResource : M3BaseResourceEndpoint
	{
		public MOS300MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MOS300MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddMaintLim
		/// Description Add Maintenance Limit
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3MES0">Meter (Required)</param>
		/// <param name="m3THIN">Threshold interval (Required)</param>
		/// <param name="m3MPGM">Maintenance program</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3ECVE">Revision number</param>
		/// <param name="m3MVER">Version number</param>
		/// <param name="m3REIN">Repeat interval</param>
		/// <param name="m3INTL">Operational tolerance</param>
		/// <param name="m3ETO1">Economical tolerance 1</param>
		/// <param name="m3ETO2">Economical tolerance 2</param>
		/// <param name="m3SAMP">Sampling percentage</param>
		/// <param name="m3SIMC">Simulation</param>
		/// <param name="m3WMLI">Inventory maintenance</param>
		/// <param name="m3MLIM">Lifetime maintenance limit</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddMaintLim(
			string m3PRNO, 
			string m3SUFI, 
			string m3MES0, 
			decimal m3THIN, 
			string m3MPGM = null, 
			string m3STRT = null, 
			string m3ECVE = null, 
			int? m3MVER = null, 
			decimal? m3REIN = null, 
			decimal? m3INTL = null, 
			decimal? m3ETO1 = null, 
			decimal? m3ETO2 = null, 
			int? m3SAMP = null, 
			int? m3SIMC = null, 
			int? m3WMLI = null, 
			int? m3MLIM = null, 
			decimal? m3TXID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddMaintLim",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));
			if (string.IsNullOrWhiteSpace(m3MES0))
				throw new ArgumentNullException(nameof(m3MES0));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("SUFI", m3SUFI.Trim())
				.WithQueryParameter("MES0", m3MES0.Trim())
				.WithQueryParameter("THIN", m3THIN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MPGM))
				request.WithQueryParameter("MPGM", m3MPGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECVE))
				request.WithQueryParameter("ECVE", m3ECVE.Trim());
			if (m3MVER.HasValue)
				request.WithQueryParameter("MVER", m3MVER.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REIN.HasValue)
				request.WithQueryParameter("REIN", m3REIN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INTL.HasValue)
				request.WithQueryParameter("INTL", m3INTL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ETO1.HasValue)
				request.WithQueryParameter("ETO1", m3ETO1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ETO2.HasValue)
				request.WithQueryParameter("ETO2", m3ETO2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAMP.HasValue)
				request.WithQueryParameter("SAMP", m3SAMP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SIMC.HasValue)
				request.WithQueryParameter("SIMC", m3SIMC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WMLI.HasValue)
				request.WithQueryParameter("WMLI", m3WMLI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MLIM.HasValue)
				request.WithQueryParameter("MLIM", m3MLIM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddOp
		/// Description Add Operation to a service
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3PLGR">Work center (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3PITI">Run time</param>
		/// <param name="m3PRNP">Planned number of workers - run time</param>
		/// <param name="m3OPDS">Operation description</param>
		/// <param name="m3DOID">Document identity</param>
		/// <param name="m3TXL1">Text</param>
		/// <param name="m3TXL2">Text</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3TDAT">To date</param>
		/// <param name="m3SETI">Setup time</param>
		/// <param name="m3SENP">Planned number of workers - setup</param>
		/// <param name="m3RUNO">OEM hours</param>
		/// <param name="m3RUNP">Price hours</param>
		/// <param name="m3RUNT">Target hours</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddOp(
			string m3FACI, 
			string m3SUFI, 
			string m3PLGR, 
			int? m3CONO = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			int? m3OPNO = null, 
			int? m3PITI = null, 
			int? m3PRNP = null, 
			string m3OPDS = null, 
			string m3DOID = null, 
			string m3TXL1 = null, 
			string m3TXL2 = null, 
			DateTime? m3FDAT = null, 
			DateTime? m3TDAT = null, 
			int? m3SETI = null, 
			int? m3SENP = null, 
			int? m3RUNO = null, 
			int? m3RUNP = null, 
			int? m3RUNT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddOp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));
			if (string.IsNullOrWhiteSpace(m3PLGR))
				throw new ArgumentNullException(nameof(m3PLGR));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("SUFI", m3SUFI.Trim())
				.WithQueryParameter("PLGR", m3PLGR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PITI.HasValue)
				request.WithQueryParameter("PITI", m3PITI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3PRNP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OPDS))
				request.WithQueryParameter("OPDS", m3OPDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOID))
				request.WithQueryParameter("DOID", m3DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXL1))
				request.WithQueryParameter("TXL1", m3TXL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXL2))
				request.WithQueryParameter("TXL2", m3TXL2.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToM3String());
			if (m3SETI.HasValue)
				request.WithQueryParameter("SETI", m3SETI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SENP.HasValue)
				request.WithQueryParameter("SENP", m3SENP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RUNO.HasValue)
				request.WithQueryParameter("RUNO", m3RUNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RUNP.HasValue)
				request.WithQueryParameter("RUNP", m3RUNP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RUNT.HasValue)
				request.WithQueryParameter("RUNT", m3RUNT.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddOp2
		/// Description Add OEM Code of Operation to a service
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3SMC0">User defined field 1</param>
		/// <param name="m3SMC1">User defined field 2</param>
		/// <param name="m3SMC2">User defined field 3</param>
		/// <param name="m3SMC3">User defined field 4</param>
		/// <param name="m3SMC4">User defined field 5</param>
		/// <param name="m3SMC5">User defined field 6</param>
		/// <param name="m3SMC6">User defined field 7</param>
		/// <param name="m3SMC7">User defined field 8</param>
		/// <param name="m3SMC8">User defined field 9</param>
		/// <param name="m3SMC9">User defined field 10</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddOp2(
			string m3FACI, 
			string m3SUFI, 
			int m3OPNO, 
			int? m3CONO = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			DateTime? m3FDAT = null, 
			string m3SMC0 = null, 
			string m3SMC1 = null, 
			string m3SMC2 = null, 
			string m3SMC3 = null, 
			string m3SMC4 = null, 
			string m3SMC5 = null, 
			string m3SMC6 = null, 
			string m3SMC7 = null, 
			string m3SMC8 = null, 
			string m3SMC9 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddOp2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("SUFI", m3SUFI.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3SMC0))
				request.WithQueryParameter("SMC0", m3SMC0.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC1))
				request.WithQueryParameter("SMC1", m3SMC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC2))
				request.WithQueryParameter("SMC2", m3SMC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC3))
				request.WithQueryParameter("SMC3", m3SMC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC4))
				request.WithQueryParameter("SMC4", m3SMC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC5))
				request.WithQueryParameter("SMC5", m3SMC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC6))
				request.WithQueryParameter("SMC6", m3SMC6.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC7))
				request.WithQueryParameter("SMC7", m3SMC7.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC8))
				request.WithQueryParameter("SMC8", m3SMC8.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC9))
				request.WithQueryParameter("SMC9", m3SMC9.Trim());

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
		/// Name AddOpElement
		/// Description Add Operation Element
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3ACTS">Task element number (Required)</param>
		/// <param name="m3ACTT">Operation element type (Required)</param>
		/// <param name="m3ACTR">Work element (Required)</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3CATY">Capability type</param>
		/// <param name="m3TOOL">Tool number</param>
		/// <param name="m3SERN">Serial number</param>
		/// <param name="m3DOID">Document identity</param>
		/// <param name="m3INSI">Inspection identity</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3ACDS">Description</param>
		/// <param name="m3TXT1">Text line 1</param>
		/// <param name="m3TXT2">Text line 2</param>
		/// <param name="m3SETI">Setup time</param>
		/// <param name="m3PITI">Run time</param>
		/// <param name="m3SENP">Planned number of workers - setup</param>
		/// <param name="m3PRNP">Planned number of workers - run time</param>
		/// <param name="m3LASK">Labor skill</param>
		/// <param name="m3INSK">Inspection skill</param>
		/// <param name="m3MVA1">Meter value 1</param>
		/// <param name="m3MVA2">Meter value 2</param>
		/// <param name="m3MVA3">Meter value 3</param>
		/// <param name="m3MVA4">Meter value 4</param>
		/// <param name="m3PEQ1">Quantity or time</param>
		/// <param name="m3PEQ2">Quantity or time</param>
		/// <param name="m3PEQ3">Quantity or time</param>
		/// <param name="m3PEQ4">Quantity or time</param>
		/// <param name="m3PET1">Trigger type</param>
		/// <param name="m3PET2">Trigger type</param>
		/// <param name="m3PET3">Trigger type</param>
		/// <param name="m3PET4">Trigger type</param>
		/// <param name="m3PERM">Permit</param>
		/// <param name="m3CLEV">Capability level</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3TRQT">Transaction quantity - basic U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddOpElement(
			string m3FACI, 
			int m3OPNO, 
			int m3ACTS, 
			string m3ACTT, 
			string m3ACTR, 
			string m3PRNO = null, 
			string m3STRT = null, 
			DateTime? m3FDAT = null, 
			string m3CATY = null, 
			string m3TOOL = null, 
			string m3SERN = null, 
			string m3DOID = null, 
			string m3INSI = null, 
			string m3SUFI = null, 
			string m3ACDS = null, 
			string m3TXT1 = null, 
			string m3TXT2 = null, 
			int? m3SETI = null, 
			int? m3PITI = null, 
			int? m3SENP = null, 
			int? m3PRNP = null, 
			string m3LASK = null, 
			string m3INSK = null, 
			decimal? m3MVA1 = null, 
			decimal? m3MVA2 = null, 
			decimal? m3MVA3 = null, 
			decimal? m3MVA4 = null, 
			int? m3PEQ1 = null, 
			int? m3PEQ2 = null, 
			int? m3PEQ3 = null, 
			int? m3PEQ4 = null, 
			int? m3PET1 = null, 
			int? m3PET2 = null, 
			int? m3PET3 = null, 
			int? m3PET4 = null, 
			string m3PERM = null, 
			int? m3CLEV = null, 
			decimal? m3TXID = null, 
			decimal? m3TRQT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddOpElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3ACTT))
				throw new ArgumentNullException(nameof(m3ACTT));
			if (string.IsNullOrWhiteSpace(m3ACTR))
				throw new ArgumentNullException(nameof(m3ACTR));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ACTS", m3ACTS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ACTT", m3ACTT.Trim())
				.WithQueryParameter("ACTR", m3ACTR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CATY))
				request.WithQueryParameter("CATY", m3CATY.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOOL))
				request.WithQueryParameter("TOOL", m3TOOL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOID))
				request.WithQueryParameter("DOID", m3DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3INSI))
				request.WithQueryParameter("INSI", m3INSI.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACDS))
				request.WithQueryParameter("ACDS", m3ACDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT1))
				request.WithQueryParameter("TXT1", m3TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT2))
				request.WithQueryParameter("TXT2", m3TXT2.Trim());
			if (m3SETI.HasValue)
				request.WithQueryParameter("SETI", m3SETI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PITI.HasValue)
				request.WithQueryParameter("PITI", m3PITI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SENP.HasValue)
				request.WithQueryParameter("SENP", m3SENP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3PRNP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LASK))
				request.WithQueryParameter("LASK", m3LASK.Trim());
			if (!string.IsNullOrWhiteSpace(m3INSK))
				request.WithQueryParameter("INSK", m3INSK.Trim());
			if (m3MVA1.HasValue)
				request.WithQueryParameter("MVA1", m3MVA1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MVA2.HasValue)
				request.WithQueryParameter("MVA2", m3MVA2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MVA3.HasValue)
				request.WithQueryParameter("MVA3", m3MVA3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MVA4.HasValue)
				request.WithQueryParameter("MVA4", m3MVA4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PEQ1.HasValue)
				request.WithQueryParameter("PEQ1", m3PEQ1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PEQ2.HasValue)
				request.WithQueryParameter("PEQ2", m3PEQ2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PEQ3.HasValue)
				request.WithQueryParameter("PEQ3", m3PEQ3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PEQ4.HasValue)
				request.WithQueryParameter("PEQ4", m3PEQ4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PET1.HasValue)
				request.WithQueryParameter("PET1", m3PET1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PET2.HasValue)
				request.WithQueryParameter("PET2", m3PET2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PET3.HasValue)
				request.WithQueryParameter("PET3", m3PET3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PET4.HasValue)
				request.WithQueryParameter("PET4", m3PET4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PERM))
				request.WithQueryParameter("PERM", m3PERM.Trim());
			if (m3CLEV.HasValue)
				request.WithQueryParameter("CLEV", m3CLEV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3TRQT.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddRelSrv
		/// Description Add Related Service
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3RSUF">Service (Required)</param>
		/// <param name="m3MREL">Maintenance relation (Required)</param>
		/// <param name="m3MPGM">Maintenance program</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3RESQ">Sequence number</param>
		/// <param name="m3RPRN">Product number</param>
		/// <param name="m3RSTS">Product structure type</param>
		/// <param name="m3MMAM">Mandatory relationship</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddRelSrv(
			string m3SUFI, 
			string m3RSUF, 
			string m3MREL, 
			string m3MPGM = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			int? m3RESQ = null, 
			string m3RPRN = null, 
			string m3RSTS = null, 
			int? m3MMAM = null, 
			decimal? m3TXID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddRelSrv",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));
			if (string.IsNullOrWhiteSpace(m3RSUF))
				throw new ArgumentNullException(nameof(m3RSUF));
			if (string.IsNullOrWhiteSpace(m3MREL))
				throw new ArgumentNullException(nameof(m3MREL));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3SUFI.Trim())
				.WithQueryParameter("RSUF", m3RSUF.Trim())
				.WithQueryParameter("MREL", m3MREL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MPGM))
				request.WithQueryParameter("MPGM", m3MPGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3RESQ.HasValue)
				request.WithQueryParameter("RESQ", m3RESQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RPRN))
				request.WithQueryParameter("RPRN", m3RPRN.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSTS))
				request.WithQueryParameter("RSTS", m3RSTS.Trim());
			if (m3MMAM.HasValue)
				request.WithQueryParameter("MMAM", m3MMAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddServiceAlias
		/// Description Add Service Alias
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PRNO">Product</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3SALI">Alias number for service</param>
		/// <param name="m3ALWT">Alias category</param>
		/// <param name="m3E0PA">Partner</param>
		/// <param name="m3MOTP">Model/site</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3VFDT">Valid from</param>
		/// <param name="m3LVDT">Valid to</param>
		/// <param name="m3REMK">Remark</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddServiceAlias(
			int? m3CONO = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
			string m3SALI = null, 
			int? m3ALWT = null, 
			string m3E0PA = null, 
			string m3MOTP = null, 
			string m3ALWQ = null, 
			DateTime? m3VFDT = null, 
			DateTime? m3LVDT = null, 
			string m3REMK = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddServiceAlias",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3SALI))
				request.WithQueryParameter("SALI", m3SALI.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3E0PA))
				request.WithQueryParameter("E0PA", m3E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3MOTP))
				request.WithQueryParameter("MOTP", m3MOTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (m3VFDT.HasValue)
				request.WithQueryParameter("VFDT", m3VFDT.Value.ToM3String());
			if (m3LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3LVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3REMK))
				request.WithQueryParameter("REMK", m3REMK.Trim());

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
		/// Name AddServiceH
		/// Description Add Service Quick entry (like panel H in MOS300)
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3STAT">Status (Required)</param>
		/// <param name="m3RESP">Responsible (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3PLCD">Planning policy (Required)</param>
		/// <param name="m3ORTY">Order type (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3TODT">To date</param>
		/// <param name="m3TOFP">Process type</param>
		/// <param name="m3SRGP">Service group</param>
		/// <param name="m3ZSET">Service level</param>
		/// <param name="m3SCHD">Scheduled maintenance service</param>
		/// <param name="m3EVTY">Event type</param>
		/// <param name="m3EVTS">Event sequence</param>
		/// <param name="m3NSTP">Shutdown</param>
		/// <param name="m3ACRF">User-defined accounting control object</param>
		/// <param name="m3MES1">Meter 1</param>
		/// <param name="m3REIN">Repeat interval</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3PITI">Run time</param>
		/// <param name="m3PRNP">Planned number of workers - run time</param>
		/// <param name="m3OPDS">Operation description</param>
		/// <param name="m3AAFR">Alarm limit</param>
		/// <param name="m3AATO">Alarm limit</param>
		/// <param name="m3AATR">Trend limit</param>
		/// <param name="m3MES0">Meter</param>
		/// <param name="m3RUOM">Result unit of measure</param>
		/// <param name="m3DOID">Document identity</param>
		/// <param name="m3NUC1">Number of put-away cards</param>
		/// <param name="m3NUC2">Number of material requisitions</param>
		/// <param name="m3NUC3">Number of labor tickets</param>
		/// <param name="m3NUC4">Number of shop travelers</param>
		/// <param name="m3NUC5">Number of routing cards</param>
		/// <param name="m3NUC6">Number of picking lists</param>
		/// <param name="m3NUC7">Number of design documents</param>
		/// <param name="m3TXL1">Text</param>
		/// <param name="m3TXL2">Text</param>
		/// <param name="m3TXL3">Text</param>
		/// <param name="m3TXL4">Text</param>
		/// <param name="m3TXL5">Text</param>
		/// <param name="m3TXL6">Text</param>
		/// <param name="m3TXL7">Text</param>
		/// <param name="m3TXL8">Text</param>
		/// <param name="m3TXL9">Text</param>
		/// <param name="m3TXL0">Text</param>
		/// <param name="m3PTSR">Service Category</param>
		/// <param name="m3MOTP">Model/site</param>
		/// <param name="m3EDWT">Estimated downtime</param>
		/// <param name="m3SCHL">Scheduling logic</param>
		/// <param name="m3PLMZ">Planning horizon</param>
		/// <param name="m3ZSEC">Calculation method</param>
		/// <param name="m3THIN">Threshold interval</param>
		/// <param name="m3ADJU">Adjust code</param>
		/// <param name="m3STYP">Service Type</param>
		/// <param name="m3ACWA">Claim warranty</param>
		/// <param name="m3EXCH">Exchange</param>
		/// <param name="m3SPMT">Issue method</param>
		/// <param name="m3ACNF">Automatic approval of service</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddServiceH(
			string m3SUFI, 
			string m3STAT, 
			string m3RESP, 
			string m3TX40, 
			string m3FACI, 
			string m3PLCD, 
			string m3ORTY, 
			int? m3CONO = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			DateTime? m3STDT = null, 
			DateTime? m3TODT = null, 
			string m3TOFP = null, 
			string m3SRGP = null, 
			int? m3ZSET = null, 
			int? m3SCHD = null, 
			string m3EVTY = null, 
			int? m3EVTS = null, 
			int? m3NSTP = null, 
			string m3ACRF = null, 
			string m3MES1 = null, 
			decimal? m3REIN = null, 
			string m3PLGR = null, 
			int? m3PITI = null, 
			int? m3PRNP = null, 
			string m3OPDS = null, 
			string m3AAFR = null, 
			string m3AATO = null, 
			string m3AATR = null, 
			string m3MES0 = null, 
			string m3RUOM = null, 
			string m3DOID = null, 
			int? m3NUC1 = null, 
			int? m3NUC2 = null, 
			int? m3NUC3 = null, 
			int? m3NUC4 = null, 
			int? m3NUC5 = null, 
			int? m3NUC6 = null, 
			int? m3NUC7 = null, 
			string m3TXL1 = null, 
			string m3TXL2 = null, 
			string m3TXL3 = null, 
			string m3TXL4 = null, 
			string m3TXL5 = null, 
			string m3TXL6 = null, 
			string m3TXL7 = null, 
			string m3TXL8 = null, 
			string m3TXL9 = null, 
			string m3TXL0 = null, 
			string m3PTSR = null, 
			string m3MOTP = null, 
			int? m3EDWT = null, 
			int? m3SCHL = null, 
			int? m3PLMZ = null, 
			int? m3ZSEC = null, 
			decimal? m3THIN = null, 
			int? m3ADJU = null, 
			string m3STYP = null, 
			int? m3ACWA = null, 
			int? m3EXCH = null, 
			int? m3SPMT = null, 
			int? m3ACNF = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddServiceH",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));
			if (string.IsNullOrWhiteSpace(m3STAT))
				throw new ArgumentNullException(nameof(m3STAT));
			if (string.IsNullOrWhiteSpace(m3RESP))
				throw new ArgumentNullException(nameof(m3RESP));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PLCD))
				throw new ArgumentNullException(nameof(m3PLCD));
			if (string.IsNullOrWhiteSpace(m3ORTY))
				throw new ArgumentNullException(nameof(m3ORTY));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3SUFI.Trim())
				.WithQueryParameter("STAT", m3STAT.Trim())
				.WithQueryParameter("RESP", m3RESP.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim())
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("PLCD", m3PLCD.Trim())
				.WithQueryParameter("ORTY", m3ORTY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3TODT.HasValue)
				request.WithQueryParameter("TODT", m3TODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3TOFP))
				request.WithQueryParameter("TOFP", m3TOFP.Trim());
			if (!string.IsNullOrWhiteSpace(m3SRGP))
				request.WithQueryParameter("SRGP", m3SRGP.Trim());
			if (m3ZSET.HasValue)
				request.WithQueryParameter("ZSET", m3ZSET.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCHD.HasValue)
				request.WithQueryParameter("SCHD", m3SCHD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EVTY))
				request.WithQueryParameter("EVTY", m3EVTY.Trim());
			if (m3EVTS.HasValue)
				request.WithQueryParameter("EVTS", m3EVTS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NSTP.HasValue)
				request.WithQueryParameter("NSTP", m3NSTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3MES1))
				request.WithQueryParameter("MES1", m3MES1.Trim());
			if (m3REIN.HasValue)
				request.WithQueryParameter("REIN", m3REIN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (m3PITI.HasValue)
				request.WithQueryParameter("PITI", m3PITI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3PRNP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OPDS))
				request.WithQueryParameter("OPDS", m3OPDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3AAFR))
				request.WithQueryParameter("AAFR", m3AAFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3AATO))
				request.WithQueryParameter("AATO", m3AATO.Trim());
			if (!string.IsNullOrWhiteSpace(m3AATR))
				request.WithQueryParameter("AATR", m3AATR.Trim());
			if (!string.IsNullOrWhiteSpace(m3MES0))
				request.WithQueryParameter("MES0", m3MES0.Trim());
			if (!string.IsNullOrWhiteSpace(m3RUOM))
				request.WithQueryParameter("RUOM", m3RUOM.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOID))
				request.WithQueryParameter("DOID", m3DOID.Trim());
			if (m3NUC1.HasValue)
				request.WithQueryParameter("NUC1", m3NUC1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUC2.HasValue)
				request.WithQueryParameter("NUC2", m3NUC2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUC3.HasValue)
				request.WithQueryParameter("NUC3", m3NUC3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUC4.HasValue)
				request.WithQueryParameter("NUC4", m3NUC4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUC5.HasValue)
				request.WithQueryParameter("NUC5", m3NUC5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUC6.HasValue)
				request.WithQueryParameter("NUC6", m3NUC6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUC7.HasValue)
				request.WithQueryParameter("NUC7", m3NUC7.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TXL1))
				request.WithQueryParameter("TXL1", m3TXL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXL2))
				request.WithQueryParameter("TXL2", m3TXL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXL3))
				request.WithQueryParameter("TXL3", m3TXL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXL4))
				request.WithQueryParameter("TXL4", m3TXL4.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXL5))
				request.WithQueryParameter("TXL5", m3TXL5.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXL6))
				request.WithQueryParameter("TXL6", m3TXL6.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXL7))
				request.WithQueryParameter("TXL7", m3TXL7.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXL8))
				request.WithQueryParameter("TXL8", m3TXL8.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXL9))
				request.WithQueryParameter("TXL9", m3TXL9.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXL0))
				request.WithQueryParameter("TXL0", m3TXL0.Trim());
			if (!string.IsNullOrWhiteSpace(m3PTSR))
				request.WithQueryParameter("PTSR", m3PTSR.Trim());
			if (!string.IsNullOrWhiteSpace(m3MOTP))
				request.WithQueryParameter("MOTP", m3MOTP.Trim());
			if (m3EDWT.HasValue)
				request.WithQueryParameter("EDWT", m3EDWT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCHL.HasValue)
				request.WithQueryParameter("SCHL", m3SCHL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLMZ.HasValue)
				request.WithQueryParameter("PLMZ", m3PLMZ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ZSEC.HasValue)
				request.WithQueryParameter("ZSEC", m3ZSEC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3THIN.HasValue)
				request.WithQueryParameter("THIN", m3THIN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADJU.HasValue)
				request.WithQueryParameter("ADJU", m3ADJU.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STYP))
				request.WithQueryParameter("STYP", m3STYP.Trim());
			if (m3ACWA.HasValue)
				request.WithQueryParameter("ACWA", m3ACWA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXCH.HasValue)
				request.WithQueryParameter("EXCH", m3EXCH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPMT.HasValue)
				request.WithQueryParameter("SPMT", m3SPMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACNF.HasValue)
				request.WithQueryParameter("ACNF", m3ACNF.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddSpecReq
		/// Description Add Specific Requirement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3SPRQ">Specific requirement category (Required)</param>
		/// <param name="m3SPRT">Specific requirements (Required)</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSpecReq(
			string m3SUFI, 
			string m3SPRQ, 
			string m3SPRT, 
			string m3PRNO = null, 
			string m3STRT = null, 
			string m3TX40 = null, 
			decimal? m3TXID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddSpecReq",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));
			if (string.IsNullOrWhiteSpace(m3SPRQ))
				throw new ArgumentNullException(nameof(m3SPRQ));
			if (string.IsNullOrWhiteSpace(m3SPRT))
				throw new ArgumentNullException(nameof(m3SPRT));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3SUFI.Trim())
				.WithQueryParameter("SPRQ", m3SPRQ.Trim())
				.WithQueryParameter("SPRT", m3SPRT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddSrvEff
		/// Description Add Service Effectivity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3TBAN">Lot number</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSrvEff(
			string m3PRNO = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3TBAN = null, 
			decimal? m3TXID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddSrvEff",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TBAN))
				request.WithQueryParameter("TBAN", m3TBAN.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ChgMaintLim
		/// Description Change Maintenance Limit
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3MES0">Meter (Required)</param>
		/// <param name="m3MPGM">Maintenance program</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3ECVE">Revision number</param>
		/// <param name="m3MVER">Version number</param>
		/// <param name="m3THIN">Threshold interval</param>
		/// <param name="m3REIN">Repeat interval</param>
		/// <param name="m3INTL">Operational tolerance</param>
		/// <param name="m3ETO1">Economical tolerance 1</param>
		/// <param name="m3ETO2">Economical tolerance 2</param>
		/// <param name="m3SAMP">Sampling percentage</param>
		/// <param name="m3SIMC">Simulation</param>
		/// <param name="m3WMLI">Inventory maintenance</param>
		/// <param name="m3MLIM">Lifetime maintenance limit</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgMaintLim(
			string m3PRNO, 
			string m3SUFI, 
			string m3MES0, 
			string m3MPGM = null, 
			string m3STRT = null, 
			string m3ECVE = null, 
			int? m3MVER = null, 
			decimal? m3THIN = null, 
			decimal? m3REIN = null, 
			decimal? m3INTL = null, 
			decimal? m3ETO1 = null, 
			decimal? m3ETO2 = null, 
			int? m3SAMP = null, 
			int? m3SIMC = null, 
			int? m3WMLI = null, 
			int? m3MLIM = null, 
			decimal? m3TXID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgMaintLim",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));
			if (string.IsNullOrWhiteSpace(m3MES0))
				throw new ArgumentNullException(nameof(m3MES0));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("SUFI", m3SUFI.Trim())
				.WithQueryParameter("MES0", m3MES0.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MPGM))
				request.WithQueryParameter("MPGM", m3MPGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECVE))
				request.WithQueryParameter("ECVE", m3ECVE.Trim());
			if (m3MVER.HasValue)
				request.WithQueryParameter("MVER", m3MVER.Value.ToString(CultureInfo.CurrentCulture));
			if (m3THIN.HasValue)
				request.WithQueryParameter("THIN", m3THIN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3REIN.HasValue)
				request.WithQueryParameter("REIN", m3REIN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INTL.HasValue)
				request.WithQueryParameter("INTL", m3INTL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ETO1.HasValue)
				request.WithQueryParameter("ETO1", m3ETO1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ETO2.HasValue)
				request.WithQueryParameter("ETO2", m3ETO2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAMP.HasValue)
				request.WithQueryParameter("SAMP", m3SAMP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SIMC.HasValue)
				request.WithQueryParameter("SIMC", m3SIMC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3WMLI.HasValue)
				request.WithQueryParameter("WMLI", m3WMLI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MLIM.HasValue)
				request.WithQueryParameter("MLIM", m3MLIM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ChgOp
		/// Description Change Operation for a service
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3PLGR">Work center (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3PITI">Run time</param>
		/// <param name="m3PRNP">Planned number of workers - run time</param>
		/// <param name="m3OPDS">Operation description</param>
		/// <param name="m3DOID">Document identity</param>
		/// <param name="m3TXL1">Text</param>
		/// <param name="m3TXL2">Text</param>
		/// <param name="m3TDAT">To date</param>
		/// <param name="m3SETI">Setup time</param>
		/// <param name="m3SENP">Planned number of workers - setup</param>
		/// <param name="m3RUNO">OEM hours</param>
		/// <param name="m3RUNP">Price hours</param>
		/// <param name="m3RUNT">Target hours</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgOp(
			string m3FACI, 
			int m3OPNO, 
			string m3PLGR, 
			int? m3CONO = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			int? m3PITI = null, 
			int? m3PRNP = null, 
			string m3OPDS = null, 
			string m3DOID = null, 
			string m3TXL1 = null, 
			string m3TXL2 = null, 
			DateTime? m3TDAT = null, 
			int? m3SETI = null, 
			int? m3SENP = null, 
			int? m3RUNO = null, 
			int? m3RUNP = null, 
			int? m3RUNT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgOp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3PLGR))
				throw new ArgumentNullException(nameof(m3PLGR));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PLGR", m3PLGR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3PITI.HasValue)
				request.WithQueryParameter("PITI", m3PITI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3PRNP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OPDS))
				request.WithQueryParameter("OPDS", m3OPDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOID))
				request.WithQueryParameter("DOID", m3DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXL1))
				request.WithQueryParameter("TXL1", m3TXL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXL2))
				request.WithQueryParameter("TXL2", m3TXL2.Trim());
			if (m3TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3TDAT.Value.ToM3String());
			if (m3SETI.HasValue)
				request.WithQueryParameter("SETI", m3SETI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SENP.HasValue)
				request.WithQueryParameter("SENP", m3SENP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RUNO.HasValue)
				request.WithQueryParameter("RUNO", m3RUNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RUNP.HasValue)
				request.WithQueryParameter("RUNP", m3RUNP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RUNT.HasValue)
				request.WithQueryParameter("RUNT", m3RUNT.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ChgOp2
		/// Description Change OEM Code of Operation for a service
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SMC0">User defined field 1</param>
		/// <param name="m3SMC1">User defined field 2</param>
		/// <param name="m3SMC2">User defined field 3</param>
		/// <param name="m3SMC3">User defined field 4</param>
		/// <param name="m3SMC4">User defined field 5</param>
		/// <param name="m3SMC5">User defined field 6</param>
		/// <param name="m3SMC6">User defined field 7</param>
		/// <param name="m3SMC7">User defined field 8</param>
		/// <param name="m3SMC8">User defined field 9</param>
		/// <param name="m3SMC9">User defined field 10</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgOp2(
			string m3FACI, 
			string m3SUFI, 
			int m3OPNO, 
			int? m3CONO = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			string m3SMC0 = null, 
			string m3SMC1 = null, 
			string m3SMC2 = null, 
			string m3SMC3 = null, 
			string m3SMC4 = null, 
			string m3SMC5 = null, 
			string m3SMC6 = null, 
			string m3SMC7 = null, 
			string m3SMC8 = null, 
			string m3SMC9 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgOp2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("SUFI", m3SUFI.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC0))
				request.WithQueryParameter("SMC0", m3SMC0.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC1))
				request.WithQueryParameter("SMC1", m3SMC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC2))
				request.WithQueryParameter("SMC2", m3SMC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC3))
				request.WithQueryParameter("SMC3", m3SMC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC4))
				request.WithQueryParameter("SMC4", m3SMC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC5))
				request.WithQueryParameter("SMC5", m3SMC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC6))
				request.WithQueryParameter("SMC6", m3SMC6.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC7))
				request.WithQueryParameter("SMC7", m3SMC7.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC8))
				request.WithQueryParameter("SMC8", m3SMC8.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC9))
				request.WithQueryParameter("SMC9", m3SMC9.Trim());

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
		/// Name ChgOpElement
		/// Description Change Operation Element
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3ACTS">Task element number (Required)</param>
		/// <param name="m3ACTT">Operation element type (Required)</param>
		/// <param name="m3ACTR">Work element (Required)</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3CATY">Capability type</param>
		/// <param name="m3TOOL">Tool number</param>
		/// <param name="m3SERN">Serial number</param>
		/// <param name="m3DOID">Document identity</param>
		/// <param name="m3INSI">Inspection identity</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3ACDS">Description</param>
		/// <param name="m3TXT1">Text line 1</param>
		/// <param name="m3TXT2">Text line 2</param>
		/// <param name="m3SETI">Setup time</param>
		/// <param name="m3PITI">Run time</param>
		/// <param name="m3SENP">Planned number of workers - setup</param>
		/// <param name="m3PRNP">Planned number of workers - run time</param>
		/// <param name="m3LASK">Labor skill</param>
		/// <param name="m3INSK">Inspection skill</param>
		/// <param name="m3MVA1">Meter value 1</param>
		/// <param name="m3MVA2">Meter value 2</param>
		/// <param name="m3MVA3">Meter value 3</param>
		/// <param name="m3MVA4">Meter value 4</param>
		/// <param name="m3PEQ1">Quantity or time</param>
		/// <param name="m3PEQ2">Quantity or time</param>
		/// <param name="m3PEQ3">Quantity or time</param>
		/// <param name="m3PEQ4">Quantity or time</param>
		/// <param name="m3PET1">Trigger type</param>
		/// <param name="m3PET2">Trigger type</param>
		/// <param name="m3PET3">Trigger type</param>
		/// <param name="m3PET4">Trigger type</param>
		/// <param name="m3PERM">Permit</param>
		/// <param name="m3CLEV">Capability level</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="m3TRQT">Transaction quantity - basic U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgOpElement(
			string m3FACI, 
			int m3OPNO, 
			int m3ACTS, 
			string m3ACTT, 
			string m3ACTR, 
			string m3PRNO = null, 
			string m3STRT = null, 
			DateTime? m3FDAT = null, 
			string m3CATY = null, 
			string m3TOOL = null, 
			string m3SERN = null, 
			string m3DOID = null, 
			string m3INSI = null, 
			string m3SUFI = null, 
			string m3ACDS = null, 
			string m3TXT1 = null, 
			string m3TXT2 = null, 
			int? m3SETI = null, 
			int? m3PITI = null, 
			int? m3SENP = null, 
			int? m3PRNP = null, 
			string m3LASK = null, 
			string m3INSK = null, 
			decimal? m3MVA1 = null, 
			decimal? m3MVA2 = null, 
			decimal? m3MVA3 = null, 
			decimal? m3MVA4 = null, 
			int? m3PEQ1 = null, 
			int? m3PEQ2 = null, 
			int? m3PEQ3 = null, 
			int? m3PEQ4 = null, 
			int? m3PET1 = null, 
			int? m3PET2 = null, 
			int? m3PET3 = null, 
			int? m3PET4 = null, 
			string m3PERM = null, 
			int? m3CLEV = null, 
			decimal? m3TXID = null, 
			decimal? m3TRQT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgOpElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3ACTT))
				throw new ArgumentNullException(nameof(m3ACTT));
			if (string.IsNullOrWhiteSpace(m3ACTR))
				throw new ArgumentNullException(nameof(m3ACTR));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ACTS", m3ACTS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ACTT", m3ACTT.Trim())
				.WithQueryParameter("ACTR", m3ACTR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CATY))
				request.WithQueryParameter("CATY", m3CATY.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOOL))
				request.WithQueryParameter("TOOL", m3TOOL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SERN))
				request.WithQueryParameter("SERN", m3SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOID))
				request.WithQueryParameter("DOID", m3DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3INSI))
				request.WithQueryParameter("INSI", m3INSI.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACDS))
				request.WithQueryParameter("ACDS", m3ACDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT1))
				request.WithQueryParameter("TXT1", m3TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT2))
				request.WithQueryParameter("TXT2", m3TXT2.Trim());
			if (m3SETI.HasValue)
				request.WithQueryParameter("SETI", m3SETI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PITI.HasValue)
				request.WithQueryParameter("PITI", m3PITI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SENP.HasValue)
				request.WithQueryParameter("SENP", m3SENP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3PRNP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LASK))
				request.WithQueryParameter("LASK", m3LASK.Trim());
			if (!string.IsNullOrWhiteSpace(m3INSK))
				request.WithQueryParameter("INSK", m3INSK.Trim());
			if (m3MVA1.HasValue)
				request.WithQueryParameter("MVA1", m3MVA1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MVA2.HasValue)
				request.WithQueryParameter("MVA2", m3MVA2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MVA3.HasValue)
				request.WithQueryParameter("MVA3", m3MVA3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MVA4.HasValue)
				request.WithQueryParameter("MVA4", m3MVA4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PEQ1.HasValue)
				request.WithQueryParameter("PEQ1", m3PEQ1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PEQ2.HasValue)
				request.WithQueryParameter("PEQ2", m3PEQ2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PEQ3.HasValue)
				request.WithQueryParameter("PEQ3", m3PEQ3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PEQ4.HasValue)
				request.WithQueryParameter("PEQ4", m3PEQ4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PET1.HasValue)
				request.WithQueryParameter("PET1", m3PET1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PET2.HasValue)
				request.WithQueryParameter("PET2", m3PET2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PET3.HasValue)
				request.WithQueryParameter("PET3", m3PET3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PET4.HasValue)
				request.WithQueryParameter("PET4", m3PET4.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PERM))
				request.WithQueryParameter("PERM", m3PERM.Trim());
			if (m3CLEV.HasValue)
				request.WithQueryParameter("CLEV", m3CLEV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3TRQT.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ChgRelSrv
		/// Description Change Related Service
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3RSUF">Service (Required)</param>
		/// <param name="m3MPGM">Maintenance program</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3RESQ">Sequence number</param>
		/// <param name="m3RPRN">Product number</param>
		/// <param name="m3RSTS">Product structure type</param>
		/// <param name="m3MREL">Maintenance relation</param>
		/// <param name="m3MMAM">Mandatory relationship</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgRelSrv(
			string m3SUFI, 
			string m3RSUF, 
			string m3MPGM = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			int? m3RESQ = null, 
			string m3RPRN = null, 
			string m3RSTS = null, 
			string m3MREL = null, 
			int? m3MMAM = null, 
			decimal? m3TXID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgRelSrv",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));
			if (string.IsNullOrWhiteSpace(m3RSUF))
				throw new ArgumentNullException(nameof(m3RSUF));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3SUFI.Trim())
				.WithQueryParameter("RSUF", m3RSUF.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MPGM))
				request.WithQueryParameter("MPGM", m3MPGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3RESQ.HasValue)
				request.WithQueryParameter("RESQ", m3RESQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RPRN))
				request.WithQueryParameter("RPRN", m3RPRN.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSTS))
				request.WithQueryParameter("RSTS", m3RSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3MREL))
				request.WithQueryParameter("MREL", m3MREL.Trim());
			if (m3MMAM.HasValue)
				request.WithQueryParameter("MMAM", m3MMAM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ChgSpecReq
		/// Description Change Specific Requirement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3SPRQ">Specific requirement category (Required)</param>
		/// <param name="m3SPRT">Specific requirements (Required)</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgSpecReq(
			string m3SUFI, 
			string m3SPRQ, 
			string m3SPRT, 
			string m3PRNO = null, 
			string m3STRT = null, 
			string m3TX40 = null, 
			decimal? m3TXID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgSpecReq",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));
			if (string.IsNullOrWhiteSpace(m3SPRQ))
				throw new ArgumentNullException(nameof(m3SPRQ));
			if (string.IsNullOrWhiteSpace(m3SPRT))
				throw new ArgumentNullException(nameof(m3SPRT));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3SUFI.Trim())
				.WithQueryParameter("SPRQ", m3SPRQ.Trim())
				.WithQueryParameter("SPRT", m3SPRT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ChgSrvEff
		/// Description Change Service Effectivity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3TBAN">Lot number</param>
		/// <param name="m3TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgSrvEff(
			string m3PRNO = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3TBAN = null, 
			decimal? m3TXID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgSrvEff",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TBAN))
				request.WithQueryParameter("TBAN", m3TBAN.Trim());
			if (m3TXID.HasValue)
				request.WithQueryParameter("TXID", m3TXID.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ConnectMtrl
		/// Description Connect existing matrl to a service
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3MSEQ">Sequence number (Required)</param>
		/// <param name="m3MTPL">Component number/work center (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ConnectMtrl(
			string m3FACI, 
			string m3SUFI, 
			int m3MSEQ, 
			string m3MTPL, 
			int m3OPNO, 
			int? m3CONO = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			DateTime? m3FDAT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ConnectMtrl",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));
			if (string.IsNullOrWhiteSpace(m3MTPL))
				throw new ArgumentNullException(nameof(m3MTPL));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("SUFI", m3SUFI.Trim())
				.WithQueryParameter("MSEQ", m3MSEQ.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("MTPL", m3MTPL.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());

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
		/// Name ConnectOper
		/// Description Connect existing operation to a service
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ConnectOper(
			string m3FACI, 
			string m3SUFI, 
			int m3OPNO, 
			string m3PRNO = null, 
			string m3STRT = null, 
			DateTime? m3FDAT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ConnectOper",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("SUFI", m3SUFI.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());

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
		/// Name DelMaintLim
		/// Description Delete Maintenance Limit
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3MES0">Meter (Required)</param>
		/// <param name="m3THIN">Threshold interval (Required)</param>
		/// <param name="m3MPGM">Maintenance program</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3ECVE">Revision number</param>
		/// <param name="m3MVER">Version number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelMaintLim(
			string m3SUFI, 
			string m3MES0, 
			decimal m3THIN, 
			string m3MPGM = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			string m3ECVE = null, 
			int? m3MVER = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelMaintLim",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));
			if (string.IsNullOrWhiteSpace(m3MES0))
				throw new ArgumentNullException(nameof(m3MES0));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3SUFI.Trim())
				.WithQueryParameter("MES0", m3MES0.Trim())
				.WithQueryParameter("THIN", m3THIN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MPGM))
				request.WithQueryParameter("MPGM", m3MPGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECVE))
				request.WithQueryParameter("ECVE", m3ECVE.Trim());
			if (m3MVER.HasValue)
				request.WithQueryParameter("MVER", m3MVER.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelOp
		/// Description Delete Operation from a service
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelOp(
			string m3FACI, 
			string m3SUFI, 
			int m3OPNO, 
			int? m3CONO = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelOp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("SUFI", m3SUFI.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());

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
		/// Name DelOpElement
		/// Description DeleteOperation Element
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3ACTS">Task element number (Required)</param>
		/// <param name="m3ACTT">Operation element type (Required)</param>
		/// <param name="m3ACTR">Work element (Required)</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3CATY">Capability type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelOpElement(
			string m3FACI, 
			int m3OPNO, 
			int m3ACTS, 
			string m3ACTT, 
			string m3ACTR, 
			string m3PRNO = null, 
			string m3STRT = null, 
			DateTime? m3FDAT = null, 
			string m3CATY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelOpElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3ACTT))
				throw new ArgumentNullException(nameof(m3ACTT));
			if (string.IsNullOrWhiteSpace(m3ACTR))
				throw new ArgumentNullException(nameof(m3ACTR));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ACTS", m3ACTS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ACTT", m3ACTT.Trim())
				.WithQueryParameter("ACTR", m3ACTR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CATY))
				request.WithQueryParameter("CATY", m3CATY.Trim());

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
		/// Name DelOpnoMtrl
		/// Description Delete all operation and material for a service
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<DelOpnoMtrlResponse></returns>
		/// <exception cref="M3Exception<DelOpnoMtrlResponse>"></exception>
		public async Task<M3Response<DelOpnoMtrlResponse>> DelOpnoMtrl(
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelOpnoMtrl",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());

			// Execute the request
			var result = await Execute<DelOpnoMtrlResponse>(
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
		/// Name DelRelSrv
		/// Description Delete Related Service
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MPGM">Maintenance program</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3RESQ">Sequence number</param>
		/// <param name="m3RPRN">Product number</param>
		/// <param name="m3RSTS">Product structure type</param>
		/// <param name="m3RSUF">Service</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<DelRelSrvResponse></returns>
		/// <exception cref="M3Exception<DelRelSrvResponse>"></exception>
		public async Task<M3Response<DelRelSrvResponse>> DelRelSrv(
			string m3MPGM = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
			int? m3RESQ = null, 
			string m3RPRN = null, 
			string m3RSTS = null, 
			string m3RSUF = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelRelSrv",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MPGM))
				request.WithQueryParameter("MPGM", m3MPGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (m3RESQ.HasValue)
				request.WithQueryParameter("RESQ", m3RESQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RPRN))
				request.WithQueryParameter("RPRN", m3RPRN.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSTS))
				request.WithQueryParameter("RSTS", m3RSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSUF))
				request.WithQueryParameter("RSUF", m3RSUF.Trim());

			// Execute the request
			var result = await Execute<DelRelSrvResponse>(
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
		/// Name DelSpecReq
		/// Description Delete Specific Requirement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3SPRQ">Specific requirement category (Required)</param>
		/// <param name="m3SPRT">Specific requirements (Required)</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelSpecReq(
			string m3SUFI, 
			string m3SPRQ, 
			string m3SPRT, 
			string m3PRNO = null, 
			string m3STRT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelSpecReq",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));
			if (string.IsNullOrWhiteSpace(m3SPRQ))
				throw new ArgumentNullException(nameof(m3SPRQ));
			if (string.IsNullOrWhiteSpace(m3SPRT))
				throw new ArgumentNullException(nameof(m3SPRT));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3SUFI.Trim())
				.WithQueryParameter("SPRQ", m3SPRQ.Trim())
				.WithQueryParameter("SPRT", m3SPRT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());

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
		/// Name DelSrvEff
		/// Description Delete Service Effectivity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelSrvEff(
			string m3PRNO = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelSrvEff",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());

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
		/// Name DisconnectMtrl
		/// Description Disconnect existing matrl from a service
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3MSEQ">Sequence number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DisconnectMtrl(
			string m3FACI, 
			string m3SUFI, 
			int m3MSEQ, 
			int? m3CONO = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DisconnectMtrl",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("SUFI", m3SUFI.Trim())
				.WithQueryParameter("MSEQ", m3MSEQ.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());

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
		/// Name DisconnectOper
		/// Description Disconnect existing oper from a service
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DisconnectOper(
			string m3FACI, 
			string m3SUFI, 
			int m3OPNO, 
			string m3PRNO = null, 
			string m3STRT = null, 
			DateTime? m3FDAT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DisconnectOper",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("SUFI", m3SUFI.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());

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
		/// Name GetBasic
		/// Description Get basic data for service
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBasicResponse></returns>
		/// <exception cref="M3Exception<GetBasicResponse>"></exception>
		public async Task<M3Response<GetBasicResponse>> GetBasic(
			string m3SUFI, 
			int? m3CONO = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetBasic",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3SUFI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());

			// Execute the request
			var result = await Execute<GetBasicResponse>(
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
		/// Name GetMaintLim
		/// Description Get Maintenance Limit
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3MPGM">Maintenance program</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3ECVE">Revision number</param>
		/// <param name="m3MVER">Version number</param>
		/// <param name="m3MES0">Meter</param>
		/// <param name="m3THIN">Threshold interval</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMaintLimResponse></returns>
		/// <exception cref="M3Exception<GetMaintLimResponse>"></exception>
		public async Task<M3Response<GetMaintLimResponse>> GetMaintLim(
			string m3PRNO, 
			string m3SUFI, 
			string m3MPGM = null, 
			string m3STRT = null, 
			string m3ECVE = null, 
			int? m3MVER = null, 
			string m3MES0 = null, 
			decimal? m3THIN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetMaintLim",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("SUFI", m3SUFI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MPGM))
				request.WithQueryParameter("MPGM", m3MPGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECVE))
				request.WithQueryParameter("ECVE", m3ECVE.Trim());
			if (m3MVER.HasValue)
				request.WithQueryParameter("MVER", m3MVER.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MES0))
				request.WithQueryParameter("MES0", m3MES0.Trim());
			if (m3THIN.HasValue)
				request.WithQueryParameter("THIN", m3THIN.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetMaintLimResponse>(
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
		/// Name GetMtrl
		/// Description Get Material for a service
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3MSEQ">Sequence number (Required)</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMtrlResponse></returns>
		/// <exception cref="M3Exception<GetMtrlResponse>"></exception>
		public async Task<M3Response<GetMtrlResponse>> GetMtrl(
			string m3FACI, 
			int m3MSEQ, 
			string m3PRNO = null, 
			string m3STRT = null, 
			DateTime? m3FDAT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetMtrl",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("MSEQ", m3MSEQ.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());

			// Execute the request
			var result = await Execute<GetMtrlResponse>(
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
		/// Name GetOp
		/// Description Get Operation for
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOpResponse></returns>
		/// <exception cref="M3Exception<GetOpResponse>"></exception>
		public async Task<M3Response<GetOpResponse>> GetOp(
			string m3FACI, 
			int m3OPNO, 
			int? m3CONO = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetOp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());

			// Execute the request
			var result = await Execute<GetOpResponse>(
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
		/// Name GetOp2
		/// Description Get OEM Code of Operation for a service
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOp2Response></returns>
		/// <exception cref="M3Exception<GetOp2Response>"></exception>
		public async Task<M3Response<GetOp2Response>> GetOp2(
			string m3FACI, 
			string m3SUFI, 
			int m3OPNO, 
			int? m3CONO = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetOp2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("SUFI", m3SUFI.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());

			// Execute the request
			var result = await Execute<GetOp2Response>(
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
		/// Name GetOpElement
		/// Description GetOperation Element
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3ACTS">Task element number (Required)</param>
		/// <param name="m3ACTT">Operation element type (Required)</param>
		/// <param name="m3ACTR">Work element (Required)</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3CATY">Capability type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOpElementResponse></returns>
		/// <exception cref="M3Exception<GetOpElementResponse>"></exception>
		public async Task<M3Response<GetOpElementResponse>> GetOpElement(
			string m3FACI, 
			int m3OPNO, 
			int m3ACTS, 
			string m3ACTT, 
			string m3ACTR, 
			string m3PRNO = null, 
			string m3STRT = null, 
			DateTime? m3FDAT = null, 
			string m3CATY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetOpElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3ACTT))
				throw new ArgumentNullException(nameof(m3ACTT));
			if (string.IsNullOrWhiteSpace(m3ACTR))
				throw new ArgumentNullException(nameof(m3ACTR));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ACTS", m3ACTS.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ACTT", m3ACTT.Trim())
				.WithQueryParameter("ACTR", m3ACTR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CATY))
				request.WithQueryParameter("CATY", m3CATY.Trim());

			// Execute the request
			var result = await Execute<GetOpElementResponse>(
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
		/// Name GetRelSrv
		/// Description Get Related Service
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3MPGM">Maintenance program</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3RESQ">Sequence number</param>
		/// <param name="m3RPRN">Product number</param>
		/// <param name="m3RSTS">Product structure type</param>
		/// <param name="m3RSUF">Service</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetRelSrvResponse></returns>
		/// <exception cref="M3Exception<GetRelSrvResponse>"></exception>
		public async Task<M3Response<GetRelSrvResponse>> GetRelSrv(
			string m3SUFI, 
			string m3MPGM = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			int? m3RESQ = null, 
			string m3RPRN = null, 
			string m3RSTS = null, 
			string m3RSUF = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetRelSrv",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3SUFI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MPGM))
				request.WithQueryParameter("MPGM", m3MPGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3RESQ.HasValue)
				request.WithQueryParameter("RESQ", m3RESQ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RPRN))
				request.WithQueryParameter("RPRN", m3RPRN.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSTS))
				request.WithQueryParameter("RSTS", m3RSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSUF))
				request.WithQueryParameter("RSUF", m3RSUF.Trim());

			// Execute the request
			var result = await Execute<GetRelSrvResponse>(
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
		/// Name GetServiceFaci
		/// Description Get basic data for service/faciilty
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetServiceFaciResponse></returns>
		/// <exception cref="M3Exception<GetServiceFaciResponse>"></exception>
		public async Task<M3Response<GetServiceFaciResponse>> GetServiceFaci(
			string m3SUFI, 
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetServiceFaci",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3SUFI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());

			// Execute the request
			var result = await Execute<GetServiceFaciResponse>(
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
		/// Name GetSpecReq
		/// Description Get Specific Requirement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3SPRQ">Specific requirement category (Required)</param>
		/// <param name="m3SPRT">Specific requirements (Required)</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSpecReqResponse></returns>
		/// <exception cref="M3Exception<GetSpecReqResponse>"></exception>
		public async Task<M3Response<GetSpecReqResponse>> GetSpecReq(
			string m3SUFI, 
			string m3SPRQ, 
			string m3SPRT, 
			string m3PRNO = null, 
			string m3STRT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetSpecReq",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));
			if (string.IsNullOrWhiteSpace(m3SPRQ))
				throw new ArgumentNullException(nameof(m3SPRQ));
			if (string.IsNullOrWhiteSpace(m3SPRT))
				throw new ArgumentNullException(nameof(m3SPRT));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3SUFI.Trim())
				.WithQueryParameter("SPRQ", m3SPRQ.Trim())
				.WithQueryParameter("SPRT", m3SPRT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());

			// Execute the request
			var result = await Execute<GetSpecReqResponse>(
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
		/// Name GetSrvEff
		/// Description Get Service Effectivity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3OPNO">Operation number</param>
		/// <param name="m3MSEQ">Sequence number</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSrvEffResponse></returns>
		/// <exception cref="M3Exception<GetSrvEffResponse>"></exception>
		public async Task<M3Response<GetSrvEffResponse>> GetSrvEff(
			string m3PRNO = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			int? m3OPNO = null, 
			int? m3MSEQ = null, 
			DateTime? m3FDAT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetSrvEff",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (m3OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3OPNO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3MSEQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());

			// Execute the request
			var result = await Execute<GetSrvEffResponse>(
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
		/// Name LstByProduct
		/// Description List by service
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PRNO">Product/item (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByProductResponse></returns>
		/// <exception cref="M3Exception<LstByProductResponse>"></exception>
		public async Task<M3Response<LstByProductResponse>> LstByProduct(
			string m3PRNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstByProduct",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRNO", m3PRNO.Trim());

			// Execute the request
			var result = await Execute<LstByProductResponse>(
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
		/// Name LstMaintLim
		/// Description List Maintenance Limit
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PRNO">Product number (Required)</param>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3MPGM">Maintenance program</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3ECVE">Revision number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMaintLimResponse></returns>
		/// <exception cref="M3Exception<LstMaintLimResponse>"></exception>
		public async Task<M3Response<LstMaintLimResponse>> LstMaintLim(
			string m3PRNO, 
			string m3SUFI, 
			string m3MPGM = null, 
			string m3STRT = null, 
			string m3ECVE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstMaintLim",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRNO))
				throw new ArgumentNullException(nameof(m3PRNO));
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRNO", m3PRNO.Trim())
				.WithQueryParameter("SUFI", m3SUFI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MPGM))
				request.WithQueryParameter("MPGM", m3MPGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECVE))
				request.WithQueryParameter("ECVE", m3ECVE.Trim());

			// Execute the request
			var result = await Execute<LstMaintLimResponse>(
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
		/// Name LstOpElement
		/// Description List Operation Element
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3OPNO">Operation number (Required)</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstOpElementResponse></returns>
		/// <exception cref="M3Exception<LstOpElementResponse>"></exception>
		public async Task<M3Response<LstOpElementResponse>> LstOpElement(
			string m3FACI, 
			int m3OPNO, 
			string m3PRNO = null, 
			string m3STRT = null, 
			DateTime? m3FDAT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstOpElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("OPNO", m3OPNO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstOpElementResponse>(
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
		/// Name LstOpnoMtrl
		/// Description List all operation and material for a service
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SUFI">Service</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstOpnoMtrlResponse></returns>
		/// <exception cref="M3Exception<LstOpnoMtrlResponse>"></exception>
		public async Task<M3Response<LstOpnoMtrlResponse>> LstOpnoMtrl(
			string m3FACI = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			string m3SUFI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstOpnoMtrl",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUFI))
				request.WithQueryParameter("SUFI", m3SUFI.Trim());

			// Execute the request
			var result = await Execute<LstOpnoMtrlResponse>(
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
		/// Name LstRelSrv
		/// Description List Related Service
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3MPGM">Maintenance program</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRelSrvResponse></returns>
		/// <exception cref="M3Exception<LstRelSrvResponse>"></exception>
		public async Task<M3Response<LstRelSrvResponse>> LstRelSrv(
			string m3SUFI, 
			string m3MPGM = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstRelSrv",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3SUFI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MPGM))
				request.WithQueryParameter("MPGM", m3MPGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());

			// Execute the request
			var result = await Execute<LstRelSrvResponse>(
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
		/// Name LstServiceH
		/// Description List by service (like panel H in MOS300)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstServiceHResponse></returns>
		/// <exception cref="M3Exception<LstServiceHResponse>"></exception>
		public async Task<M3Response<LstServiceHResponse>> LstServiceH(
			int? m3CONO = null, 
			string m3FACI = null, 
			string m3PRNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstServiceH",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());

			// Execute the request
			var result = await Execute<LstServiceHResponse>(
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
		/// Name LstServiceH2
		/// Description List by service (like panel G in MOS300)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstServiceH2Response></returns>
		/// <exception cref="M3Exception<LstServiceH2Response>"></exception>
		public async Task<M3Response<LstServiceH2Response>> LstServiceH2(
			int? m3CONO = null, 
			string m3PRNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstServiceH2",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());

			// Execute the request
			var result = await Execute<LstServiceH2Response>(
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
		/// Name LstSpecReq
		/// Description List Specific Requirement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3SPRQ">Specific requirement category (Required)</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSpecReqResponse></returns>
		/// <exception cref="M3Exception<LstSpecReqResponse>"></exception>
		public async Task<M3Response<LstSpecReqResponse>> LstSpecReq(
			string m3SUFI, 
			string m3SPRQ, 
			string m3PRNO = null, 
			string m3STRT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstSpecReq",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));
			if (string.IsNullOrWhiteSpace(m3SPRQ))
				throw new ArgumentNullException(nameof(m3SPRQ));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3SUFI.Trim())
				.WithQueryParameter("SPRQ", m3SPRQ.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());

			// Execute the request
			var result = await Execute<LstSpecReqResponse>(
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
		/// Name LstSrvEff
		/// Description List Service Effectivity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSrvEffResponse></returns>
		/// <exception cref="M3Exception<LstSrvEffResponse>"></exception>
		public async Task<M3Response<LstSrvEffResponse>> LstSrvEff(
			string m3SUFI, 
			string m3PRNO = null, 
			string m3STRT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstSrvEff",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3SUFI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());

			// Execute the request
			var result = await Execute<LstSrvEffResponse>(
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
		/// Name UpdServiceH
		/// Description Update Service Quick entry (like panel H in MOS300)
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3STDT">Start date</param>
		/// <param name="m3TODT">To date</param>
		/// <param name="m3RESP">Responsible</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TOFP">Process type</param>
		/// <param name="m3SRGP">Service group</param>
		/// <param name="m3ZSET">Service level</param>
		/// <param name="m3SCHD">Scheduled maintenance service</param>
		/// <param name="m3EVTY">Event type</param>
		/// <param name="m3EVTS">Event sequence</param>
		/// <param name="m3NSTP">Shutdown</param>
		/// <param name="m3ACRF">User-defined accounting control object</param>
		/// <param name="m3PLCD">Planning policy</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3MES1">Meter 1</param>
		/// <param name="m3REIN">Repeat interval</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="m3PITI">Run time</param>
		/// <param name="m3PRNP">Planned number of workers - run time</param>
		/// <param name="m3OPDS">Operation description</param>
		/// <param name="m3AAFR">Alarm limit</param>
		/// <param name="m3AATO">Alarm limit</param>
		/// <param name="m3AATR">Trend limit</param>
		/// <param name="m3MES0">Meter</param>
		/// <param name="m3RUOM">Result unit of measure</param>
		/// <param name="m3DOID">Document identity</param>
		/// <param name="m3NUC1">Number of put-away cards</param>
		/// <param name="m3NUC2">Number of material requisitions</param>
		/// <param name="m3NUC3">Number of labor tickets</param>
		/// <param name="m3NUC4">Number of shop travelers</param>
		/// <param name="m3NUC5">Number of routing cards</param>
		/// <param name="m3NUC6">Number of picking lists</param>
		/// <param name="m3NUC7">Number of design documents</param>
		/// <param name="m3TXL1">Text</param>
		/// <param name="m3TXL2">Text</param>
		/// <param name="m3TXL3">Text</param>
		/// <param name="m3TXL4">Text</param>
		/// <param name="m3TXL5">Text</param>
		/// <param name="m3TXL6">Text</param>
		/// <param name="m3TXL7">Text</param>
		/// <param name="m3TXL8">Text</param>
		/// <param name="m3TXL9">Text</param>
		/// <param name="m3TXL0">Text</param>
		/// <param name="m3EDWT">Estimated downtime</param>
		/// <param name="m3SCHL">Scheduling logic</param>
		/// <param name="m3PLMZ">Planning horizon</param>
		/// <param name="m3STYP">Service Type</param>
		/// <param name="m3ACWA">Claim warranty</param>
		/// <param name="m3EXCH">Exchange</param>
		/// <param name="m3SPMT">Issue method</param>
		/// <param name="m3ACNF">Automatic approval of service</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdServiceH(
			string m3SUFI, 
			string m3FACI, 
			int? m3CONO = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			string m3STAT = null, 
			DateTime? m3STDT = null, 
			DateTime? m3TODT = null, 
			string m3RESP = null, 
			string m3TX40 = null, 
			string m3TOFP = null, 
			string m3SRGP = null, 
			int? m3ZSET = null, 
			int? m3SCHD = null, 
			string m3EVTY = null, 
			int? m3EVTS = null, 
			int? m3NSTP = null, 
			string m3ACRF = null, 
			string m3PLCD = null, 
			string m3ORTY = null, 
			string m3MES1 = null, 
			decimal? m3REIN = null, 
			string m3PLGR = null, 
			int? m3PITI = null, 
			int? m3PRNP = null, 
			string m3OPDS = null, 
			string m3AAFR = null, 
			string m3AATO = null, 
			string m3AATR = null, 
			string m3MES0 = null, 
			string m3RUOM = null, 
			string m3DOID = null, 
			int? m3NUC1 = null, 
			int? m3NUC2 = null, 
			int? m3NUC3 = null, 
			int? m3NUC4 = null, 
			int? m3NUC5 = null, 
			int? m3NUC6 = null, 
			int? m3NUC7 = null, 
			string m3TXL1 = null, 
			string m3TXL2 = null, 
			string m3TXL3 = null, 
			string m3TXL4 = null, 
			string m3TXL5 = null, 
			string m3TXL6 = null, 
			string m3TXL7 = null, 
			string m3TXL8 = null, 
			string m3TXL9 = null, 
			string m3TXL0 = null, 
			int? m3EDWT = null, 
			int? m3SCHL = null, 
			int? m3PLMZ = null, 
			string m3STYP = null, 
			int? m3ACWA = null, 
			int? m3EXCH = null, 
			int? m3SPMT = null, 
			int? m3ACNF = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdServiceH",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3SUFI.Trim())
				.WithQueryParameter("FACI", m3FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3STDT.HasValue)
				request.WithQueryParameter("STDT", m3STDT.Value.ToM3String());
			if (m3TODT.HasValue)
				request.WithQueryParameter("TODT", m3TODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3RESP))
				request.WithQueryParameter("RESP", m3RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TOFP))
				request.WithQueryParameter("TOFP", m3TOFP.Trim());
			if (!string.IsNullOrWhiteSpace(m3SRGP))
				request.WithQueryParameter("SRGP", m3SRGP.Trim());
			if (m3ZSET.HasValue)
				request.WithQueryParameter("ZSET", m3ZSET.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCHD.HasValue)
				request.WithQueryParameter("SCHD", m3SCHD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3EVTY))
				request.WithQueryParameter("EVTY", m3EVTY.Trim());
			if (m3EVTS.HasValue)
				request.WithQueryParameter("EVTS", m3EVTS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NSTP.HasValue)
				request.WithQueryParameter("NSTP", m3NSTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLCD))
				request.WithQueryParameter("PLCD", m3PLCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3MES1))
				request.WithQueryParameter("MES1", m3MES1.Trim());
			if (m3REIN.HasValue)
				request.WithQueryParameter("REIN", m3REIN.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());
			if (m3PITI.HasValue)
				request.WithQueryParameter("PITI", m3PITI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3PRNP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OPDS))
				request.WithQueryParameter("OPDS", m3OPDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3AAFR))
				request.WithQueryParameter("AAFR", m3AAFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3AATO))
				request.WithQueryParameter("AATO", m3AATO.Trim());
			if (!string.IsNullOrWhiteSpace(m3AATR))
				request.WithQueryParameter("AATR", m3AATR.Trim());
			if (!string.IsNullOrWhiteSpace(m3MES0))
				request.WithQueryParameter("MES0", m3MES0.Trim());
			if (!string.IsNullOrWhiteSpace(m3RUOM))
				request.WithQueryParameter("RUOM", m3RUOM.Trim());
			if (!string.IsNullOrWhiteSpace(m3DOID))
				request.WithQueryParameter("DOID", m3DOID.Trim());
			if (m3NUC1.HasValue)
				request.WithQueryParameter("NUC1", m3NUC1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUC2.HasValue)
				request.WithQueryParameter("NUC2", m3NUC2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUC3.HasValue)
				request.WithQueryParameter("NUC3", m3NUC3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUC4.HasValue)
				request.WithQueryParameter("NUC4", m3NUC4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUC5.HasValue)
				request.WithQueryParameter("NUC5", m3NUC5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUC6.HasValue)
				request.WithQueryParameter("NUC6", m3NUC6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NUC7.HasValue)
				request.WithQueryParameter("NUC7", m3NUC7.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TXL1))
				request.WithQueryParameter("TXL1", m3TXL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXL2))
				request.WithQueryParameter("TXL2", m3TXL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXL3))
				request.WithQueryParameter("TXL3", m3TXL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXL4))
				request.WithQueryParameter("TXL4", m3TXL4.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXL5))
				request.WithQueryParameter("TXL5", m3TXL5.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXL6))
				request.WithQueryParameter("TXL6", m3TXL6.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXL7))
				request.WithQueryParameter("TXL7", m3TXL7.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXL8))
				request.WithQueryParameter("TXL8", m3TXL8.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXL9))
				request.WithQueryParameter("TXL9", m3TXL9.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXL0))
				request.WithQueryParameter("TXL0", m3TXL0.Trim());
			if (m3EDWT.HasValue)
				request.WithQueryParameter("EDWT", m3EDWT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCHL.HasValue)
				request.WithQueryParameter("SCHL", m3SCHL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PLMZ.HasValue)
				request.WithQueryParameter("PLMZ", m3PLMZ.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3STYP))
				request.WithQueryParameter("STYP", m3STYP.Trim());
			if (m3ACWA.HasValue)
				request.WithQueryParameter("ACWA", m3ACWA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EXCH.HasValue)
				request.WithQueryParameter("EXCH", m3EXCH.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SPMT.HasValue)
				request.WithQueryParameter("SPMT", m3SPMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ACNF.HasValue)
				request.WithQueryParameter("ACNF", m3ACNF.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdServiceH2
		/// Description Update Service Quick entry (like panel G in MOS300)
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3SUFI">Service (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PRNO">Product number</param>
		/// <param name="m3STRT">Product structure type</param>
		/// <param name="m3SMC0">User defined field 1</param>
		/// <param name="m3SMC1">User defined field 2</param>
		/// <param name="m3SMC2">User defined field 3</param>
		/// <param name="m3SMC3">User defined field 4</param>
		/// <param name="m3SMC4">User defined field 5</param>
		/// <param name="m3SMC5">User defined field 6</param>
		/// <param name="m3SMC6">User defined field 7</param>
		/// <param name="m3SMC7">User defined field 8</param>
		/// <param name="m3SMC8">User defined field 9</param>
		/// <param name="m3SMC9">User defined field 10</param>
		/// <param name="m3CFI1">User-defined field 1 - item</param>
		/// <param name="m3CFI2">New field description</param>
		/// <param name="m3CFI3">User-defined field 3 - item</param>
		/// <param name="m3CFI4">User-defined field 4 - item</param>
		/// <param name="m3CFI5">User-defined field 5 - item</param>
		/// <param name="m3TAXC">Tax code customer/address</param>
		/// <param name="m3TXCS">Tax Code Customer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdServiceH2(
			string m3FACI, 
			string m3SUFI, 
			int? m3CONO = null, 
			string m3PRNO = null, 
			string m3STRT = null, 
			string m3SMC0 = null, 
			string m3SMC1 = null, 
			string m3SMC2 = null, 
			string m3SMC3 = null, 
			string m3SMC4 = null, 
			string m3SMC5 = null, 
			string m3SMC6 = null, 
			string m3SMC7 = null, 
			string m3SMC8 = null, 
			string m3SMC9 = null, 
			string m3CFI1 = null, 
			decimal? m3CFI2 = null, 
			string m3CFI3 = null, 
			string m3CFI4 = null, 
			string m3CFI5 = null, 
			string m3TAXC = null, 
			string m3TXCS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdServiceH2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3SUFI))
				throw new ArgumentNullException(nameof(m3SUFI));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("SUFI", m3SUFI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PRNO))
				request.WithQueryParameter("PRNO", m3PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3STRT))
				request.WithQueryParameter("STRT", m3STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC0))
				request.WithQueryParameter("SMC0", m3SMC0.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC1))
				request.WithQueryParameter("SMC1", m3SMC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC2))
				request.WithQueryParameter("SMC2", m3SMC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC3))
				request.WithQueryParameter("SMC3", m3SMC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC4))
				request.WithQueryParameter("SMC4", m3SMC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC5))
				request.WithQueryParameter("SMC5", m3SMC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC6))
				request.WithQueryParameter("SMC6", m3SMC6.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC7))
				request.WithQueryParameter("SMC7", m3SMC7.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC8))
				request.WithQueryParameter("SMC8", m3SMC8.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMC9))
				request.WithQueryParameter("SMC9", m3SMC9.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI1))
				request.WithQueryParameter("CFI1", m3CFI1.Trim());
			if (m3CFI2.HasValue)
				request.WithQueryParameter("CFI2", m3CFI2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CFI3))
				request.WithQueryParameter("CFI3", m3CFI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI4))
				request.WithQueryParameter("CFI4", m3CFI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI5))
				request.WithQueryParameter("CFI5", m3CFI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAXC))
				request.WithQueryParameter("TAXC", m3TAXC.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXCS))
				request.WithQueryParameter("TXCS", m3TXCS.Trim());

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
