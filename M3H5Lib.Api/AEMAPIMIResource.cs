/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.AEMAPIMI;
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
	/// Name: AEMAPIMI
	/// Component Name: ItemSerialNumber
	/// Description: AEM telematics standard for equipment data
	/// Version Release: 5ea1
	///</summary>
	public partial class AEMAPIMIResource : M3BaseResourceEndpoint
	{
		public AEMAPIMIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "AEMAPIMI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddEquip
		/// Description AdEquip
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_STAI">Interface status</param>
		/// <param name="m3_STOT">Lowest status child table</param>
		/// <param name="m3_PROD">Manufacturer</param>
		/// <param name="m3_FLNO">Fleet number</param>
		/// <param name="m3_TAIL">Registration number/site</param>
		/// <param name="m3_SKEY">Search key for equipment</param>
		/// <param name="m3_PRSS">Process</param>
		/// <param name="m3_RFIA">Asset tag</param>
		/// <param name="m3_BRAN">Brand</param>
		/// <param name="m3_REMK">Remark</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddEquip(
			string m3_ITNO = null, 
			string m3_SERN = null, 
			string m3_STAI = null, 
			string m3_STOT = null, 
			string m3_PROD = null, 
			string m3_FLNO = null, 
			string m3_TAIL = null, 
			string m3_SKEY = null, 
			string m3_PRSS = null, 
			string m3_RFIA = null, 
			string m3_BRAN = null, 
			string m3_REMK = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddEquip",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAI))
				request.WithQueryParameter("STAI", m3_STAI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STOT))
				request.WithQueryParameter("STOT", m3_STOT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROD))
				request.WithQueryParameter("PROD", m3_PROD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FLNO))
				request.WithQueryParameter("FLNO", m3_FLNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAIL))
				request.WithQueryParameter("TAIL", m3_TAIL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SKEY))
				request.WithQueryParameter("SKEY", m3_SKEY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRSS))
				request.WithQueryParameter("PRSS", m3_PRSS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RFIA))
				request.WithQueryParameter("RFIA", m3_RFIA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRAN))
				request.WithQueryParameter("BRAN", m3_BRAN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REMK))
				request.WithQueryParameter("REMK", m3_REMK.Trim());
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
		/// Name AddFault
		/// Description Add Fault codes for equipment
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_FCLA">Error code 1</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_STTI">Start time</param>
		/// <param name="m3_REMK">Remark</param>
		/// <param name="m3_STAI">Interface status</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_E0PA">Partner</param>
		/// <param name="m3_E065">Message type</param>
		/// <param name="m3_FCL2">Error code 2</param>
		/// <param name="m3_FCL3">Error code 3</param>
		/// <param name="m3_CNFA">Number of verified failures</param>
		/// <param name="m3_CFI1">User-defined field 1 - item</param>
		/// <param name="m3_CFI2">User-defined field 2 - item</param>
		/// <param name="m3_CFI3">User-defined field 3 - item</param>
		/// <param name="m3_CFI4">User-defined field 4 - item</param>
		/// <param name="m3_CFI5">User-defined field 5 - item</param>
		/// <param name="m3_CFI6">New field description</param>
		/// <param name="m3_CFI7">New field description</param>
		/// <param name="m3_CFI8">New field description</param>
		/// <param name="m3_CFI9">New field description</param>
		/// <param name="m3_CFI0">New field description</param>
		/// <param name="m3_ITNS">Item number SMCS</param>
		/// <param name="m3_SMC0">OEM code</param>
		/// <param name="m3_SMC1">OEM code</param>
		/// <param name="m3_SMC2">OEM code</param>
		/// <param name="m3_SMC3">OEM code</param>
		/// <param name="m3_SMC4">OEM code</param>
		/// <param name="m3_SMC5">OEM code</param>
		/// <param name="m3_SMC6">OEM code</param>
		/// <param name="m3_SMC7">OEM code</param>
		/// <param name="m3_SMC8">OEM code</param>
		/// <param name="m3_SMC9">OEM code</param>
		/// <param name="m3_PLPN">Planned order</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_AESC">Criticality class</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_MVA0">Since new</param>
		/// <param name="m3_MES0">Meter</param>
		/// <param name="m3_UNIT">Unit of measure</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddFault(
			string m3_ITNO = null, 
			string m3_SERN = null, 
			string m3_FCLA = null, 
			DateTime? m3_STDT = null, 
			int? m3_STTI = null, 
			string m3_REMK = null, 
			string m3_STAI = null, 
			decimal? m3_TXID = null, 
			string m3_E0PA = null, 
			string m3_E065 = null, 
			string m3_FCL2 = null, 
			string m3_FCL3 = null, 
			decimal? m3_CNFA = null, 
			string m3_CFI1 = null, 
			decimal? m3_CFI2 = null, 
			string m3_CFI3 = null, 
			string m3_CFI4 = null, 
			string m3_CFI5 = null, 
			string m3_CFI6 = null, 
			decimal? m3_CFI7 = null, 
			string m3_CFI8 = null, 
			string m3_CFI9 = null, 
			string m3_CFI0 = null, 
			string m3_ITNS = null, 
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
			int? m3_PLPN = null, 
			string m3_TX40 = null, 
			int? m3_AESC = null, 
			string m3_LNCD = null, 
			decimal? m3_MVA0 = null, 
			string m3_MES0 = null, 
			string m3_UNIT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddFault",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCLA))
				request.WithQueryParameter("FCLA", m3_FCLA.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_STTI.HasValue)
				request.WithQueryParameter("STTI", m3_STTI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REMK))
				request.WithQueryParameter("REMK", m3_REMK.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAI))
				request.WithQueryParameter("STAI", m3_STAI.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_E0PA))
				request.WithQueryParameter("E0PA", m3_E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E065))
				request.WithQueryParameter("E065", m3_E065.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL2))
				request.WithQueryParameter("FCL2", m3_FCL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCL3))
				request.WithQueryParameter("FCL3", m3_FCL3.Trim());
			if (m3_CNFA.HasValue)
				request.WithQueryParameter("CNFA", m3_CNFA.Value.ToString());
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
			if (!string.IsNullOrWhiteSpace(m3_CFI6))
				request.WithQueryParameter("CFI6", m3_CFI6.Trim());
			if (m3_CFI7.HasValue)
				request.WithQueryParameter("CFI7", m3_CFI7.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CFI8))
				request.WithQueryParameter("CFI8", m3_CFI8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI9))
				request.WithQueryParameter("CFI9", m3_CFI9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI0))
				request.WithQueryParameter("CFI0", m3_CFI0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNS))
				request.WithQueryParameter("ITNS", m3_ITNS.Trim());
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
			if (m3_PLPN.HasValue)
				request.WithQueryParameter("PLPN", m3_PLPN.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (m3_AESC.HasValue)
				request.WithQueryParameter("AESC", m3_AESC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (m3_MVA0.HasValue)
				request.WithQueryParameter("MVA0", m3_MVA0.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MES0))
				request.WithQueryParameter("MES0", m3_MES0.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UNIT))
				request.WithQueryParameter("UNIT", m3_UNIT.Trim());

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
		/// Name AddLoc
		/// Description Add location for equipment
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_STTI">Start time</param>
		/// <param name="m3_CORX">Coordinate X</param>
		/// <param name="m3_CORY">Coordinate Y</param>
		/// <param name="m3_CORZ">Coordinate Z</param>
		/// <param name="m3_REMK">Remark</param>
		/// <param name="m3_STAI">Interface status</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddLoc(
			string m3_ITNO = null, 
			string m3_SERN = null, 
			DateTime? m3_STDT = null, 
			int? m3_STTI = null, 
			string m3_CORX = null, 
			string m3_CORY = null, 
			string m3_CORZ = null, 
			string m3_REMK = null, 
			string m3_STAI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddLoc",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_STTI.HasValue)
				request.WithQueryParameter("STTI", m3_STTI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CORX))
				request.WithQueryParameter("CORX", m3_CORX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CORY))
				request.WithQueryParameter("CORY", m3_CORY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CORZ))
				request.WithQueryParameter("CORZ", m3_CORZ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REMK))
				request.WithQueryParameter("REMK", m3_REMK.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAI))
				request.WithQueryParameter("STAI", m3_STAI.Trim());
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
		/// Name AddMeterReading
		/// Description Add meter readings for equipment
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_MES0">Meter</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_STTI">Start time</param>
		/// <param name="m3_MVA0">Since new</param>
		/// <param name="m3_UNIT">Unit of measure</param>
		/// <param name="m3_CIND">Installation date replaced meter</param>
		/// <param name="m3_CINT">Installation time of replaced meter</param>
		/// <param name="m3_REMK">Remark</param>
		/// <param name="m3_STAI">Interface status</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_CFI1">User-defined field 1 - item</param>
		/// <param name="m3_CFI2">User-defined field 2 - item</param>
		/// <param name="m3_CFI3">User-defined field 3 - item</param>
		/// <param name="m3_CFI4">User-defined field 4 - item</param>
		/// <param name="m3_CFI5">User-defined field 5 - item</param>
		/// <param name="m3_ITNS">Item number SMCS</param>
		/// <param name="m3_SMC0">OEM code</param>
		/// <param name="m3_SMC1">OEM code</param>
		/// <param name="m3_SMC2">OEM code</param>
		/// <param name="m3_SMC3">OEM code</param>
		/// <param name="m3_SMC4">OEM code</param>
		/// <param name="m3_SMC5">OEM code</param>
		/// <param name="m3_SMC6">OEM code</param>
		/// <param name="m3_SMC7">OEM code</param>
		/// <param name="m3_SMC8">OEM code</param>
		/// <param name="m3_SMC9">OEM code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddMeterReading(
			string m3_ITNO = null, 
			string m3_SERN = null, 
			string m3_MES0 = null, 
			DateTime? m3_STDT = null, 
			int? m3_STTI = null, 
			decimal? m3_MVA0 = null, 
			string m3_UNIT = null, 
			DateTime? m3_CIND = null, 
			int? m3_CINT = null, 
			string m3_REMK = null, 
			string m3_STAI = null, 
			decimal? m3_TXID = null, 
			string m3_CFI1 = null, 
			decimal? m3_CFI2 = null, 
			string m3_CFI3 = null, 
			string m3_CFI4 = null, 
			string m3_CFI5 = null, 
			string m3_ITNS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddMeterReading",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MES0))
				request.WithQueryParameter("MES0", m3_MES0.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_STTI.HasValue)
				request.WithQueryParameter("STTI", m3_STTI.Value.ToString());
			if (m3_MVA0.HasValue)
				request.WithQueryParameter("MVA0", m3_MVA0.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_UNIT))
				request.WithQueryParameter("UNIT", m3_UNIT.Trim());
			if (m3_CIND.HasValue)
				request.WithQueryParameter("CIND", m3_CIND.Value.ToM3String());
			if (m3_CINT.HasValue)
				request.WithQueryParameter("CINT", m3_CINT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REMK))
				request.WithQueryParameter("REMK", m3_REMK.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAI))
				request.WithQueryParameter("STAI", m3_STAI.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
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
			if (!string.IsNullOrWhiteSpace(m3_ITNS))
				request.WithQueryParameter("ITNS", m3_ITNS.Trim());
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
		/// Name AddSwitch
		/// Description Add switch codes for equipment
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_SWNR">Switch number</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_STTI">Start time</param>
		/// <param name="m3_ONOF">Yes/no</param>
		/// <param name="m3_REMK">Remark</param>
		/// <param name="m3_STAI">Interface status</param>
		/// <param name="m3_TXID">Text identity</param>
		/// <param name="m3_CFI1">User-defined field 1 - item</param>
		/// <param name="m3_CFI2">User-defined field 2 - item</param>
		/// <param name="m3_CFI3">User-defined field 3 - item</param>
		/// <param name="m3_CFI4">User-defined field 4 - item</param>
		/// <param name="m3_CFI5">User-defined field 5 - item</param>
		/// <param name="m3_ITNS">Item number SMCS</param>
		/// <param name="m3_SMC0">OEM code</param>
		/// <param name="m3_SMC1">OEM code</param>
		/// <param name="m3_SMC2">OEM code</param>
		/// <param name="m3_SMC3">OEM code</param>
		/// <param name="m3_SMC4">OEM code</param>
		/// <param name="m3_SMC5">OEM code</param>
		/// <param name="m3_SMC6">OEM code</param>
		/// <param name="m3_SMC7">OEM code</param>
		/// <param name="m3_SMC8">OEM code</param>
		/// <param name="m3_SMC9">OEM code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddSwitch(
			string m3_ITNO = null, 
			string m3_SERN = null, 
			string m3_SWNR = null, 
			DateTime? m3_STDT = null, 
			int? m3_STTI = null, 
			int? m3_ONOF = null, 
			string m3_REMK = null, 
			string m3_STAI = null, 
			decimal? m3_TXID = null, 
			string m3_CFI1 = null, 
			decimal? m3_CFI2 = null, 
			string m3_CFI3 = null, 
			string m3_CFI4 = null, 
			string m3_CFI5 = null, 
			string m3_ITNS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddSwitch",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SWNR))
				request.WithQueryParameter("SWNR", m3_SWNR.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_STTI.HasValue)
				request.WithQueryParameter("STTI", m3_STTI.Value.ToString());
			if (m3_ONOF.HasValue)
				request.WithQueryParameter("ONOF", m3_ONOF.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_REMK))
				request.WithQueryParameter("REMK", m3_REMK.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAI))
				request.WithQueryParameter("STAI", m3_STAI.Trim());
			if (m3_TXID.HasValue)
				request.WithQueryParameter("TXID", m3_TXID.Value.ToString());
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
			if (!string.IsNullOrWhiteSpace(m3_ITNS))
				request.WithQueryParameter("ITNS", m3_ITNS.Trim());
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
		/// Name DelEquip
		/// Description Dlt Equipment
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<DelEquipResponse></returns>
		/// <exception cref="M3Exception<DelEquipResponse>"></exception>
		public async Task<M3Response<DelEquipResponse>> DelEquip(
			string m3_ITNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelEquip",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim());

			// Execute the request
			var result = await Execute<DelEquipResponse>(
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
		/// Name DelFault
		/// Description Delete Fault codes
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_FCLA">Error code 1 (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_STTI">Start time (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<DelFaultResponse></returns>
		/// <exception cref="M3Exception<DelFaultResponse>"></exception>
		public async Task<M3Response<DelFaultResponse>> DelFault(
			string m3_ITNO, 
			string m3_SERN, 
			string m3_FCLA, 
			DateTime m3_STDT, 
			int m3_STTI, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelFault",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");
			if (string.IsNullOrWhiteSpace(m3_FCLA))
				throw new ArgumentNullException("m3_FCLA");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim())
				.WithQueryParameter("FCLA", m3_FCLA.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String())
				.WithQueryParameter("STTI", m3_STTI.ToString());

			// Execute the request
			var result = await Execute<DelFaultResponse>(
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
		/// Name DelLoc
		/// Description Delete  location for equipment
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_STTI">Start time</param>
		/// <param name="m3_CORX">Coordinate X</param>
		/// <param name="m3_CORY">Coordinate Y</param>
		/// <param name="m3_CORZ">Coordinate Z</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<DelLocResponse></returns>
		/// <exception cref="M3Exception<DelLocResponse>"></exception>
		public async Task<M3Response<DelLocResponse>> DelLoc(
			string m3_ITNO = null, 
			string m3_SERN = null, 
			DateTime? m3_STDT = null, 
			int? m3_STTI = null, 
			string m3_CORX = null, 
			string m3_CORY = null, 
			string m3_CORZ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelLoc",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_STTI.HasValue)
				request.WithQueryParameter("STTI", m3_STTI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CORX))
				request.WithQueryParameter("CORX", m3_CORX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CORY))
				request.WithQueryParameter("CORY", m3_CORY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CORZ))
				request.WithQueryParameter("CORZ", m3_CORZ.Trim());

			// Execute the request
			var result = await Execute<DelLocResponse>(
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
		/// Name DelMeterReading
		/// Description Delete meter readings for equipment
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_MES0">Meter (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_STTI">Start time (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<DelMeterReadingResponse></returns>
		/// <exception cref="M3Exception<DelMeterReadingResponse>"></exception>
		public async Task<M3Response<DelMeterReadingResponse>> DelMeterReading(
			string m3_ITNO, 
			string m3_SERN, 
			string m3_MES0, 
			DateTime m3_STDT, 
			int m3_STTI, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelMeterReading",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");
			if (string.IsNullOrWhiteSpace(m3_MES0))
				throw new ArgumentNullException("m3_MES0");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim())
				.WithQueryParameter("MES0", m3_MES0.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String())
				.WithQueryParameter("STTI", m3_STTI.ToString());

			// Execute the request
			var result = await Execute<DelMeterReadingResponse>(
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
		/// Name DelSwitch
		/// Description Delete switch codes for equipment
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_SWNR">Switch number (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_STTI">Start time (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<DelSwitchResponse></returns>
		/// <exception cref="M3Exception<DelSwitchResponse>"></exception>
		public async Task<M3Response<DelSwitchResponse>> DelSwitch(
			string m3_ITNO, 
			string m3_SERN, 
			string m3_SWNR, 
			DateTime m3_STDT, 
			int m3_STTI, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelSwitch",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");
			if (string.IsNullOrWhiteSpace(m3_SWNR))
				throw new ArgumentNullException("m3_SWNR");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim())
				.WithQueryParameter("SWNR", m3_SWNR.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String())
				.WithQueryParameter("STTI", m3_STTI.ToString());

			// Execute the request
			var result = await Execute<DelSwitchResponse>(
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
		/// Name GetEquip
		/// Description Get Equipment
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetEquipResponse></returns>
		/// <exception cref="M3Exception<GetEquipResponse>"></exception>
		public async Task<M3Response<GetEquipResponse>> GetEquip(
			string m3_ITNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetEquip",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim());

			// Execute the request
			var result = await Execute<GetEquipResponse>(
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
		/// Name GetFault
		/// Description Get Fault codes
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_FCLA">Error code 1 (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_STTI">Start time (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetFaultResponse></returns>
		/// <exception cref="M3Exception<GetFaultResponse>"></exception>
		public async Task<M3Response<GetFaultResponse>> GetFault(
			string m3_ITNO, 
			string m3_SERN, 
			string m3_FCLA, 
			DateTime m3_STDT, 
			int m3_STTI, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetFault",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");
			if (string.IsNullOrWhiteSpace(m3_FCLA))
				throw new ArgumentNullException("m3_FCLA");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim())
				.WithQueryParameter("FCLA", m3_FCLA.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String())
				.WithQueryParameter("STTI", m3_STTI.ToString());

			// Execute the request
			var result = await Execute<GetFaultResponse>(
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
		/// Name GetLoc
		/// Description Get location for equipment
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_STTI">Start time (Required)</param>
		/// <param name="m3_CORX">Coordinate X (Required)</param>
		/// <param name="m3_CORY">Coordinate Y (Required)</param>
		/// <param name="m3_CORZ">Coordinate Z (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLocResponse></returns>
		/// <exception cref="M3Exception<GetLocResponse>"></exception>
		public async Task<M3Response<GetLocResponse>> GetLoc(
			string m3_ITNO, 
			string m3_SERN, 
			DateTime m3_STDT, 
			int m3_STTI, 
			string m3_CORX, 
			string m3_CORY, 
			string m3_CORZ, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetLoc",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");
			if (string.IsNullOrWhiteSpace(m3_CORX))
				throw new ArgumentNullException("m3_CORX");
			if (string.IsNullOrWhiteSpace(m3_CORY))
				throw new ArgumentNullException("m3_CORY");
			if (string.IsNullOrWhiteSpace(m3_CORZ))
				throw new ArgumentNullException("m3_CORZ");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String())
				.WithQueryParameter("STTI", m3_STTI.ToString())
				.WithQueryParameter("CORX", m3_CORX.Trim())
				.WithQueryParameter("CORY", m3_CORY.Trim())
				.WithQueryParameter("CORZ", m3_CORZ.Trim());

			// Execute the request
			var result = await Execute<GetLocResponse>(
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
		/// Name GetMeterReading
		/// Description Getmeter readings for equipment
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_MES0">Meter (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_STTI">Start time (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetMeterReadingResponse></returns>
		/// <exception cref="M3Exception<GetMeterReadingResponse>"></exception>
		public async Task<M3Response<GetMeterReadingResponse>> GetMeterReading(
			string m3_ITNO, 
			string m3_SERN, 
			string m3_MES0, 
			DateTime m3_STDT, 
			int m3_STTI, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetMeterReading",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");
			if (string.IsNullOrWhiteSpace(m3_MES0))
				throw new ArgumentNullException("m3_MES0");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim())
				.WithQueryParameter("MES0", m3_MES0.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String())
				.WithQueryParameter("STTI", m3_STTI.ToString());

			// Execute the request
			var result = await Execute<GetMeterReadingResponse>(
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
		/// Name GetSwitch
		/// Description Getswitch codes for equipment
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_SERN">Serial number (Required)</param>
		/// <param name="m3_SWNR">Switch number (Required)</param>
		/// <param name="m3_STDT">Start date (Required)</param>
		/// <param name="m3_STTI">Start time (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSwitchResponse></returns>
		/// <exception cref="M3Exception<GetSwitchResponse>"></exception>
		public async Task<M3Response<GetSwitchResponse>> GetSwitch(
			string m3_ITNO, 
			string m3_SERN, 
			string m3_SWNR, 
			DateTime m3_STDT, 
			int m3_STTI, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetSwitch",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_SERN))
				throw new ArgumentNullException("m3_SERN");
			if (string.IsNullOrWhiteSpace(m3_SWNR))
				throw new ArgumentNullException("m3_SWNR");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SERN", m3_SERN.Trim())
				.WithQueryParameter("SWNR", m3_SWNR.Trim())
				.WithQueryParameter("STDT", m3_STDT.ToM3String())
				.WithQueryParameter("STTI", m3_STTI.ToString());

			// Execute the request
			var result = await Execute<GetSwitchResponse>(
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
		/// Name LstEquip
		/// Description List equipment
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstEquipResponse></returns>
		/// <exception cref="M3Exception<LstEquipResponse>"></exception>
		public async Task<M3Response<LstEquipResponse>> LstEquip(
			string m3_ITNO = null, 
			string m3_SERN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstEquip",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());

			// Execute the request
			var result = await Execute<LstEquipResponse>(
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
		/// Name LstFault
		/// Description ListFault codes
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_FCLA">Error code 1</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_STTI">Start time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstFaultResponse></returns>
		/// <exception cref="M3Exception<LstFaultResponse>"></exception>
		public async Task<M3Response<LstFaultResponse>> LstFault(
			string m3_ITNO = null, 
			string m3_SERN = null, 
			string m3_FCLA = null, 
			DateTime? m3_STDT = null, 
			int? m3_STTI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstFault",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCLA))
				request.WithQueryParameter("FCLA", m3_FCLA.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_STTI.HasValue)
				request.WithQueryParameter("STTI", m3_STTI.Value.ToString());

			// Execute the request
			var result = await Execute<LstFaultResponse>(
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
		/// Name LstLoc
		/// Description List location for equipment
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_STTI">Start time</param>
		/// <param name="m3_CORX">Coordinate X</param>
		/// <param name="m3_CORY">Coordinate Y</param>
		/// <param name="m3_CORZ">Coordinate Z</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLocResponse></returns>
		/// <exception cref="M3Exception<LstLocResponse>"></exception>
		public async Task<M3Response<LstLocResponse>> LstLoc(
			string m3_ITNO = null, 
			string m3_SERN = null, 
			DateTime? m3_STDT = null, 
			int? m3_STTI = null, 
			string m3_CORX = null, 
			string m3_CORY = null, 
			string m3_CORZ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLoc",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_STTI.HasValue)
				request.WithQueryParameter("STTI", m3_STTI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CORX))
				request.WithQueryParameter("CORX", m3_CORX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CORY))
				request.WithQueryParameter("CORY", m3_CORY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CORZ))
				request.WithQueryParameter("CORZ", m3_CORZ.Trim());

			// Execute the request
			var result = await Execute<LstLocResponse>(
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
		/// Name LstMeterReading
		/// Description List meter readings for equipment
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_MES0">Meter</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_STTI">Start time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstMeterReadingResponse></returns>
		/// <exception cref="M3Exception<LstMeterReadingResponse>"></exception>
		public async Task<M3Response<LstMeterReadingResponse>> LstMeterReading(
			string m3_ITNO = null, 
			string m3_SERN = null, 
			string m3_MES0 = null, 
			DateTime? m3_STDT = null, 
			int? m3_STTI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstMeterReading",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MES0))
				request.WithQueryParameter("MES0", m3_MES0.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_STTI.HasValue)
				request.WithQueryParameter("STTI", m3_STTI.Value.ToString());

			// Execute the request
			var result = await Execute<LstMeterReadingResponse>(
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
		/// Name LstSwitch
		/// Description List switch codes for equipment
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_SERN">Serial number</param>
		/// <param name="m3_SWNR">Switch number</param>
		/// <param name="m3_STDT">Start date</param>
		/// <param name="m3_STTI">Start time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSwitchResponse></returns>
		/// <exception cref="M3Exception<LstSwitchResponse>"></exception>
		public async Task<M3Response<LstSwitchResponse>> LstSwitch(
			string m3_ITNO = null, 
			string m3_SERN = null, 
			string m3_SWNR = null, 
			DateTime? m3_STDT = null, 
			int? m3_STTI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstSwitch",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SERN))
				request.WithQueryParameter("SERN", m3_SERN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SWNR))
				request.WithQueryParameter("SWNR", m3_SWNR.Trim());
			if (m3_STDT.HasValue)
				request.WithQueryParameter("STDT", m3_STDT.Value.ToM3String());
			if (m3_STTI.HasValue)
				request.WithQueryParameter("STTI", m3_STTI.Value.ToString());

			// Execute the request
			var result = await Execute<LstSwitchResponse>(
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
