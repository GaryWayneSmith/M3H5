/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddMaintLim
		/// Description Add Maintenance Limit
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_MES0">Meter (Required)</param>
		/// <param name="m3_THIN">Threshold interval (Required)</param>
		/// <param name="m3_MPGM">Maintenance program</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_ECVE">Revision number</param>
		/// <param name="m3_MVER">Version number</param>
		/// <param name="m3_REIN">Repeat interval</param>
		/// <param name="m3_INTL">Operational tolerance</param>
		/// <param name="m3_ETO1">Economical tolerance 1</param>
		/// <param name="m3_ETO2">Economical tolerance 2</param>
		/// <param name="m3_SAMP">Sampling percentage</param>
		/// <param name="m3_SIMC">Simulation</param>
		/// <param name="m3_WMLI">Inventory maintenance</param>
		/// <param name="m3_MLIM">Lifetime maintenance limit</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddMaintLim(
			string m3_PRNO, 
			string m3_SUFI, 
			string m3_MES0, 
			decimal m3_THIN, 
			string m3_MPGM = null, 
			string m3_STRT = null, 
			string m3_ECVE = null, 
			int? m3_MVER = null, 
			decimal? m3_REIN = null, 
			decimal? m3_INTL = null, 
			decimal? m3_ETO1 = null, 
			decimal? m3_ETO2 = null, 
			int? m3_SAMP = null, 
			int? m3_SIMC = null, 
			int? m3_WMLI = null, 
			int? m3_MLIM = null, 
			decimal? m3_TXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddMaintLim",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");
			if (string.IsNullOrWhiteSpace(m3_MES0))
				throw new ArgumentNullException("m3_MES0");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("SUFI", m3_SUFI.Trim())
				.WithQueryParameter("MES0", m3_MES0.Trim())
				.WithQueryParameter("THIN", m3_THIN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MPGM))
				request.WithQueryParameter("MPGM", m3_MPGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECVE))
				request.WithQueryParameter("ECVE", m3_ECVE.Trim());
			if (m3_MVER.HasValue)
				request.WithQueryParameter("MVER", m3_MVER.Value.ToString());
			if (m3_REIN.HasValue)
				request.WithQueryParameter("REIN", m3_REIN.Value.ToString());
			if (m3_INTL.HasValue)
				request.WithQueryParameter("INTL", m3_INTL.Value.ToString());
			if (m3_ETO1.HasValue)
				request.WithQueryParameter("ETO1", m3_ETO1.Value.ToString());
			if (m3_ETO2.HasValue)
				request.WithQueryParameter("ETO2", m3_ETO2.Value.ToString());
			if (m3_SAMP.HasValue)
				request.WithQueryParameter("SAMP", m3_SAMP.Value.ToString());
			if (m3_SIMC.HasValue)
				request.WithQueryParameter("SIMC", m3_SIMC.Value.ToString());
			if (m3_WMLI.HasValue)
				request.WithQueryParameter("WMLI", m3_WMLI.Value.ToString());
			if (m3_MLIM.HasValue)
				request.WithQueryParameter("MLIM", m3_MLIM.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

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
		/// Name AddOp
		/// Description Add Operation to a service
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_PLGR">Work center (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_PITI">Run time</param>
		/// <param name="m3_PRNP">Planned number of workers - run time</param>
		/// <param name="m3_OPDS">Operation description</param>
		/// <param name="m3_DOID">Document identity</param>
		/// <param name="m3_TXL1">Text</param>
		/// <param name="m3_TXL2">Text</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_TDAT">To date</param>
		/// <param name="m3_SETI">Setup time</param>
		/// <param name="m3_SENP">Planned number of workers - setup</param>
		/// <param name="m3_RUNO">OEM hours</param>
		/// <param name="m3_RUNP">Price hours</param>
		/// <param name="m3_RUNT">Target hours</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddOp(
			string m3_FACI, 
			string m3_SUFI, 
			string m3_PLGR, 
			int? m3_CONO = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			int? m3_OPNO = null, 
			int? m3_PITI = null, 
			int? m3_PRNP = null, 
			string m3_OPDS = null, 
			string m3_DOID = null, 
			string m3_TXL1 = null, 
			string m3_TXL2 = null, 
			DateTime? m3_FDAT = null, 
			DateTime? m3_TDAT = null, 
			int? m3_SETI = null, 
			int? m3_SENP = null, 
			int? m3_RUNO = null, 
			int? m3_RUNP = null, 
			int? m3_RUNT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddOp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");
			if (string.IsNullOrWhiteSpace(m3_PLGR))
				throw new ArgumentNullException("m3_PLGR");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("SUFI", m3_SUFI.Trim())
				.WithQueryParameter("PLGR", m3_PLGR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (m3_PITI.HasValue)
				request.WithQueryParameter("PITI", m3_PITI.Value.ToString());
			if (m3_PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3_PRNP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OPDS))
				request.WithQueryParameter("OPDS", m3_OPDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOID))
				request.WithQueryParameter("DOID", m3_DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL1))
				request.WithQueryParameter("TXL1", m3_TXL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL2))
				request.WithQueryParameter("TXL2", m3_TXL2.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());
			if (m3_TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3_TDAT.Value.ToM3String());
			if (m3_SETI.HasValue)
				request.WithQueryParameter("SETI", m3_SETI.Value.ToString());
			if (m3_SENP.HasValue)
				request.WithQueryParameter("SENP", m3_SENP.Value.ToString());
			if (m3_RUNO.HasValue)
				request.WithQueryParameter("RUNO", m3_RUNO.Value.ToString());
			if (m3_RUNP.HasValue)
				request.WithQueryParameter("RUNP", m3_RUNP.Value.ToString());
			if (m3_RUNT.HasValue)
				request.WithQueryParameter("RUNT", m3_RUNT.Value.ToString());

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
		/// Name AddOp2
		/// Description Add OEM Code of Operation to a service
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_SMC0">User defined field 1</param>
		/// <param name="m3_SMC1">User defined field 2</param>
		/// <param name="m3_SMC2">User defined field 3</param>
		/// <param name="m3_SMC3">User defined field 4</param>
		/// <param name="m3_SMC4">User defined field 5</param>
		/// <param name="m3_SMC5">User defined field 6</param>
		/// <param name="m3_SMC6">User defined field 7</param>
		/// <param name="m3_SMC7">User defined field 8</param>
		/// <param name="m3_SMC8">User defined field 9</param>
		/// <param name="m3_SMC9">User defined field 10</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddOp2(
			string m3_FACI, 
			string m3_SUFI, 
			int m3_OPNO, 
			int? m3_CONO = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			DateTime? m3_FDAT = null, 
			string m3_SMC0 = null, 
			string m3_SMC1 = null, 
			string m3_SMC2 = null, 
			string m3_SMC3 = null, 
			string m3_SMC4 = null, 
			string m3_SMC5 = null, 
			string m3_SMC6 = null, 
			string m3_SMC7 = null, 
			string m3_SMC8 = null, 
			string m3_SMC9 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddOp2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("SUFI", m3_SUFI.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_SMC0))
				request.WithQueryParameter("SMC0", m3_SMC0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC1))
				request.WithQueryParameter("SMC1", m3_SMC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC2))
				request.WithQueryParameter("SMC2", m3_SMC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC3))
				request.WithQueryParameter("SMC3", m3_SMC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC4))
				request.WithQueryParameter("SMC4", m3_SMC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC5))
				request.WithQueryParameter("SMC5", m3_SMC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC6))
				request.WithQueryParameter("SMC6", m3_SMC6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC7))
				request.WithQueryParameter("SMC7", m3_SMC7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC8))
				request.WithQueryParameter("SMC8", m3_SMC8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC9))
				request.WithQueryParameter("SMC9", m3_SMC9.Trim());

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
		/// Name AddOpElement
		/// Description Add Operation Element
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_ACTS">Task element number (Required)</param>
		/// <param name="m3_ACTT">Operation element type (Required)</param>
		/// <param name="m3_ACTR">Work element (Required)</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_CATY">Capability type</param>
		/// <param name="m3_TOOL">Tool number</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_DOID">Document identity</param>
		/// <param name="m3_INSI">Inspection identity</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_ACDS">Description</param>
		/// <param name="m3_TXT1">Text line 1</param>
		/// <param name="m3_TXT2">Text line 2</param>
		/// <param name="m3_SETI">Setup time</param>
		/// <param name="m3_PITI">Run time</param>
		/// <param name="m3_SENP">Planned number of workers - setup</param>
		/// <param name="m3_PRNP">Planned number of workers - run time</param>
		/// <param name="m3_LASK">Labor skill</param>
		/// <param name="m3_INSK">Inspection skill</param>
		/// <param name="m3_MVA1">Meter value 1</param>
		/// <param name="m3_MVA2">Meter value 2</param>
		/// <param name="m3_MVA3">Meter value 3</param>
		/// <param name="m3_MVA4">Meter value 4</param>
		/// <param name="m3_PEQ1">Quantity or time</param>
		/// <param name="m3_PEQ2">Quantity or time</param>
		/// <param name="m3_PEQ3">Quantity or time</param>
		/// <param name="m3_PEQ4">Quantity or time</param>
		/// <param name="m3_PET1">Trigger type</param>
		/// <param name="m3_PET2">Trigger type</param>
		/// <param name="m3_PET3">Trigger type</param>
		/// <param name="m3_PET4">Trigger type</param>
		/// <param name="m3_PERM">Permit</param>
		/// <param name="m3_CLEV">Capability level</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_TRQT">Transaction quantity - basic U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddOpElement(
			string m3_FACI, 
			int m3_OPNO, 
			int m3_ACTS, 
			string m3_ACTT, 
			string m3_ACTR, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			DateTime? m3_FDAT = null, 
			string m3_CATY = null, 
			string m3_TOOL = null, 
			string m3_SERN = null, 
			string m3_DOID = null, 
			string m3_INSI = null, 
			string m3_SUFI = null, 
			string m3_ACDS = null, 
			string m3_TXT1 = null, 
			string m3_TXT2 = null, 
			int? m3_SETI = null, 
			int? m3_PITI = null, 
			int? m3_SENP = null, 
			int? m3_PRNP = null, 
			string m3_LASK = null, 
			string m3_INSK = null, 
			decimal? m3_MVA1 = null, 
			decimal? m3_MVA2 = null, 
			decimal? m3_MVA3 = null, 
			decimal? m3_MVA4 = null, 
			int? m3_PEQ1 = null, 
			int? m3_PEQ2 = null, 
			int? m3_PEQ3 = null, 
			int? m3_PEQ4 = null, 
			int? m3_PET1 = null, 
			int? m3_PET2 = null, 
			int? m3_PET3 = null, 
			int? m3_PET4 = null, 
			string m3_PERM = null, 
			int? m3_CLEV = null, 
			decimal? m3_TXID = null, 
			decimal? m3_TRQT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddOpElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_ACTT))
				throw new ArgumentNullException("m3_ACTT");
			if (string.IsNullOrWhiteSpace(m3_ACTR))
				throw new ArgumentNullException("m3_ACTR");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString())
				.WithQueryParameter("ACTS", m3_ACTS.ToString())
				.WithQueryParameter("ACTT", m3_ACTT.Trim())
				.WithQueryParameter("ACTR", m3_ACTR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CATY))
				request.WithQueryParameter("CATY", m3_CATY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOOL))
				request.WithQueryParameter("TOOL", m3_TOOL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOID))
				request.WithQueryParameter("DOID", m3_DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INSI))
				request.WithQueryParameter("INSI", m3_INSI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACDS))
				request.WithQueryParameter("ACDS", m3_ACDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXT1))
				request.WithQueryParameter("TXT1", m3_TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXT2))
				request.WithQueryParameter("TXT2", m3_TXT2.Trim());
			if (m3_SETI.HasValue)
				request.WithQueryParameter("SETI", m3_SETI.Value.ToString());
			if (m3_PITI.HasValue)
				request.WithQueryParameter("PITI", m3_PITI.Value.ToString());
			if (m3_SENP.HasValue)
				request.WithQueryParameter("SENP", m3_SENP.Value.ToString());
			if (m3_PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3_PRNP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LASK))
				request.WithQueryParameter("LASK", m3_LASK.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INSK))
				request.WithQueryParameter("INSK", m3_INSK.Trim());
			if (m3_MVA1.HasValue)
				request.WithQueryParameter("MVA1", m3_MVA1.Value.ToString());
			if (m3_MVA2.HasValue)
				request.WithQueryParameter("MVA2", m3_MVA2.Value.ToString());
			if (m3_MVA3.HasValue)
				request.WithQueryParameter("MVA3", m3_MVA3.Value.ToString());
			if (m3_MVA4.HasValue)
				request.WithQueryParameter("MVA4", m3_MVA4.Value.ToString());
			if (m3_PEQ1.HasValue)
				request.WithQueryParameter("PEQ1", m3_PEQ1.Value.ToString());
			if (m3_PEQ2.HasValue)
				request.WithQueryParameter("PEQ2", m3_PEQ2.Value.ToString());
			if (m3_PEQ3.HasValue)
				request.WithQueryParameter("PEQ3", m3_PEQ3.Value.ToString());
			if (m3_PEQ4.HasValue)
				request.WithQueryParameter("PEQ4", m3_PEQ4.Value.ToString());
			if (m3_PET1.HasValue)
				request.WithQueryParameter("PET1", m3_PET1.Value.ToString());
			if (m3_PET2.HasValue)
				request.WithQueryParameter("PET2", m3_PET2.Value.ToString());
			if (m3_PET3.HasValue)
				request.WithQueryParameter("PET3", m3_PET3.Value.ToString());
			if (m3_PET4.HasValue)
				request.WithQueryParameter("PET4", m3_PET4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PERM))
				request.WithQueryParameter("PERM", m3_PERM.Trim());
			if (m3_CLEV.HasValue)
				request.WithQueryParameter("CLEV", m3_CLEV.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3_TRQT.Value.ToString());

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
		/// Name AddRelSrv
		/// Description Add Related Service
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_RSUF">Service (Required)</param>
		/// <param name="m3_MREL">Maintenance relation (Required)</param>
		/// <param name="m3_MPGM">Maintenance program</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_RESQ">Sequence number</param>
		/// <param name="m3_RPRN">Product number</param>
		/// <param name="m3_RSTS">Product structure type</param>
		/// <param name="m3_MMAM">Mandatory relationship</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddRelSrv(
			string m3_SUFI, 
			string m3_RSUF, 
			string m3_MREL, 
			string m3_MPGM = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			int? m3_RESQ = null, 
			string m3_RPRN = null, 
			string m3_RSTS = null, 
			int? m3_MMAM = null, 
			decimal? m3_TXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddRelSrv",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");
			if (string.IsNullOrWhiteSpace(m3_RSUF))
				throw new ArgumentNullException("m3_RSUF");
			if (string.IsNullOrWhiteSpace(m3_MREL))
				throw new ArgumentNullException("m3_MREL");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3_SUFI.Trim())
				.WithQueryParameter("RSUF", m3_RSUF.Trim())
				.WithQueryParameter("MREL", m3_MREL.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MPGM))
				request.WithQueryParameter("MPGM", m3_MPGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_RESQ.HasValue)
				request.WithQueryParameter("RESQ", m3_RESQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RPRN))
				request.WithQueryParameter("RPRN", m3_RPRN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSTS))
				request.WithQueryParameter("RSTS", m3_RSTS.Trim());
			if (m3_MMAM.HasValue)
				request.WithQueryParameter("MMAM", m3_MMAM.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

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
		/// Name AddServiceAlias
		/// Description Add Service Alias
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PRNO">Product</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_SALI">Alias number for service</param>
		/// <param name="m3_ALWT">Alias category</param>
		/// <param name="m3_E0PA">Partner</param>
		/// <param name="m3_MOTP">Model/site</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_VFDT">Valid from</param>
		/// <param name="m3_LVDT">Valid to</param>
		/// <param name="m3_REMK">Remark</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddServiceAlias(
			int? m3_CONO = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			string m3_SALI = null, 
			int? m3_ALWT = null, 
			string m3_E0PA = null, 
			string m3_MOTP = null, 
			string m3_ALWQ = null, 
			DateTime? m3_VFDT = null, 
			DateTime? m3_LVDT = null, 
			string m3_REMK = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddServiceAlias",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SALI))
				request.WithQueryParameter("SALI", m3_SALI.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_E0PA))
				request.WithQueryParameter("E0PA", m3_E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MOTP))
				request.WithQueryParameter("MOTP", m3_MOTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (m3_VFDT.HasValue)
				request.WithQueryParameter("VFDT", m3_VFDT.Value.ToM3String());
			if (m3_LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3_LVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_REMK))
				request.WithQueryParameter("REMK", m3_REMK.Trim());

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
		/// Name AddServiceH
		/// Description Add Service Quick entry (like panel H in MOS300)
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_STAT">Status (Required)</param>
		/// <param name="m3_RESP">Responsible (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_PLCD">Planning policy (Required)</param>
		/// <param name="m3_ORTY">Order type (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_TODT">To date</param>
		/// <param name="m3_TOFP">Process type</param>
		/// <param name="m3_SRGP">Service group</param>
		/// <param name="m3_ZSET">Service level</param>
		/// <param name="m3_SCHD">Scheduled maintenance service</param>
		/// <param name="m3_EVTY">Event type</param>
		/// <param name="m3_EVTS">Event sequence</param>
		/// <param name="m3_NSTP">Shutdown</param>
		/// <param name="m3_ACRF">User-defined accounting control object</param>
		/// <param name="m3_MES1">Meter 1</param>
		/// <param name="m3_REIN">Repeat interval</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_PITI">Run time</param>
		/// <param name="m3_PRNP">Planned number of workers - run time</param>
		/// <param name="m3_OPDS">Operation description</param>
		/// <param name="m3_AAFR">Alarm limit</param>
		/// <param name="m3_AATO">Alarm limit</param>
		/// <param name="m3_AATR">Trend limit</param>
		/// <param name="m3_MES0">Meter</param>
		/// <param name="m3_RUOM">Result unit of measure</param>
		/// <param name="m3_DOID">Document identity</param>
		/// <param name="m3_NUC1">Number of put-away cards</param>
		/// <param name="m3_NUC2">Number of material requisitions</param>
		/// <param name="m3_NUC3">Number of labor tickets</param>
		/// <param name="m3_NUC4">Number of shop travelers</param>
		/// <param name="m3_NUC5">Number of routing cards</param>
		/// <param name="m3_NUC6">Number of picking lists</param>
		/// <param name="m3_NUC7">Number of design documents</param>
		/// <param name="m3_TXL1">Text</param>
		/// <param name="m3_TXL2">Text</param>
		/// <param name="m3_TXL3">Text</param>
		/// <param name="m3_TXL4">Text</param>
		/// <param name="m3_TXL5">Text</param>
		/// <param name="m3_TXL6">Text</param>
		/// <param name="m3_TXL7">Text</param>
		/// <param name="m3_TXL8">Text</param>
		/// <param name="m3_TXL9">Text</param>
		/// <param name="m3_TXL0">Text</param>
		/// <param name="m3_PTSR">Service Category</param>
		/// <param name="m3_MOTP">Model/site</param>
		/// <param name="m3_EDWT">Estimated downtime</param>
		/// <param name="m3_SCHL">Scheduling logic</param>
		/// <param name="m3_PLMZ">Planning horizon</param>
		/// <param name="m3_ZSEC">Calculation method</param>
		/// <param name="m3_THIN">Threshold interval</param>
		/// <param name="m3_ADJU">Adjust code</param>
		/// <param name="m3_STYP">Service Type</param>
		/// <param name="m3_ACWA">Claim warranty</param>
		/// <param name="m3_EXCH">Exchange</param>
		/// <param name="m3_SPMT">Issue method</param>
		/// <param name="m3_ACNF">Automatic approval of service</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddServiceH(
			string m3_SUFI, 
			string m3_STAT, 
			string m3_RESP, 
			string m3_TX40, 
			string m3_FACI, 
			string m3_PLCD, 
			string m3_ORTY, 
			int? m3_CONO = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			DateTime? m3_STDT = null, 
			DateTime? m3_TODT = null, 
			string m3_TOFP = null, 
			string m3_SRGP = null, 
			int? m3_ZSET = null, 
			int? m3_SCHD = null, 
			string m3_EVTY = null, 
			int? m3_EVTS = null, 
			int? m3_NSTP = null, 
			string m3_ACRF = null, 
			string m3_MES1 = null, 
			decimal? m3_REIN = null, 
			string m3_PLGR = null, 
			int? m3_PITI = null, 
			int? m3_PRNP = null, 
			string m3_OPDS = null, 
			string m3_AAFR = null, 
			string m3_AATO = null, 
			string m3_AATR = null, 
			string m3_MES0 = null, 
			string m3_RUOM = null, 
			string m3_DOID = null, 
			int? m3_NUC1 = null, 
			int? m3_NUC2 = null, 
			int? m3_NUC3 = null, 
			int? m3_NUC4 = null, 
			int? m3_NUC5 = null, 
			int? m3_NUC6 = null, 
			int? m3_NUC7 = null, 
			string m3_TXL1 = null, 
			string m3_TXL2 = null, 
			string m3_TXL3 = null, 
			string m3_TXL4 = null, 
			string m3_TXL5 = null, 
			string m3_TXL6 = null, 
			string m3_TXL7 = null, 
			string m3_TXL8 = null, 
			string m3_TXL9 = null, 
			string m3_TXL0 = null, 
			string m3_PTSR = null, 
			string m3_MOTP = null, 
			int? m3_EDWT = null, 
			int? m3_SCHL = null, 
			int? m3_PLMZ = null, 
			int? m3_ZSEC = null, 
			decimal? m3_THIN = null, 
			int? m3_ADJU = null, 
			string m3_STYP = null, 
			int? m3_ACWA = null, 
			int? m3_EXCH = null, 
			int? m3_SPMT = null, 
			int? m3_ACNF = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddServiceH",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");
			if (string.IsNullOrWhiteSpace(m3_STAT))
				throw new ArgumentNullException("m3_STAT");
			if (string.IsNullOrWhiteSpace(m3_RESP))
				throw new ArgumentNullException("m3_RESP");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PLCD))
				throw new ArgumentNullException("m3_PLCD");
			if (string.IsNullOrWhiteSpace(m3_ORTY))
				throw new ArgumentNullException("m3_ORTY");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3_SUFI.Trim())
				.WithQueryParameter("STAT", m3_STAT.Trim())
				.WithQueryParameter("RESP", m3_RESP.Trim())
				.WithQueryParameter("TX40", m3_TX40.Trim())
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("PLCD", m3_PLCD.Trim())
				.WithQueryParameter("ORTY", m3_ORTY.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_TODT.HasValue)
				request.WithQueryParameter("TODT", m3_TODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_TOFP))
				request.WithQueryParameter("TOFP", m3_TOFP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SRGP))
				request.WithQueryParameter("SRGP", m3_SRGP.Trim());
			if (m3_ZSET.HasValue)
				request.WithQueryParameter("ZSET", m3_ZSET.Value.ToString());
			if (m3_SCHD.HasValue)
				request.WithQueryParameter("SCHD", m3_SCHD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EVTY))
				request.WithQueryParameter("EVTY", m3_EVTY.Trim());
			if (m3_EVTS.HasValue)
				request.WithQueryParameter("EVTS", m3_EVTS.Value.ToString());
			if (m3_NSTP.HasValue)
				request.WithQueryParameter("NSTP", m3_NSTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MES1))
				request.WithQueryParameter("MES1", m3_MES1.Trim());
			if (m3_REIN.HasValue)
				request.WithQueryParameter("REIN", m3_REIN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (m3_PITI.HasValue)
				request.WithQueryParameter("PITI", m3_PITI.Value.ToString());
			if (m3_PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3_PRNP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OPDS))
				request.WithQueryParameter("OPDS", m3_OPDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AAFR))
				request.WithQueryParameter("AAFR", m3_AAFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AATO))
				request.WithQueryParameter("AATO", m3_AATO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AATR))
				request.WithQueryParameter("AATR", m3_AATR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MES0))
				request.WithQueryParameter("MES0", m3_MES0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RUOM))
				request.WithQueryParameter("RUOM", m3_RUOM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOID))
				request.WithQueryParameter("DOID", m3_DOID.Trim());
			if (m3_NUC1.HasValue)
				request.WithQueryParameter("NUC1", m3_NUC1.Value.ToString());
			if (m3_NUC2.HasValue)
				request.WithQueryParameter("NUC2", m3_NUC2.Value.ToString());
			if (m3_NUC3.HasValue)
				request.WithQueryParameter("NUC3", m3_NUC3.Value.ToString());
			if (m3_NUC4.HasValue)
				request.WithQueryParameter("NUC4", m3_NUC4.Value.ToString());
			if (m3_NUC5.HasValue)
				request.WithQueryParameter("NUC5", m3_NUC5.Value.ToString());
			if (m3_NUC6.HasValue)
				request.WithQueryParameter("NUC6", m3_NUC6.Value.ToString());
			if (m3_NUC7.HasValue)
				request.WithQueryParameter("NUC7", m3_NUC7.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TXL1))
				request.WithQueryParameter("TXL1", m3_TXL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL2))
				request.WithQueryParameter("TXL2", m3_TXL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL3))
				request.WithQueryParameter("TXL3", m3_TXL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL4))
				request.WithQueryParameter("TXL4", m3_TXL4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL5))
				request.WithQueryParameter("TXL5", m3_TXL5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL6))
				request.WithQueryParameter("TXL6", m3_TXL6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL7))
				request.WithQueryParameter("TXL7", m3_TXL7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL8))
				request.WithQueryParameter("TXL8", m3_TXL8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL9))
				request.WithQueryParameter("TXL9", m3_TXL9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL0))
				request.WithQueryParameter("TXL0", m3_TXL0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PTSR))
				request.WithQueryParameter("PTSR", m3_PTSR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MOTP))
				request.WithQueryParameter("MOTP", m3_MOTP.Trim());
			if (m3_EDWT.HasValue)
				request.WithQueryParameter("EDWT", m3_EDWT.Value.ToString());
			if (m3_SCHL.HasValue)
				request.WithQueryParameter("SCHL", m3_SCHL.Value.ToString());
			if (m3_PLMZ.HasValue)
				request.WithQueryParameter("PLMZ", m3_PLMZ.Value.ToString());
			if (m3_ZSEC.HasValue)
				request.WithQueryParameter("ZSEC", m3_ZSEC.Value.ToString());
			if (m3_THIN.HasValue)
				request.WithQueryParameter("THIN", m3_THIN.Value.ToString());
			if (m3_ADJU.HasValue)
				request.WithQueryParameter("ADJU", m3_ADJU.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STYP))
				request.WithQueryParameter("STYP", m3_STYP.Trim());
			if (m3_ACWA.HasValue)
				request.WithQueryParameter("ACWA", m3_ACWA.Value.ToString());
			if (m3_EXCH.HasValue)
				request.WithQueryParameter("EXCH", m3_EXCH.Value.ToString());
			if (m3_SPMT.HasValue)
				request.WithQueryParameter("SPMT", m3_SPMT.Value.ToString());
			if (m3_ACNF.HasValue)
				request.WithQueryParameter("ACNF", m3_ACNF.Value.ToString());

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
		/// Name AddSpecReq
		/// Description Add Specific Requirement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_SPRQ">Specific requirement category (Required)</param>
		/// <param name="m3_SPRT">Specific requirements (Required)</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSpecReq(
			string m3_SUFI, 
			string m3_SPRQ, 
			string m3_SPRT, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			string m3_TX40 = null, 
			decimal? m3_TXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddSpecReq",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");
			if (string.IsNullOrWhiteSpace(m3_SPRQ))
				throw new ArgumentNullException("m3_SPRQ");
			if (string.IsNullOrWhiteSpace(m3_SPRT))
				throw new ArgumentNullException("m3_SPRT");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3_SUFI.Trim())
				.WithQueryParameter("SPRQ", m3_SPRQ.Trim())
				.WithQueryParameter("SPRT", m3_SPRT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

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
		/// Name AddSrvEff
		/// Description Add Service Effectivity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_TBAN">Lot number</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSrvEff(
			string m3_PRNO = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_TBAN = null, 
			decimal? m3_TXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddSrvEff",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TBAN))
				request.WithQueryParameter("TBAN", m3_TBAN.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

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
		/// Name ChgMaintLim
		/// Description Change Maintenance Limit
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_MES0">Meter (Required)</param>
		/// <param name="m3_MPGM">Maintenance program</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_ECVE">Revision number</param>
		/// <param name="m3_MVER">Version number</param>
		/// <param name="m3_THIN">Threshold interval</param>
		/// <param name="m3_REIN">Repeat interval</param>
		/// <param name="m3_INTL">Operational tolerance</param>
		/// <param name="m3_ETO1">Economical tolerance 1</param>
		/// <param name="m3_ETO2">Economical tolerance 2</param>
		/// <param name="m3_SAMP">Sampling percentage</param>
		/// <param name="m3_SIMC">Simulation</param>
		/// <param name="m3_WMLI">Inventory maintenance</param>
		/// <param name="m3_MLIM">Lifetime maintenance limit</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgMaintLim(
			string m3_PRNO, 
			string m3_SUFI, 
			string m3_MES0, 
			string m3_MPGM = null, 
			string m3_STRT = null, 
			string m3_ECVE = null, 
			int? m3_MVER = null, 
			decimal? m3_THIN = null, 
			decimal? m3_REIN = null, 
			decimal? m3_INTL = null, 
			decimal? m3_ETO1 = null, 
			decimal? m3_ETO2 = null, 
			int? m3_SAMP = null, 
			int? m3_SIMC = null, 
			int? m3_WMLI = null, 
			int? m3_MLIM = null, 
			decimal? m3_TXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgMaintLim",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");
			if (string.IsNullOrWhiteSpace(m3_MES0))
				throw new ArgumentNullException("m3_MES0");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("SUFI", m3_SUFI.Trim())
				.WithQueryParameter("MES0", m3_MES0.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MPGM))
				request.WithQueryParameter("MPGM", m3_MPGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECVE))
				request.WithQueryParameter("ECVE", m3_ECVE.Trim());
			if (m3_MVER.HasValue)
				request.WithQueryParameter("MVER", m3_MVER.Value.ToString());
			if (m3_THIN.HasValue)
				request.WithQueryParameter("THIN", m3_THIN.Value.ToString());
			if (m3_REIN.HasValue)
				request.WithQueryParameter("REIN", m3_REIN.Value.ToString());
			if (m3_INTL.HasValue)
				request.WithQueryParameter("INTL", m3_INTL.Value.ToString());
			if (m3_ETO1.HasValue)
				request.WithQueryParameter("ETO1", m3_ETO1.Value.ToString());
			if (m3_ETO2.HasValue)
				request.WithQueryParameter("ETO2", m3_ETO2.Value.ToString());
			if (m3_SAMP.HasValue)
				request.WithQueryParameter("SAMP", m3_SAMP.Value.ToString());
			if (m3_SIMC.HasValue)
				request.WithQueryParameter("SIMC", m3_SIMC.Value.ToString());
			if (m3_WMLI.HasValue)
				request.WithQueryParameter("WMLI", m3_WMLI.Value.ToString());
			if (m3_MLIM.HasValue)
				request.WithQueryParameter("MLIM", m3_MLIM.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

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
		/// Name ChgOp
		/// Description Change Operation for a service
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_PLGR">Work center (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_PITI">Run time</param>
		/// <param name="m3_PRNP">Planned number of workers - run time</param>
		/// <param name="m3_OPDS">Operation description</param>
		/// <param name="m3_DOID">Document identity</param>
		/// <param name="m3_TXL1">Text</param>
		/// <param name="m3_TXL2">Text</param>
		/// <param name="m3_TDAT">To date</param>
		/// <param name="m3_SETI">Setup time</param>
		/// <param name="m3_SENP">Planned number of workers - setup</param>
		/// <param name="m3_RUNO">OEM hours</param>
		/// <param name="m3_RUNP">Price hours</param>
		/// <param name="m3_RUNT">Target hours</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgOp(
			string m3_FACI, 
			int m3_OPNO, 
			string m3_PLGR, 
			int? m3_CONO = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			int? m3_PITI = null, 
			int? m3_PRNP = null, 
			string m3_OPDS = null, 
			string m3_DOID = null, 
			string m3_TXL1 = null, 
			string m3_TXL2 = null, 
			DateTime? m3_TDAT = null, 
			int? m3_SETI = null, 
			int? m3_SENP = null, 
			int? m3_RUNO = null, 
			int? m3_RUNP = null, 
			int? m3_RUNT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgOp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_PLGR))
				throw new ArgumentNullException("m3_PLGR");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString())
				.WithQueryParameter("PLGR", m3_PLGR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_PITI.HasValue)
				request.WithQueryParameter("PITI", m3_PITI.Value.ToString());
			if (m3_PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3_PRNP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OPDS))
				request.WithQueryParameter("OPDS", m3_OPDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOID))
				request.WithQueryParameter("DOID", m3_DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL1))
				request.WithQueryParameter("TXL1", m3_TXL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL2))
				request.WithQueryParameter("TXL2", m3_TXL2.Trim());
			if (m3_TDAT.HasValue)
				request.WithQueryParameter("TDAT", m3_TDAT.Value.ToM3String());
			if (m3_SETI.HasValue)
				request.WithQueryParameter("SETI", m3_SETI.Value.ToString());
			if (m3_SENP.HasValue)
				request.WithQueryParameter("SENP", m3_SENP.Value.ToString());
			if (m3_RUNO.HasValue)
				request.WithQueryParameter("RUNO", m3_RUNO.Value.ToString());
			if (m3_RUNP.HasValue)
				request.WithQueryParameter("RUNP", m3_RUNP.Value.ToString());
			if (m3_RUNT.HasValue)
				request.WithQueryParameter("RUNT", m3_RUNT.Value.ToString());

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
		/// Name ChgOp2
		/// Description Change OEM Code of Operation for a service
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SMC0">User defined field 1</param>
		/// <param name="m3_SMC1">User defined field 2</param>
		/// <param name="m3_SMC2">User defined field 3</param>
		/// <param name="m3_SMC3">User defined field 4</param>
		/// <param name="m3_SMC4">User defined field 5</param>
		/// <param name="m3_SMC5">User defined field 6</param>
		/// <param name="m3_SMC6">User defined field 7</param>
		/// <param name="m3_SMC7">User defined field 8</param>
		/// <param name="m3_SMC8">User defined field 9</param>
		/// <param name="m3_SMC9">User defined field 10</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgOp2(
			string m3_FACI, 
			string m3_SUFI, 
			int m3_OPNO, 
			int? m3_CONO = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			string m3_SMC0 = null, 
			string m3_SMC1 = null, 
			string m3_SMC2 = null, 
			string m3_SMC3 = null, 
			string m3_SMC4 = null, 
			string m3_SMC5 = null, 
			string m3_SMC6 = null, 
			string m3_SMC7 = null, 
			string m3_SMC8 = null, 
			string m3_SMC9 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgOp2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("SUFI", m3_SUFI.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC0))
				request.WithQueryParameter("SMC0", m3_SMC0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC1))
				request.WithQueryParameter("SMC1", m3_SMC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC2))
				request.WithQueryParameter("SMC2", m3_SMC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC3))
				request.WithQueryParameter("SMC3", m3_SMC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC4))
				request.WithQueryParameter("SMC4", m3_SMC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC5))
				request.WithQueryParameter("SMC5", m3_SMC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC6))
				request.WithQueryParameter("SMC6", m3_SMC6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC7))
				request.WithQueryParameter("SMC7", m3_SMC7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC8))
				request.WithQueryParameter("SMC8", m3_SMC8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC9))
				request.WithQueryParameter("SMC9", m3_SMC9.Trim());

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
		/// Name ChgOpElement
		/// Description Change Operation Element
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_ACTS">Task element number (Required)</param>
		/// <param name="m3_ACTT">Operation element type (Required)</param>
		/// <param name="m3_ACTR">Work element (Required)</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_CATY">Capability type</param>
		/// <param name="m3_TOOL">Tool number</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_DOID">Document identity</param>
		/// <param name="m3_INSI">Inspection identity</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_ACDS">Description</param>
		/// <param name="m3_TXT1">Text line 1</param>
		/// <param name="m3_TXT2">Text line 2</param>
		/// <param name="m3_SETI">Setup time</param>
		/// <param name="m3_PITI">Run time</param>
		/// <param name="m3_SENP">Planned number of workers - setup</param>
		/// <param name="m3_PRNP">Planned number of workers - run time</param>
		/// <param name="m3_LASK">Labor skill</param>
		/// <param name="m3_INSK">Inspection skill</param>
		/// <param name="m3_MVA1">Meter value 1</param>
		/// <param name="m3_MVA2">Meter value 2</param>
		/// <param name="m3_MVA3">Meter value 3</param>
		/// <param name="m3_MVA4">Meter value 4</param>
		/// <param name="m3_PEQ1">Quantity or time</param>
		/// <param name="m3_PEQ2">Quantity or time</param>
		/// <param name="m3_PEQ3">Quantity or time</param>
		/// <param name="m3_PEQ4">Quantity or time</param>
		/// <param name="m3_PET1">Trigger type</param>
		/// <param name="m3_PET2">Trigger type</param>
		/// <param name="m3_PET3">Trigger type</param>
		/// <param name="m3_PET4">Trigger type</param>
		/// <param name="m3_PERM">Permit</param>
		/// <param name="m3_CLEV">Capability level</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_TRQT">Transaction quantity - basic U/M</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgOpElement(
			string m3_FACI, 
			int m3_OPNO, 
			int m3_ACTS, 
			string m3_ACTT, 
			string m3_ACTR, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			DateTime? m3_FDAT = null, 
			string m3_CATY = null, 
			string m3_TOOL = null, 
			string m3_SERN = null, 
			string m3_DOID = null, 
			string m3_INSI = null, 
			string m3_SUFI = null, 
			string m3_ACDS = null, 
			string m3_TXT1 = null, 
			string m3_TXT2 = null, 
			int? m3_SETI = null, 
			int? m3_PITI = null, 
			int? m3_SENP = null, 
			int? m3_PRNP = null, 
			string m3_LASK = null, 
			string m3_INSK = null, 
			decimal? m3_MVA1 = null, 
			decimal? m3_MVA2 = null, 
			decimal? m3_MVA3 = null, 
			decimal? m3_MVA4 = null, 
			int? m3_PEQ1 = null, 
			int? m3_PEQ2 = null, 
			int? m3_PEQ3 = null, 
			int? m3_PEQ4 = null, 
			int? m3_PET1 = null, 
			int? m3_PET2 = null, 
			int? m3_PET3 = null, 
			int? m3_PET4 = null, 
			string m3_PERM = null, 
			int? m3_CLEV = null, 
			decimal? m3_TXID = null, 
			decimal? m3_TRQT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgOpElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_ACTT))
				throw new ArgumentNullException("m3_ACTT");
			if (string.IsNullOrWhiteSpace(m3_ACTR))
				throw new ArgumentNullException("m3_ACTR");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString())
				.WithQueryParameter("ACTS", m3_ACTS.ToString())
				.WithQueryParameter("ACTT", m3_ACTT.Trim())
				.WithQueryParameter("ACTR", m3_ACTR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CATY))
				request.WithQueryParameter("CATY", m3_CATY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOOL))
				request.WithQueryParameter("TOOL", m3_TOOL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOID))
				request.WithQueryParameter("DOID", m3_DOID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INSI))
				request.WithQueryParameter("INSI", m3_INSI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACDS))
				request.WithQueryParameter("ACDS", m3_ACDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXT1))
				request.WithQueryParameter("TXT1", m3_TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXT2))
				request.WithQueryParameter("TXT2", m3_TXT2.Trim());
			if (m3_SETI.HasValue)
				request.WithQueryParameter("SETI", m3_SETI.Value.ToString());
			if (m3_PITI.HasValue)
				request.WithQueryParameter("PITI", m3_PITI.Value.ToString());
			if (m3_SENP.HasValue)
				request.WithQueryParameter("SENP", m3_SENP.Value.ToString());
			if (m3_PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3_PRNP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LASK))
				request.WithQueryParameter("LASK", m3_LASK.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INSK))
				request.WithQueryParameter("INSK", m3_INSK.Trim());
			if (m3_MVA1.HasValue)
				request.WithQueryParameter("MVA1", m3_MVA1.Value.ToString());
			if (m3_MVA2.HasValue)
				request.WithQueryParameter("MVA2", m3_MVA2.Value.ToString());
			if (m3_MVA3.HasValue)
				request.WithQueryParameter("MVA3", m3_MVA3.Value.ToString());
			if (m3_MVA4.HasValue)
				request.WithQueryParameter("MVA4", m3_MVA4.Value.ToString());
			if (m3_PEQ1.HasValue)
				request.WithQueryParameter("PEQ1", m3_PEQ1.Value.ToString());
			if (m3_PEQ2.HasValue)
				request.WithQueryParameter("PEQ2", m3_PEQ2.Value.ToString());
			if (m3_PEQ3.HasValue)
				request.WithQueryParameter("PEQ3", m3_PEQ3.Value.ToString());
			if (m3_PEQ4.HasValue)
				request.WithQueryParameter("PEQ4", m3_PEQ4.Value.ToString());
			if (m3_PET1.HasValue)
				request.WithQueryParameter("PET1", m3_PET1.Value.ToString());
			if (m3_PET2.HasValue)
				request.WithQueryParameter("PET2", m3_PET2.Value.ToString());
			if (m3_PET3.HasValue)
				request.WithQueryParameter("PET3", m3_PET3.Value.ToString());
			if (m3_PET4.HasValue)
				request.WithQueryParameter("PET4", m3_PET4.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PERM))
				request.WithQueryParameter("PERM", m3_PERM.Trim());
			if (m3_CLEV.HasValue)
				request.WithQueryParameter("CLEV", m3_CLEV.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (m3_TRQT.HasValue)
				request.WithQueryParameter("TRQT", m3_TRQT.Value.ToString());

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
		/// Name ChgRelSrv
		/// Description Change Related Service
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_RSUF">Service (Required)</param>
		/// <param name="m3_MPGM">Maintenance program</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_RESQ">Sequence number</param>
		/// <param name="m3_RPRN">Product number</param>
		/// <param name="m3_RSTS">Product structure type</param>
		/// <param name="m3_MREL">Maintenance relation</param>
		/// <param name="m3_MMAM">Mandatory relationship</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgRelSrv(
			string m3_SUFI, 
			string m3_RSUF, 
			string m3_MPGM = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			int? m3_RESQ = null, 
			string m3_RPRN = null, 
			string m3_RSTS = null, 
			string m3_MREL = null, 
			int? m3_MMAM = null, 
			decimal? m3_TXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgRelSrv",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");
			if (string.IsNullOrWhiteSpace(m3_RSUF))
				throw new ArgumentNullException("m3_RSUF");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3_SUFI.Trim())
				.WithQueryParameter("RSUF", m3_RSUF.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MPGM))
				request.WithQueryParameter("MPGM", m3_MPGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_RESQ.HasValue)
				request.WithQueryParameter("RESQ", m3_RESQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RPRN))
				request.WithQueryParameter("RPRN", m3_RPRN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSTS))
				request.WithQueryParameter("RSTS", m3_RSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MREL))
				request.WithQueryParameter("MREL", m3_MREL.Trim());
			if (m3_MMAM.HasValue)
				request.WithQueryParameter("MMAM", m3_MMAM.Value.ToString());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

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
		/// Name ChgSpecReq
		/// Description Change Specific Requirement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_SPRQ">Specific requirement category (Required)</param>
		/// <param name="m3_SPRT">Specific requirements (Required)</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgSpecReq(
			string m3_SUFI, 
			string m3_SPRQ, 
			string m3_SPRT, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			string m3_TX40 = null, 
			decimal? m3_TXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgSpecReq",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");
			if (string.IsNullOrWhiteSpace(m3_SPRQ))
				throw new ArgumentNullException("m3_SPRQ");
			if (string.IsNullOrWhiteSpace(m3_SPRT))
				throw new ArgumentNullException("m3_SPRT");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3_SUFI.Trim())
				.WithQueryParameter("SPRQ", m3_SPRQ.Trim())
				.WithQueryParameter("SPRT", m3_SPRT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

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
		/// Name ChgSrvEff
		/// Description Change Service Effectivity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_TBAN">Lot number</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgSrvEff(
			string m3_PRNO = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_TBAN = null, 
			decimal? m3_TXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgSrvEff",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TBAN))
				request.WithQueryParameter("TBAN", m3_TBAN.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());

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
		/// Name ConnectMtrl
		/// Description Connect existing matrl to a service
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_MSEQ">Sequence number (Required)</param>
		/// <param name="m3_MTPL">Component number/work center (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ConnectMtrl(
			string m3_FACI, 
			string m3_SUFI, 
			int m3_MSEQ, 
			string m3_MTPL, 
			int m3_OPNO, 
			int? m3_CONO = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			DateTime? m3_FDAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ConnectMtrl",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");
			if (string.IsNullOrWhiteSpace(m3_MTPL))
				throw new ArgumentNullException("m3_MTPL");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("SUFI", m3_SUFI.Trim())
				.WithQueryParameter("MSEQ", m3_MSEQ.ToString())
				.WithQueryParameter("MTPL", m3_MTPL.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());

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
		/// Name ConnectOper
		/// Description Connect existing operation to a service
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ConnectOper(
			string m3_FACI, 
			string m3_SUFI, 
			int m3_OPNO, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			DateTime? m3_FDAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ConnectOper",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("SUFI", m3_SUFI.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());

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
		/// Name DelMaintLim
		/// Description Delete Maintenance Limit
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_MES0">Meter (Required)</param>
		/// <param name="m3_THIN">Threshold interval (Required)</param>
		/// <param name="m3_MPGM">Maintenance program</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_ECVE">Revision number</param>
		/// <param name="m3_MVER">Version number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelMaintLim(
			string m3_SUFI, 
			string m3_MES0, 
			decimal m3_THIN, 
			string m3_MPGM = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			string m3_ECVE = null, 
			int? m3_MVER = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelMaintLim",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");
			if (string.IsNullOrWhiteSpace(m3_MES0))
				throw new ArgumentNullException("m3_MES0");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3_SUFI.Trim())
				.WithQueryParameter("MES0", m3_MES0.Trim())
				.WithQueryParameter("THIN", m3_THIN.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MPGM))
				request.WithQueryParameter("MPGM", m3_MPGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECVE))
				request.WithQueryParameter("ECVE", m3_ECVE.Trim());
			if (m3_MVER.HasValue)
				request.WithQueryParameter("MVER", m3_MVER.Value.ToString());

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
		/// Name DelOp
		/// Description Delete Operation from a service
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelOp(
			string m3_FACI, 
			string m3_SUFI, 
			int m3_OPNO, 
			int? m3_CONO = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelOp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("SUFI", m3_SUFI.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());

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
		/// Name DelOpElement
		/// Description DeleteOperation Element
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_ACTS">Task element number (Required)</param>
		/// <param name="m3_ACTT">Operation element type (Required)</param>
		/// <param name="m3_ACTR">Work element (Required)</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_CATY">Capability type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelOpElement(
			string m3_FACI, 
			int m3_OPNO, 
			int m3_ACTS, 
			string m3_ACTT, 
			string m3_ACTR, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			DateTime? m3_FDAT = null, 
			string m3_CATY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelOpElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_ACTT))
				throw new ArgumentNullException("m3_ACTT");
			if (string.IsNullOrWhiteSpace(m3_ACTR))
				throw new ArgumentNullException("m3_ACTR");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString())
				.WithQueryParameter("ACTS", m3_ACTS.ToString())
				.WithQueryParameter("ACTT", m3_ACTT.Trim())
				.WithQueryParameter("ACTR", m3_ACTR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CATY))
				request.WithQueryParameter("CATY", m3_CATY.Trim());

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
		/// Name DelOpnoMtrl
		/// Description Delete all operation and material for a service
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<DelOpnoMtrlResponse></returns>
		/// <exception cref="M3Exception<DelOpnoMtrlResponse>"></exception>
		public async Task<M3Response<DelOpnoMtrlResponse>> DelOpnoMtrl(
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelOpnoMtrl",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());

			// Execute the request
			var result = await Execute<DelOpnoMtrlResponse>(
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
		/// Name DelRelSrv
		/// Description Delete Related Service
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MPGM">Maintenance program</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_RESQ">Sequence number</param>
		/// <param name="m3_RPRN">Product number</param>
		/// <param name="m3_RSTS">Product structure type</param>
		/// <param name="m3_RSUF">Service</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<DelRelSrvResponse></returns>
		/// <exception cref="M3Exception<DelRelSrvResponse>"></exception>
		public async Task<M3Response<DelRelSrvResponse>> DelRelSrv(
			string m3_MPGM = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			int? m3_RESQ = null, 
			string m3_RPRN = null, 
			string m3_RSTS = null, 
			string m3_RSUF = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelRelSrv",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MPGM))
				request.WithQueryParameter("MPGM", m3_MPGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (m3_RESQ.HasValue)
				request.WithQueryParameter("RESQ", m3_RESQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RPRN))
				request.WithQueryParameter("RPRN", m3_RPRN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSTS))
				request.WithQueryParameter("RSTS", m3_RSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSUF))
				request.WithQueryParameter("RSUF", m3_RSUF.Trim());

			// Execute the request
			var result = await Execute<DelRelSrvResponse>(
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
		/// Name DelSpecReq
		/// Description Delete Specific Requirement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_SPRQ">Specific requirement category (Required)</param>
		/// <param name="m3_SPRT">Specific requirements (Required)</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelSpecReq(
			string m3_SUFI, 
			string m3_SPRQ, 
			string m3_SPRT, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelSpecReq",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");
			if (string.IsNullOrWhiteSpace(m3_SPRQ))
				throw new ArgumentNullException("m3_SPRQ");
			if (string.IsNullOrWhiteSpace(m3_SPRT))
				throw new ArgumentNullException("m3_SPRT");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3_SUFI.Trim())
				.WithQueryParameter("SPRQ", m3_SPRQ.Trim())
				.WithQueryParameter("SPRT", m3_SPRT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());

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
		/// Name DelSrvEff
		/// Description Delete Service Effectivity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelSrvEff(
			string m3_PRNO = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelSrvEff",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());

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
		/// Name DisconnectMtrl
		/// Description Disconnect existing matrl from a service
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_MSEQ">Sequence number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DisconnectMtrl(
			string m3_FACI, 
			string m3_SUFI, 
			int m3_MSEQ, 
			int? m3_CONO = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DisconnectMtrl",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("SUFI", m3_SUFI.Trim())
				.WithQueryParameter("MSEQ", m3_MSEQ.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());

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
		/// Name DisconnectOper
		/// Description Disconnect existing oper from a service
		/// Version Release: 5ea4
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DisconnectOper(
			string m3_FACI, 
			string m3_SUFI, 
			int m3_OPNO, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			DateTime? m3_FDAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DisconnectOper",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("SUFI", m3_SUFI.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());

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
		/// Name GetBasic
		/// Description Get basic data for service
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBasicResponse></returns>
		/// <exception cref="M3Exception<GetBasicResponse>"></exception>
		public async Task<M3Response<GetBasicResponse>> GetBasic(
			string m3_SUFI, 
			int? m3_CONO = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBasic",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3_SUFI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());

			// Execute the request
			var result = await Execute<GetBasicResponse>(
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
		/// Name GetMaintLim
		/// Description Get Maintenance Limit
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_MPGM">Maintenance program</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_ECVE">Revision number</param>
		/// <param name="m3_MVER">Version number</param>
		/// <param name="m3_MES0">Meter</param>
		/// <param name="m3_THIN">Threshold interval</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMaintLimResponse></returns>
		/// <exception cref="M3Exception<GetMaintLimResponse>"></exception>
		public async Task<M3Response<GetMaintLimResponse>> GetMaintLim(
			string m3_PRNO, 
			string m3_SUFI, 
			string m3_MPGM = null, 
			string m3_STRT = null, 
			string m3_ECVE = null, 
			int? m3_MVER = null, 
			string m3_MES0 = null, 
			decimal? m3_THIN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetMaintLim",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("SUFI", m3_SUFI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MPGM))
				request.WithQueryParameter("MPGM", m3_MPGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECVE))
				request.WithQueryParameter("ECVE", m3_ECVE.Trim());
			if (m3_MVER.HasValue)
				request.WithQueryParameter("MVER", m3_MVER.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MES0))
				request.WithQueryParameter("MES0", m3_MES0.Trim());
			if (m3_THIN.HasValue)
				request.WithQueryParameter("THIN", m3_THIN.Value.ToString());

			// Execute the request
			var result = await Execute<GetMaintLimResponse>(
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
		/// Name GetMtrl
		/// Description Get Material for a service
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_MSEQ">Sequence number (Required)</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMtrlResponse></returns>
		/// <exception cref="M3Exception<GetMtrlResponse>"></exception>
		public async Task<M3Response<GetMtrlResponse>> GetMtrl(
			string m3_FACI, 
			int m3_MSEQ, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			DateTime? m3_FDAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetMtrl",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("MSEQ", m3_MSEQ.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());

			// Execute the request
			var result = await Execute<GetMtrlResponse>(
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
		/// Name GetOp
		/// Description Get Operation for
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOpResponse></returns>
		/// <exception cref="M3Exception<GetOpResponse>"></exception>
		public async Task<M3Response<GetOpResponse>> GetOp(
			string m3_FACI, 
			int m3_OPNO, 
			int? m3_CONO = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetOp",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());

			// Execute the request
			var result = await Execute<GetOpResponse>(
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
		/// Name GetOp2
		/// Description Get OEM Code of Operation for a service
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOp2Response></returns>
		/// <exception cref="M3Exception<GetOp2Response>"></exception>
		public async Task<M3Response<GetOp2Response>> GetOp2(
			string m3_FACI, 
			string m3_SUFI, 
			int m3_OPNO, 
			int? m3_CONO = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetOp2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("SUFI", m3_SUFI.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());

			// Execute the request
			var result = await Execute<GetOp2Response>(
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
		/// Name GetOpElement
		/// Description GetOperation Element
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_ACTS">Task element number (Required)</param>
		/// <param name="m3_ACTT">Operation element type (Required)</param>
		/// <param name="m3_ACTR">Work element (Required)</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="m3_CATY">Capability type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetOpElementResponse></returns>
		/// <exception cref="M3Exception<GetOpElementResponse>"></exception>
		public async Task<M3Response<GetOpElementResponse>> GetOpElement(
			string m3_FACI, 
			int m3_OPNO, 
			int m3_ACTS, 
			string m3_ACTT, 
			string m3_ACTR, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			DateTime? m3_FDAT = null, 
			string m3_CATY = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetOpElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_ACTT))
				throw new ArgumentNullException("m3_ACTT");
			if (string.IsNullOrWhiteSpace(m3_ACTR))
				throw new ArgumentNullException("m3_ACTR");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString())
				.WithQueryParameter("ACTS", m3_ACTS.ToString())
				.WithQueryParameter("ACTT", m3_ACTT.Trim())
				.WithQueryParameter("ACTR", m3_ACTR.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CATY))
				request.WithQueryParameter("CATY", m3_CATY.Trim());

			// Execute the request
			var result = await Execute<GetOpElementResponse>(
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
		/// Name GetRelSrv
		/// Description Get Related Service
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_MPGM">Maintenance program</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_RESQ">Sequence number</param>
		/// <param name="m3_RPRN">Product number</param>
		/// <param name="m3_RSTS">Product structure type</param>
		/// <param name="m3_RSUF">Service</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetRelSrvResponse></returns>
		/// <exception cref="M3Exception<GetRelSrvResponse>"></exception>
		public async Task<M3Response<GetRelSrvResponse>> GetRelSrv(
			string m3_SUFI, 
			string m3_MPGM = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			int? m3_RESQ = null, 
			string m3_RPRN = null, 
			string m3_RSTS = null, 
			string m3_RSUF = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetRelSrv",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3_SUFI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MPGM))
				request.WithQueryParameter("MPGM", m3_MPGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_RESQ.HasValue)
				request.WithQueryParameter("RESQ", m3_RESQ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RPRN))
				request.WithQueryParameter("RPRN", m3_RPRN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSTS))
				request.WithQueryParameter("RSTS", m3_RSTS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSUF))
				request.WithQueryParameter("RSUF", m3_RSUF.Trim());

			// Execute the request
			var result = await Execute<GetRelSrvResponse>(
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
		/// Name GetServiceFaci
		/// Description Get basic data for service/faciilty
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetServiceFaciResponse></returns>
		/// <exception cref="M3Exception<GetServiceFaciResponse>"></exception>
		public async Task<M3Response<GetServiceFaciResponse>> GetServiceFaci(
			string m3_SUFI, 
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetServiceFaci",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3_SUFI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());

			// Execute the request
			var result = await Execute<GetServiceFaciResponse>(
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
		/// Name GetSpecReq
		/// Description Get Specific Requirement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_SPRQ">Specific requirement category (Required)</param>
		/// <param name="m3_SPRT">Specific requirements (Required)</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSpecReqResponse></returns>
		/// <exception cref="M3Exception<GetSpecReqResponse>"></exception>
		public async Task<M3Response<GetSpecReqResponse>> GetSpecReq(
			string m3_SUFI, 
			string m3_SPRQ, 
			string m3_SPRT, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetSpecReq",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");
			if (string.IsNullOrWhiteSpace(m3_SPRQ))
				throw new ArgumentNullException("m3_SPRQ");
			if (string.IsNullOrWhiteSpace(m3_SPRT))
				throw new ArgumentNullException("m3_SPRT");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3_SUFI.Trim())
				.WithQueryParameter("SPRQ", m3_SPRQ.Trim())
				.WithQueryParameter("SPRT", m3_SPRT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());

			// Execute the request
			var result = await Execute<GetSpecReqResponse>(
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
		/// Name GetSrvEff
		/// Description Get Service Effectivity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_OPNO">Operation number</param>
		/// <param name="m3_MSEQ">Sequence number</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSrvEffResponse></returns>
		/// <exception cref="M3Exception<GetSrvEffResponse>"></exception>
		public async Task<M3Response<GetSrvEffResponse>> GetSrvEff(
			string m3_PRNO = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			int? m3_OPNO = null, 
			int? m3_MSEQ = null, 
			DateTime? m3_FDAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetSrvEff",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (m3_OPNO.HasValue)
				request.WithQueryParameter("OPNO", m3_OPNO.Value.ToString());
			if (m3_MSEQ.HasValue)
				request.WithQueryParameter("MSEQ", m3_MSEQ.Value.ToString());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());

			// Execute the request
			var result = await Execute<GetSrvEffResponse>(
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
		/// Name LstByProduct
		/// Description List by service
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRNO">Product/item (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstByProductResponse></returns>
		/// <exception cref="M3Exception<LstByProductResponse>"></exception>
		public async Task<M3Response<LstByProductResponse>> LstByProduct(
			string m3_PRNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstByProduct",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRNO", m3_PRNO.Trim());

			// Execute the request
			var result = await Execute<LstByProductResponse>(
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
		/// Name LstMaintLim
		/// Description List Maintenance Limit
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRNO">Product number (Required)</param>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_MPGM">Maintenance program</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_ECVE">Revision number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMaintLimResponse></returns>
		/// <exception cref="M3Exception<LstMaintLimResponse>"></exception>
		public async Task<M3Response<LstMaintLimResponse>> LstMaintLim(
			string m3_PRNO, 
			string m3_SUFI, 
			string m3_MPGM = null, 
			string m3_STRT = null, 
			string m3_ECVE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstMaintLim",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRNO))
				throw new ArgumentNullException("m3_PRNO");
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRNO", m3_PRNO.Trim())
				.WithQueryParameter("SUFI", m3_SUFI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MPGM))
				request.WithQueryParameter("MPGM", m3_MPGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECVE))
				request.WithQueryParameter("ECVE", m3_ECVE.Trim());

			// Execute the request
			var result = await Execute<LstMaintLimResponse>(
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
		/// Name LstOpElement
		/// Description List Operation Element
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_OPNO">Operation number (Required)</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_FDAT">From date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstOpElementResponse></returns>
		/// <exception cref="M3Exception<LstOpElementResponse>"></exception>
		public async Task<M3Response<LstOpElementResponse>> LstOpElement(
			string m3_FACI, 
			int m3_OPNO, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			DateTime? m3_FDAT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstOpElement",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("OPNO", m3_OPNO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (m3_FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3_FDAT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstOpElementResponse>(
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
		/// Name LstOpnoMtrl
		/// Description List all operation and material for a service
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SUFI">Service</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstOpnoMtrlResponse></returns>
		/// <exception cref="M3Exception<LstOpnoMtrlResponse>"></exception>
		public async Task<M3Response<LstOpnoMtrlResponse>> LstOpnoMtrl(
			string m3_FACI = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			string m3_SUFI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstOpnoMtrl",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUFI))
				request.WithQueryParameter("SUFI", m3_SUFI.Trim());

			// Execute the request
			var result = await Execute<LstOpnoMtrlResponse>(
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
		/// Name LstRelSrv
		/// Description List Related Service
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_MPGM">Maintenance program</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRelSrvResponse></returns>
		/// <exception cref="M3Exception<LstRelSrvResponse>"></exception>
		public async Task<M3Response<LstRelSrvResponse>> LstRelSrv(
			string m3_SUFI, 
			string m3_MPGM = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstRelSrv",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3_SUFI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MPGM))
				request.WithQueryParameter("MPGM", m3_MPGM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());

			// Execute the request
			var result = await Execute<LstRelSrvResponse>(
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
		/// Name LstServiceH
		/// Description List by service (like panel H in MOS300)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstServiceHResponse></returns>
		/// <exception cref="M3Exception<LstServiceHResponse>"></exception>
		public async Task<M3Response<LstServiceHResponse>> LstServiceH(
			int? m3_CONO = null, 
			string m3_FACI = null, 
			string m3_PRNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstServiceH",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());

			// Execute the request
			var result = await Execute<LstServiceHResponse>(
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
		/// Name LstServiceH2
		/// Description List by service (like panel G in MOS300)
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstServiceH2Response></returns>
		/// <exception cref="M3Exception<LstServiceH2Response>"></exception>
		public async Task<M3Response<LstServiceH2Response>> LstServiceH2(
			int? m3_CONO = null, 
			string m3_PRNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstServiceH2",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());

			// Execute the request
			var result = await Execute<LstServiceH2Response>(
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
		/// Name LstSpecReq
		/// Description List Specific Requirement
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_SPRQ">Specific requirement category (Required)</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSpecReqResponse></returns>
		/// <exception cref="M3Exception<LstSpecReqResponse>"></exception>
		public async Task<M3Response<LstSpecReqResponse>> LstSpecReq(
			string m3_SUFI, 
			string m3_SPRQ, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSpecReq",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");
			if (string.IsNullOrWhiteSpace(m3_SPRQ))
				throw new ArgumentNullException("m3_SPRQ");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3_SUFI.Trim())
				.WithQueryParameter("SPRQ", m3_SPRQ.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());

			// Execute the request
			var result = await Execute<LstSpecReqResponse>(
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
		/// Name LstSrvEff
		/// Description List Service Effectivity
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSrvEffResponse></returns>
		/// <exception cref="M3Exception<LstSrvEffResponse>"></exception>
		public async Task<M3Response<LstSrvEffResponse>> LstSrvEff(
			string m3_SUFI, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSrvEff",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3_SUFI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());

			// Execute the request
			var result = await Execute<LstSrvEffResponse>(
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
		/// Name UpdServiceH
		/// Description Update Service Quick entry (like panel H in MOS300)
		/// Version Release: 5ea3
		/// </summary>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_TODT">To date</param>
		/// <param name="m3_RESP">Responsible</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TOFP">Process type</param>
		/// <param name="m3_SRGP">Service group</param>
		/// <param name="m3_ZSET">Service level</param>
		/// <param name="m3_SCHD">Scheduled maintenance service</param>
		/// <param name="m3_EVTY">Event type</param>
		/// <param name="m3_EVTS">Event sequence</param>
		/// <param name="m3_NSTP">Shutdown</param>
		/// <param name="m3_ACRF">User-defined accounting control object</param>
		/// <param name="m3_PLCD">Planning policy</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_MES1">Meter 1</param>
		/// <param name="m3_REIN">Repeat interval</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="m3_PITI">Run time</param>
		/// <param name="m3_PRNP">Planned number of workers - run time</param>
		/// <param name="m3_OPDS">Operation description</param>
		/// <param name="m3_AAFR">Alarm limit</param>
		/// <param name="m3_AATO">Alarm limit</param>
		/// <param name="m3_AATR">Trend limit</param>
		/// <param name="m3_MES0">Meter</param>
		/// <param name="m3_RUOM">Result unit of measure</param>
		/// <param name="m3_DOID">Document identity</param>
		/// <param name="m3_NUC1">Number of put-away cards</param>
		/// <param name="m3_NUC2">Number of material requisitions</param>
		/// <param name="m3_NUC3">Number of labor tickets</param>
		/// <param name="m3_NUC4">Number of shop travelers</param>
		/// <param name="m3_NUC5">Number of routing cards</param>
		/// <param name="m3_NUC6">Number of picking lists</param>
		/// <param name="m3_NUC7">Number of design documents</param>
		/// <param name="m3_TXL1">Text</param>
		/// <param name="m3_TXL2">Text</param>
		/// <param name="m3_TXL3">Text</param>
		/// <param name="m3_TXL4">Text</param>
		/// <param name="m3_TXL5">Text</param>
		/// <param name="m3_TXL6">Text</param>
		/// <param name="m3_TXL7">Text</param>
		/// <param name="m3_TXL8">Text</param>
		/// <param name="m3_TXL9">Text</param>
		/// <param name="m3_TXL0">Text</param>
		/// <param name="m3_EDWT">Estimated downtime</param>
		/// <param name="m3_SCHL">Scheduling logic</param>
		/// <param name="m3_PLMZ">Planning horizon</param>
		/// <param name="m3_STYP">Service Type</param>
		/// <param name="m3_ACWA">Claim warranty</param>
		/// <param name="m3_EXCH">Exchange</param>
		/// <param name="m3_SPMT">Issue method</param>
		/// <param name="m3_ACNF">Automatic approval of service</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdServiceH(
			string m3_SUFI, 
			string m3_FACI, 
			int? m3_CONO = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			string m3_STAT = null, 
			DateTime? m3_STDT = null, 
			DateTime? m3_TODT = null, 
			string m3_RESP = null, 
			string m3_TX40 = null, 
			string m3_TOFP = null, 
			string m3_SRGP = null, 
			int? m3_ZSET = null, 
			int? m3_SCHD = null, 
			string m3_EVTY = null, 
			int? m3_EVTS = null, 
			int? m3_NSTP = null, 
			string m3_ACRF = null, 
			string m3_PLCD = null, 
			string m3_ORTY = null, 
			string m3_MES1 = null, 
			decimal? m3_REIN = null, 
			string m3_PLGR = null, 
			int? m3_PITI = null, 
			int? m3_PRNP = null, 
			string m3_OPDS = null, 
			string m3_AAFR = null, 
			string m3_AATO = null, 
			string m3_AATR = null, 
			string m3_MES0 = null, 
			string m3_RUOM = null, 
			string m3_DOID = null, 
			int? m3_NUC1 = null, 
			int? m3_NUC2 = null, 
			int? m3_NUC3 = null, 
			int? m3_NUC4 = null, 
			int? m3_NUC5 = null, 
			int? m3_NUC6 = null, 
			int? m3_NUC7 = null, 
			string m3_TXL1 = null, 
			string m3_TXL2 = null, 
			string m3_TXL3 = null, 
			string m3_TXL4 = null, 
			string m3_TXL5 = null, 
			string m3_TXL6 = null, 
			string m3_TXL7 = null, 
			string m3_TXL8 = null, 
			string m3_TXL9 = null, 
			string m3_TXL0 = null, 
			int? m3_EDWT = null, 
			int? m3_SCHL = null, 
			int? m3_PLMZ = null, 
			string m3_STYP = null, 
			int? m3_ACWA = null, 
			int? m3_EXCH = null, 
			int? m3_SPMT = null, 
			int? m3_ACNF = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdServiceH",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");

			// Set mandatory parameters
			request
				.WithQueryParameter("SUFI", m3_SUFI.Trim())
				.WithQueryParameter("FACI", m3_FACI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_TODT.HasValue)
				request.WithQueryParameter("TODT", m3_TODT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_RESP))
				request.WithQueryParameter("RESP", m3_RESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TOFP))
				request.WithQueryParameter("TOFP", m3_TOFP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SRGP))
				request.WithQueryParameter("SRGP", m3_SRGP.Trim());
			if (m3_ZSET.HasValue)
				request.WithQueryParameter("ZSET", m3_ZSET.Value.ToString());
			if (m3_SCHD.HasValue)
				request.WithQueryParameter("SCHD", m3_SCHD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_EVTY))
				request.WithQueryParameter("EVTY", m3_EVTY.Trim());
			if (m3_EVTS.HasValue)
				request.WithQueryParameter("EVTS", m3_EVTS.Value.ToString());
			if (m3_NSTP.HasValue)
				request.WithQueryParameter("NSTP", m3_NSTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLCD))
				request.WithQueryParameter("PLCD", m3_PLCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MES1))
				request.WithQueryParameter("MES1", m3_MES1.Trim());
			if (m3_REIN.HasValue)
				request.WithQueryParameter("REIN", m3_REIN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());
			if (m3_PITI.HasValue)
				request.WithQueryParameter("PITI", m3_PITI.Value.ToString());
			if (m3_PRNP.HasValue)
				request.WithQueryParameter("PRNP", m3_PRNP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OPDS))
				request.WithQueryParameter("OPDS", m3_OPDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AAFR))
				request.WithQueryParameter("AAFR", m3_AAFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AATO))
				request.WithQueryParameter("AATO", m3_AATO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AATR))
				request.WithQueryParameter("AATR", m3_AATR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MES0))
				request.WithQueryParameter("MES0", m3_MES0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RUOM))
				request.WithQueryParameter("RUOM", m3_RUOM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DOID))
				request.WithQueryParameter("DOID", m3_DOID.Trim());
			if (m3_NUC1.HasValue)
				request.WithQueryParameter("NUC1", m3_NUC1.Value.ToString());
			if (m3_NUC2.HasValue)
				request.WithQueryParameter("NUC2", m3_NUC2.Value.ToString());
			if (m3_NUC3.HasValue)
				request.WithQueryParameter("NUC3", m3_NUC3.Value.ToString());
			if (m3_NUC4.HasValue)
				request.WithQueryParameter("NUC4", m3_NUC4.Value.ToString());
			if (m3_NUC5.HasValue)
				request.WithQueryParameter("NUC5", m3_NUC5.Value.ToString());
			if (m3_NUC6.HasValue)
				request.WithQueryParameter("NUC6", m3_NUC6.Value.ToString());
			if (m3_NUC7.HasValue)
				request.WithQueryParameter("NUC7", m3_NUC7.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TXL1))
				request.WithQueryParameter("TXL1", m3_TXL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL2))
				request.WithQueryParameter("TXL2", m3_TXL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL3))
				request.WithQueryParameter("TXL3", m3_TXL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL4))
				request.WithQueryParameter("TXL4", m3_TXL4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL5))
				request.WithQueryParameter("TXL5", m3_TXL5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL6))
				request.WithQueryParameter("TXL6", m3_TXL6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL7))
				request.WithQueryParameter("TXL7", m3_TXL7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL8))
				request.WithQueryParameter("TXL8", m3_TXL8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL9))
				request.WithQueryParameter("TXL9", m3_TXL9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXL0))
				request.WithQueryParameter("TXL0", m3_TXL0.Trim());
			if (m3_EDWT.HasValue)
				request.WithQueryParameter("EDWT", m3_EDWT.Value.ToString());
			if (m3_SCHL.HasValue)
				request.WithQueryParameter("SCHL", m3_SCHL.Value.ToString());
			if (m3_PLMZ.HasValue)
				request.WithQueryParameter("PLMZ", m3_PLMZ.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_STYP))
				request.WithQueryParameter("STYP", m3_STYP.Trim());
			if (m3_ACWA.HasValue)
				request.WithQueryParameter("ACWA", m3_ACWA.Value.ToString());
			if (m3_EXCH.HasValue)
				request.WithQueryParameter("EXCH", m3_EXCH.Value.ToString());
			if (m3_SPMT.HasValue)
				request.WithQueryParameter("SPMT", m3_SPMT.Value.ToString());
			if (m3_ACNF.HasValue)
				request.WithQueryParameter("ACNF", m3_ACNF.Value.ToString());

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
		/// Name UpdServiceH2
		/// Description Update Service Quick entry (like panel G in MOS300)
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_SUFI">Service (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PRNO">Product number</param>
		/// <param name="m3_STRT">Product structure type</param>
		/// <param name="m3_SMC0">User defined field 1</param>
		/// <param name="m3_SMC1">User defined field 2</param>
		/// <param name="m3_SMC2">User defined field 3</param>
		/// <param name="m3_SMC3">User defined field 4</param>
		/// <param name="m3_SMC4">User defined field 5</param>
		/// <param name="m3_SMC5">User defined field 6</param>
		/// <param name="m3_SMC6">User defined field 7</param>
		/// <param name="m3_SMC7">User defined field 8</param>
		/// <param name="m3_SMC8">User defined field 9</param>
		/// <param name="m3_SMC9">User defined field 10</param>
		/// <param name="m3_CFI1">User-defined field 1 - item</param>
		/// <param name="m3_CFI2">New field description</param>
		/// <param name="m3_CFI3">User-defined field 3 - item</param>
		/// <param name="m3_CFI4">User-defined field 4 - item</param>
		/// <param name="m3_CFI5">User-defined field 5 - item</param>
		/// <param name="m3_TAXC">Tax code customer/address</param>
		/// <param name="m3_TXCS">Tax Code Customer</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdServiceH2(
			string m3_FACI, 
			string m3_SUFI, 
			int? m3_CONO = null, 
			string m3_PRNO = null, 
			string m3_STRT = null, 
			string m3_SMC0 = null, 
			string m3_SMC1 = null, 
			string m3_SMC2 = null, 
			string m3_SMC3 = null, 
			string m3_SMC4 = null, 
			string m3_SMC5 = null, 
			string m3_SMC6 = null, 
			string m3_SMC7 = null, 
			string m3_SMC8 = null, 
			string m3_SMC9 = null, 
			string m3_CFI1 = null, 
			decimal? m3_CFI2 = null, 
			string m3_CFI3 = null, 
			string m3_CFI4 = null, 
			string m3_CFI5 = null, 
			string m3_TAXC = null, 
			string m3_TXCS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdServiceH2",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_SUFI))
				throw new ArgumentNullException("m3_SUFI");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("SUFI", m3_SUFI.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PRNO))
				request.WithQueryParameter("PRNO", m3_PRNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STRT))
				request.WithQueryParameter("STRT", m3_STRT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC0))
				request.WithQueryParameter("SMC0", m3_SMC0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC1))
				request.WithQueryParameter("SMC1", m3_SMC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC2))
				request.WithQueryParameter("SMC2", m3_SMC2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC3))
				request.WithQueryParameter("SMC3", m3_SMC3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC4))
				request.WithQueryParameter("SMC4", m3_SMC4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC5))
				request.WithQueryParameter("SMC5", m3_SMC5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC6))
				request.WithQueryParameter("SMC6", m3_SMC6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC7))
				request.WithQueryParameter("SMC7", m3_SMC7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC8))
				request.WithQueryParameter("SMC8", m3_SMC8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMC9))
				request.WithQueryParameter("SMC9", m3_SMC9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI1))
				request.WithQueryParameter("CFI1", m3_CFI1.Trim());
			if (m3_CFI2.HasValue)
				request.WithQueryParameter("CFI2", m3_CFI2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFI3))
				request.WithQueryParameter("CFI3", m3_CFI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI4))
				request.WithQueryParameter("CFI4", m3_CFI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI5))
				request.WithQueryParameter("CFI5", m3_CFI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAXC))
				request.WithQueryParameter("TAXC", m3_TAXC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXCS))
				request.WithQueryParameter("TXCS", m3_TXCS.Trim());

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
