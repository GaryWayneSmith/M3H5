/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.CMS011MI;
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
	/// Name: CMS011MI
	/// Component Name: CMS011
	/// Description: Api: Information browser cat - Related tables
	/// Version Release: 5ea2
	///</summary>
	public partial class CMS011MIResource : M3BaseResourceEndpoint
	{
		public CMS011MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CMS011MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddFields
		/// Description Add table fields to field group in CSYKEY
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_IBCA">Information browser category</param>
		/// <param name="m3_MGRP">Field group</param>
		/// <param name="m3_FILE">File</param>
		/// <param name="m3_FIPX">Field prefix</param>
		/// <param name="m3_FDI1">Field</param>
		/// <param name="m3_FDI2">Field</param>
		/// <param name="m3_FDI3">Field</param>
		/// <param name="m3_FDI4">Field</param>
		/// <param name="m3_FDI5">Field</param>
		/// <param name="m3_FDI6">Field</param>
		/// <param name="m3_FDI7">Field</param>
		/// <param name="m3_FDI8">Field</param>
		/// <param name="m3_FDI9">Field</param>
		/// <param name="m3_FDIA">Field</param>
		/// <param name="m3_FDB1">Field length</param>
		/// <param name="m3_FDB2">Field length</param>
		/// <param name="m3_FDB3">Field length</param>
		/// <param name="m3_FDB4">Field length</param>
		/// <param name="m3_FDB5">Field length</param>
		/// <param name="m3_FDB6">Field length</param>
		/// <param name="m3_FDB7">Field length</param>
		/// <param name="m3_FDB8">Field length</param>
		/// <param name="m3_FDB9">Field length</param>
		/// <param name="m3_FDBA">Field length</param>
		/// <param name="m3_OVM1">Overriding message ID</param>
		/// <param name="m3_OVM2">Overriding message ID</param>
		/// <param name="m3_OVM3">Overriding message ID</param>
		/// <param name="m3_OVM4">Overriding message ID</param>
		/// <param name="m3_OVM5">Overriding message ID</param>
		/// <param name="m3_OVM6">Overriding message ID</param>
		/// <param name="m3_OVM7">Overriding message ID</param>
		/// <param name="m3_OVM8">Overriding message ID</param>
		/// <param name="m3_OVM9">Overriding message ID</param>
		/// <param name="m3_OVMA">Overriding message ID</param>
		/// <param name="m3_OVN1">Overriding name</param>
		/// <param name="m3_OVN2">Overriding name</param>
		/// <param name="m3_OVN3">Overriding name</param>
		/// <param name="m3_OVN4">Overriding name</param>
		/// <param name="m3_OVN5">Overriding name</param>
		/// <param name="m3_OVN6">Overriding name</param>
		/// <param name="m3_OVN7">Overriding name</param>
		/// <param name="m3_OVN8">Overriding name</param>
		/// <param name="m3_OVN9">Overriding name</param>
		/// <param name="m3_OVNA">Overriding name</param>
		/// <param name="m3_MSF1">Message file</param>
		/// <param name="m3_MSF2">Message file</param>
		/// <param name="m3_MSF3">Message file</param>
		/// <param name="m3_MSF4">Message file</param>
		/// <param name="m3_MSF5">Message file</param>
		/// <param name="m3_MSF6">Message file</param>
		/// <param name="m3_MSF7">Message file</param>
		/// <param name="m3_MSF8">Message file</param>
		/// <param name="m3_MSF9">Message file</param>
		/// <param name="m3_MSFA">Message file</param>
		/// <param name="m3_RPBK">XML section</param>
		/// <param name="m3_COCO">Configuration component</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddFields(
			string m3_IBCA = null, 
			string m3_MGRP = null, 
			string m3_FILE = null, 
			string m3_FIPX = null, 
			string m3_FDI1 = null, 
			string m3_FDI2 = null, 
			string m3_FDI3 = null, 
			string m3_FDI4 = null, 
			string m3_FDI5 = null, 
			string m3_FDI6 = null, 
			string m3_FDI7 = null, 
			string m3_FDI8 = null, 
			string m3_FDI9 = null, 
			string m3_FDIA = null, 
			int? m3_FDB1 = null, 
			int? m3_FDB2 = null, 
			int? m3_FDB3 = null, 
			int? m3_FDB4 = null, 
			int? m3_FDB5 = null, 
			int? m3_FDB6 = null, 
			int? m3_FDB7 = null, 
			int? m3_FDB8 = null, 
			int? m3_FDB9 = null, 
			int? m3_FDBA = null, 
			string m3_OVM1 = null, 
			string m3_OVM2 = null, 
			string m3_OVM3 = null, 
			string m3_OVM4 = null, 
			string m3_OVM5 = null, 
			string m3_OVM6 = null, 
			string m3_OVM7 = null, 
			string m3_OVM8 = null, 
			string m3_OVM9 = null, 
			string m3_OVMA = null, 
			string m3_OVN1 = null, 
			string m3_OVN2 = null, 
			string m3_OVN3 = null, 
			string m3_OVN4 = null, 
			string m3_OVN5 = null, 
			string m3_OVN6 = null, 
			string m3_OVN7 = null, 
			string m3_OVN8 = null, 
			string m3_OVN9 = null, 
			string m3_OVNA = null, 
			string m3_MSF1 = null, 
			string m3_MSF2 = null, 
			string m3_MSF3 = null, 
			string m3_MSF4 = null, 
			string m3_MSF5 = null, 
			string m3_MSF6 = null, 
			string m3_MSF7 = null, 
			string m3_MSF8 = null, 
			string m3_MSF9 = null, 
			string m3_MSFA = null, 
			int? m3_RPBK = null, 
			string m3_COCO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddFields",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_IBCA))
				request.WithQueryParameter("IBCA", m3_IBCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MGRP))
				request.WithQueryParameter("MGRP", m3_MGRP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FILE))
				request.WithQueryParameter("FILE", m3_FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FIPX))
				request.WithQueryParameter("FIPX", m3_FIPX.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FDI1))
				request.WithQueryParameter("FDI1", m3_FDI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FDI2))
				request.WithQueryParameter("FDI2", m3_FDI2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FDI3))
				request.WithQueryParameter("FDI3", m3_FDI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FDI4))
				request.WithQueryParameter("FDI4", m3_FDI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FDI5))
				request.WithQueryParameter("FDI5", m3_FDI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FDI6))
				request.WithQueryParameter("FDI6", m3_FDI6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FDI7))
				request.WithQueryParameter("FDI7", m3_FDI7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FDI8))
				request.WithQueryParameter("FDI8", m3_FDI8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FDI9))
				request.WithQueryParameter("FDI9", m3_FDI9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FDIA))
				request.WithQueryParameter("FDIA", m3_FDIA.Trim());
			if (m3_FDB1.HasValue)
				request.WithQueryParameter("FDB1", m3_FDB1.Value.ToString());
			if (m3_FDB2.HasValue)
				request.WithQueryParameter("FDB2", m3_FDB2.Value.ToString());
			if (m3_FDB3.HasValue)
				request.WithQueryParameter("FDB3", m3_FDB3.Value.ToString());
			if (m3_FDB4.HasValue)
				request.WithQueryParameter("FDB4", m3_FDB4.Value.ToString());
			if (m3_FDB5.HasValue)
				request.WithQueryParameter("FDB5", m3_FDB5.Value.ToString());
			if (m3_FDB6.HasValue)
				request.WithQueryParameter("FDB6", m3_FDB6.Value.ToString());
			if (m3_FDB7.HasValue)
				request.WithQueryParameter("FDB7", m3_FDB7.Value.ToString());
			if (m3_FDB8.HasValue)
				request.WithQueryParameter("FDB8", m3_FDB8.Value.ToString());
			if (m3_FDB9.HasValue)
				request.WithQueryParameter("FDB9", m3_FDB9.Value.ToString());
			if (m3_FDBA.HasValue)
				request.WithQueryParameter("FDBA", m3_FDBA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OVM1))
				request.WithQueryParameter("OVM1", m3_OVM1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OVM2))
				request.WithQueryParameter("OVM2", m3_OVM2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OVM3))
				request.WithQueryParameter("OVM3", m3_OVM3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OVM4))
				request.WithQueryParameter("OVM4", m3_OVM4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OVM5))
				request.WithQueryParameter("OVM5", m3_OVM5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OVM6))
				request.WithQueryParameter("OVM6", m3_OVM6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OVM7))
				request.WithQueryParameter("OVM7", m3_OVM7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OVM8))
				request.WithQueryParameter("OVM8", m3_OVM8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OVM9))
				request.WithQueryParameter("OVM9", m3_OVM9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OVMA))
				request.WithQueryParameter("OVMA", m3_OVMA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OVN1))
				request.WithQueryParameter("OVN1", m3_OVN1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OVN2))
				request.WithQueryParameter("OVN2", m3_OVN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OVN3))
				request.WithQueryParameter("OVN3", m3_OVN3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OVN4))
				request.WithQueryParameter("OVN4", m3_OVN4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OVN5))
				request.WithQueryParameter("OVN5", m3_OVN5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OVN6))
				request.WithQueryParameter("OVN6", m3_OVN6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OVN7))
				request.WithQueryParameter("OVN7", m3_OVN7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OVN8))
				request.WithQueryParameter("OVN8", m3_OVN8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OVN9))
				request.WithQueryParameter("OVN9", m3_OVN9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OVNA))
				request.WithQueryParameter("OVNA", m3_OVNA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSF1))
				request.WithQueryParameter("MSF1", m3_MSF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSF2))
				request.WithQueryParameter("MSF2", m3_MSF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSF3))
				request.WithQueryParameter("MSF3", m3_MSF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSF4))
				request.WithQueryParameter("MSF4", m3_MSF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSF5))
				request.WithQueryParameter("MSF5", m3_MSF5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSF6))
				request.WithQueryParameter("MSF6", m3_MSF6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSF7))
				request.WithQueryParameter("MSF7", m3_MSF7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSF8))
				request.WithQueryParameter("MSF8", m3_MSF8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSF9))
				request.WithQueryParameter("MSF9", m3_MSF9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MSFA))
				request.WithQueryParameter("MSFA", m3_MSFA.Trim());
			if (m3_RPBK.HasValue)
				request.WithQueryParameter("RPBK", m3_RPBK.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_COCO))
				request.WithQueryParameter("COCO", m3_COCO.Trim());

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
		/// Name AddRelatedTable
		/// Description Add related table
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_IBCA">Information browser category (Required)</param>
		/// <param name="m3_FILE">File (Required)</param>
		/// <param name="m3_FIPX">Field prefix (Required)</param>
		/// <param name="m3_SOPT">Sorting option (Required)</param>
		/// <param name="m3_CETP">Connection type (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_OB01">Field</param>
		/// <param name="m3_OB02">Field</param>
		/// <param name="m3_OB03">Field</param>
		/// <param name="m3_OB04">Field</param>
		/// <param name="m3_OB05">Field</param>
		/// <param name="m3_OB06">Field</param>
		/// <param name="m3_OB07">Field</param>
		/// <param name="m3_OB08">Field</param>
		/// <param name="m3_OB09">Field</param>
		/// <param name="m3_OB10">Field</param>
		/// <param name="m3_OB11">Field</param>
		/// <param name="m3_OB12">Field</param>
		/// <param name="m3_OB13">Field</param>
		/// <param name="m3_OB14">Field</param>
		/// <param name="m3_OB15">Field</param>
		/// <param name="m3_OB16">Field</param>
		/// <param name="m3_VAL1">Value field</param>
		/// <param name="m3_VAL2">Value field</param>
		/// <param name="m3_VAL3">Value field</param>
		/// <param name="m3_VAL4">Value field</param>
		/// <param name="m3_VAL5">Value field</param>
		/// <param name="m3_VAL6">Value field</param>
		/// <param name="m3_VAL7">Value field</param>
		/// <param name="m3_VAL8">Value field</param>
		/// <param name="m3_VAL9">Value field</param>
		/// <param name="m3_VA10">Value field</param>
		/// <param name="m3_VA11">Value field</param>
		/// <param name="m3_VA12">Value field</param>
		/// <param name="m3_VA13">Value field</param>
		/// <param name="m3_VA14">Value field</param>
		/// <param name="m3_VA15">Value field</param>
		/// <param name="m3_VA16">Value field</param>
		/// <param name="m3_RO01">Read option</param>
		/// <param name="m3_RO02">Read option</param>
		/// <param name="m3_RO03">Read option</param>
		/// <param name="m3_RO04">Read option</param>
		/// <param name="m3_RO05">Read option</param>
		/// <param name="m3_RO06">Read option</param>
		/// <param name="m3_RO07">Read option</param>
		/// <param name="m3_RO08">Read option</param>
		/// <param name="m3_RO09">Read option</param>
		/// <param name="m3_RO10">Read option</param>
		/// <param name="m3_RO11">Read option</param>
		/// <param name="m3_RO12">Read option</param>
		/// <param name="m3_RO13">Read option</param>
		/// <param name="m3_RO14">Read option</param>
		/// <param name="m3_RO15">Read option</param>
		/// <param name="m3_RO16">Read option</param>
		/// <param name="m3_FI01">File</param>
		/// <param name="m3_FI02">File</param>
		/// <param name="m3_FI03">File</param>
		/// <param name="m3_FI04">File</param>
		/// <param name="m3_FI05">File</param>
		/// <param name="m3_FI06">File</param>
		/// <param name="m3_FI07">File</param>
		/// <param name="m3_FI08">File</param>
		/// <param name="m3_FI09">File</param>
		/// <param name="m3_FI10">File</param>
		/// <param name="m3_FI11">File</param>
		/// <param name="m3_FI12">File</param>
		/// <param name="m3_FI13">File</param>
		/// <param name="m3_FI14">File</param>
		/// <param name="m3_FI15">File</param>
		/// <param name="m3_FI16">File</param>
		/// <param name="m3_SNNO">Sequence number</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_RPBK">XML section</param>
		/// <param name="m3_COCO">Configuration component</param>
		/// <param name="m3_MAST">Master table</param>
		/// <param name="m3_TR01">Trim zeros</param>
		/// <param name="m3_TR02">Trim zeros</param>
		/// <param name="m3_TR03">Trim zeros</param>
		/// <param name="m3_TR04">Trim zeros</param>
		/// <param name="m3_TR05">Trim zeros</param>
		/// <param name="m3_TR06">Trim zeros</param>
		/// <param name="m3_TR07">Trim zeros</param>
		/// <param name="m3_TR08">Trim zeros</param>
		/// <param name="m3_TR09">Trim zeros</param>
		/// <param name="m3_TR10">Trim zeros</param>
		/// <param name="m3_TR11">Trim zeros</param>
		/// <param name="m3_TR12">Trim zeros</param>
		/// <param name="m3_TR13">Trim zeros</param>
		/// <param name="m3_TR14">Trim zeros</param>
		/// <param name="m3_TR15">Trim zeros</param>
		/// <param name="m3_TR16">Trim zeros</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddRelatedTable(
			string m3_IBCA, 
			string m3_FILE, 
			string m3_FIPX, 
			string m3_SOPT, 
			int m3_CETP, 
			string m3_TX40, 
			string m3_OB01 = null, 
			string m3_OB02 = null, 
			string m3_OB03 = null, 
			string m3_OB04 = null, 
			string m3_OB05 = null, 
			string m3_OB06 = null, 
			string m3_OB07 = null, 
			string m3_OB08 = null, 
			string m3_OB09 = null, 
			string m3_OB10 = null, 
			string m3_OB11 = null, 
			string m3_OB12 = null, 
			string m3_OB13 = null, 
			string m3_OB14 = null, 
			string m3_OB15 = null, 
			string m3_OB16 = null, 
			string m3_VAL1 = null, 
			string m3_VAL2 = null, 
			string m3_VAL3 = null, 
			string m3_VAL4 = null, 
			string m3_VAL5 = null, 
			string m3_VAL6 = null, 
			string m3_VAL7 = null, 
			string m3_VAL8 = null, 
			string m3_VAL9 = null, 
			string m3_VA10 = null, 
			string m3_VA11 = null, 
			string m3_VA12 = null, 
			string m3_VA13 = null, 
			string m3_VA14 = null, 
			string m3_VA15 = null, 
			string m3_VA16 = null, 
			int? m3_RO01 = null, 
			int? m3_RO02 = null, 
			int? m3_RO03 = null, 
			int? m3_RO04 = null, 
			int? m3_RO05 = null, 
			int? m3_RO06 = null, 
			int? m3_RO07 = null, 
			int? m3_RO08 = null, 
			int? m3_RO09 = null, 
			int? m3_RO10 = null, 
			int? m3_RO11 = null, 
			int? m3_RO12 = null, 
			int? m3_RO13 = null, 
			int? m3_RO14 = null, 
			int? m3_RO15 = null, 
			int? m3_RO16 = null, 
			string m3_FI01 = null, 
			string m3_FI02 = null, 
			string m3_FI03 = null, 
			string m3_FI04 = null, 
			string m3_FI05 = null, 
			string m3_FI06 = null, 
			string m3_FI07 = null, 
			string m3_FI08 = null, 
			string m3_FI09 = null, 
			string m3_FI10 = null, 
			string m3_FI11 = null, 
			string m3_FI12 = null, 
			string m3_FI13 = null, 
			string m3_FI14 = null, 
			string m3_FI15 = null, 
			string m3_FI16 = null, 
			int? m3_SNNO = null, 
			string m3_TX15 = null, 
			int? m3_RPBK = null, 
			string m3_COCO = null, 
			string m3_MAST = null, 
			int? m3_TR01 = null, 
			int? m3_TR02 = null, 
			int? m3_TR03 = null, 
			int? m3_TR04 = null, 
			int? m3_TR05 = null, 
			int? m3_TR06 = null, 
			int? m3_TR07 = null, 
			int? m3_TR08 = null, 
			int? m3_TR09 = null, 
			int? m3_TR10 = null, 
			int? m3_TR11 = null, 
			int? m3_TR12 = null, 
			int? m3_TR13 = null, 
			int? m3_TR14 = null, 
			int? m3_TR15 = null, 
			int? m3_TR16 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddRelatedTable",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IBCA))
				throw new ArgumentNullException("m3_IBCA");
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_FIPX))
				throw new ArgumentNullException("m3_FIPX");
			if (string.IsNullOrWhiteSpace(m3_SOPT))
				throw new ArgumentNullException("m3_SOPT");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3_IBCA.Trim())
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("FIPX", m3_FIPX.Trim())
				.WithQueryParameter("SOPT", m3_SOPT.Trim())
				.WithQueryParameter("CETP", m3_CETP.ToString())
				.WithQueryParameter("TX40", m3_TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OB01))
				request.WithQueryParameter("OB01", m3_OB01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB02))
				request.WithQueryParameter("OB02", m3_OB02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB03))
				request.WithQueryParameter("OB03", m3_OB03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB04))
				request.WithQueryParameter("OB04", m3_OB04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB05))
				request.WithQueryParameter("OB05", m3_OB05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB06))
				request.WithQueryParameter("OB06", m3_OB06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB07))
				request.WithQueryParameter("OB07", m3_OB07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB08))
				request.WithQueryParameter("OB08", m3_OB08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB09))
				request.WithQueryParameter("OB09", m3_OB09.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB10))
				request.WithQueryParameter("OB10", m3_OB10.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB11))
				request.WithQueryParameter("OB11", m3_OB11.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB12))
				request.WithQueryParameter("OB12", m3_OB12.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB13))
				request.WithQueryParameter("OB13", m3_OB13.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB14))
				request.WithQueryParameter("OB14", m3_OB14.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB15))
				request.WithQueryParameter("OB15", m3_OB15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB16))
				request.WithQueryParameter("OB16", m3_OB16.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL1))
				request.WithQueryParameter("VAL1", m3_VAL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL2))
				request.WithQueryParameter("VAL2", m3_VAL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL3))
				request.WithQueryParameter("VAL3", m3_VAL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL4))
				request.WithQueryParameter("VAL4", m3_VAL4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL5))
				request.WithQueryParameter("VAL5", m3_VAL5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL6))
				request.WithQueryParameter("VAL6", m3_VAL6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL7))
				request.WithQueryParameter("VAL7", m3_VAL7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL8))
				request.WithQueryParameter("VAL8", m3_VAL8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL9))
				request.WithQueryParameter("VAL9", m3_VAL9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VA10))
				request.WithQueryParameter("VA10", m3_VA10.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VA11))
				request.WithQueryParameter("VA11", m3_VA11.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VA12))
				request.WithQueryParameter("VA12", m3_VA12.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VA13))
				request.WithQueryParameter("VA13", m3_VA13.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VA14))
				request.WithQueryParameter("VA14", m3_VA14.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VA15))
				request.WithQueryParameter("VA15", m3_VA15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VA16))
				request.WithQueryParameter("VA16", m3_VA16.Trim());
			if (m3_RO01.HasValue)
				request.WithQueryParameter("RO01", m3_RO01.Value.ToString());
			if (m3_RO02.HasValue)
				request.WithQueryParameter("RO02", m3_RO02.Value.ToString());
			if (m3_RO03.HasValue)
				request.WithQueryParameter("RO03", m3_RO03.Value.ToString());
			if (m3_RO04.HasValue)
				request.WithQueryParameter("RO04", m3_RO04.Value.ToString());
			if (m3_RO05.HasValue)
				request.WithQueryParameter("RO05", m3_RO05.Value.ToString());
			if (m3_RO06.HasValue)
				request.WithQueryParameter("RO06", m3_RO06.Value.ToString());
			if (m3_RO07.HasValue)
				request.WithQueryParameter("RO07", m3_RO07.Value.ToString());
			if (m3_RO08.HasValue)
				request.WithQueryParameter("RO08", m3_RO08.Value.ToString());
			if (m3_RO09.HasValue)
				request.WithQueryParameter("RO09", m3_RO09.Value.ToString());
			if (m3_RO10.HasValue)
				request.WithQueryParameter("RO10", m3_RO10.Value.ToString());
			if (m3_RO11.HasValue)
				request.WithQueryParameter("RO11", m3_RO11.Value.ToString());
			if (m3_RO12.HasValue)
				request.WithQueryParameter("RO12", m3_RO12.Value.ToString());
			if (m3_RO13.HasValue)
				request.WithQueryParameter("RO13", m3_RO13.Value.ToString());
			if (m3_RO14.HasValue)
				request.WithQueryParameter("RO14", m3_RO14.Value.ToString());
			if (m3_RO15.HasValue)
				request.WithQueryParameter("RO15", m3_RO15.Value.ToString());
			if (m3_RO16.HasValue)
				request.WithQueryParameter("RO16", m3_RO16.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FI01))
				request.WithQueryParameter("FI01", m3_FI01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FI02))
				request.WithQueryParameter("FI02", m3_FI02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FI03))
				request.WithQueryParameter("FI03", m3_FI03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FI04))
				request.WithQueryParameter("FI04", m3_FI04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FI05))
				request.WithQueryParameter("FI05", m3_FI05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FI06))
				request.WithQueryParameter("FI06", m3_FI06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FI07))
				request.WithQueryParameter("FI07", m3_FI07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FI08))
				request.WithQueryParameter("FI08", m3_FI08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FI09))
				request.WithQueryParameter("FI09", m3_FI09.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FI10))
				request.WithQueryParameter("FI10", m3_FI10.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FI11))
				request.WithQueryParameter("FI11", m3_FI11.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FI12))
				request.WithQueryParameter("FI12", m3_FI12.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FI13))
				request.WithQueryParameter("FI13", m3_FI13.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FI14))
				request.WithQueryParameter("FI14", m3_FI14.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FI15))
				request.WithQueryParameter("FI15", m3_FI15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FI16))
				request.WithQueryParameter("FI16", m3_FI16.Trim());
			if (m3_SNNO.HasValue)
				request.WithQueryParameter("SNNO", m3_SNNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (m3_RPBK.HasValue)
				request.WithQueryParameter("RPBK", m3_RPBK.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_COCO))
				request.WithQueryParameter("COCO", m3_COCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MAST))
				request.WithQueryParameter("MAST", m3_MAST.Trim());
			if (m3_TR01.HasValue)
				request.WithQueryParameter("TR01", m3_TR01.Value.ToString());
			if (m3_TR02.HasValue)
				request.WithQueryParameter("TR02", m3_TR02.Value.ToString());
			if (m3_TR03.HasValue)
				request.WithQueryParameter("TR03", m3_TR03.Value.ToString());
			if (m3_TR04.HasValue)
				request.WithQueryParameter("TR04", m3_TR04.Value.ToString());
			if (m3_TR05.HasValue)
				request.WithQueryParameter("TR05", m3_TR05.Value.ToString());
			if (m3_TR06.HasValue)
				request.WithQueryParameter("TR06", m3_TR06.Value.ToString());
			if (m3_TR07.HasValue)
				request.WithQueryParameter("TR07", m3_TR07.Value.ToString());
			if (m3_TR08.HasValue)
				request.WithQueryParameter("TR08", m3_TR08.Value.ToString());
			if (m3_TR09.HasValue)
				request.WithQueryParameter("TR09", m3_TR09.Value.ToString());
			if (m3_TR10.HasValue)
				request.WithQueryParameter("TR10", m3_TR10.Value.ToString());
			if (m3_TR11.HasValue)
				request.WithQueryParameter("TR11", m3_TR11.Value.ToString());
			if (m3_TR12.HasValue)
				request.WithQueryParameter("TR12", m3_TR12.Value.ToString());
			if (m3_TR13.HasValue)
				request.WithQueryParameter("TR13", m3_TR13.Value.ToString());
			if (m3_TR14.HasValue)
				request.WithQueryParameter("TR14", m3_TR14.Value.ToString());
			if (m3_TR15.HasValue)
				request.WithQueryParameter("TR15", m3_TR15.Value.ToString());
			if (m3_TR16.HasValue)
				request.WithQueryParameter("TR16", m3_TR16.Value.ToString());

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
		/// Name DelRelatedTable
		/// Description Delete related table
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3_IBCA">Information browser category (Required)</param>
		/// <param name="m3_FILE">File (Required)</param>
		/// <param name="m3_FIPX">Field prefix (Required)</param>
		/// <param name="m3_RPBK">XML section</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelRelatedTable(
			string m3_IBCA, 
			string m3_FILE, 
			string m3_FIPX, 
			int? m3_RPBK = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelRelatedTable",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IBCA))
				throw new ArgumentNullException("m3_IBCA");
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_FIPX))
				throw new ArgumentNullException("m3_FIPX");

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3_IBCA.Trim())
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("FIPX", m3_FIPX.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RPBK.HasValue)
				request.WithQueryParameter("RPBK", m3_RPBK.Value.ToString());

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
		/// Name GetRelatedTable
		/// Description Get related table
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_IBCA">Information browser category (Required)</param>
		/// <param name="m3_FILE">File (Required)</param>
		/// <param name="m3_FIPX">Field prefix (Required)</param>
		/// <param name="m3_RPBK">XML section</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetRelatedTableResponse></returns>
		/// <exception cref="M3Exception<GetRelatedTableResponse>"></exception>
		public async Task<M3Response<GetRelatedTableResponse>> GetRelatedTable(
			string m3_IBCA, 
			string m3_FILE, 
			string m3_FIPX, 
			int? m3_RPBK = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetRelatedTable",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IBCA))
				throw new ArgumentNullException("m3_IBCA");
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_FIPX))
				throw new ArgumentNullException("m3_FIPX");

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3_IBCA.Trim())
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("FIPX", m3_FIPX.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RPBK.HasValue)
				request.WithQueryParameter("RPBK", m3_RPBK.Value.ToString());

			// Execute the request
			var result = await Execute<GetRelatedTableResponse>(
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
		/// Name LstRelatedTable
		/// Description List data for related table
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_IBCA">Information browser category (Required)</param>
		/// <param name="m3_FILE">File (Required)</param>
		/// <param name="m3_FIPX">Field prefix (Required)</param>
		/// <param name="m3_RPBK">XML section</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRelatedTableResponse></returns>
		/// <exception cref="M3Exception<LstRelatedTableResponse>"></exception>
		public async Task<M3Response<LstRelatedTableResponse>> LstRelatedTable(
			string m3_IBCA, 
			string m3_FILE, 
			string m3_FIPX, 
			int? m3_RPBK = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstRelatedTable",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IBCA))
				throw new ArgumentNullException("m3_IBCA");
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_FIPX))
				throw new ArgumentNullException("m3_FIPX");

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3_IBCA.Trim())
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("FIPX", m3_FIPX.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RPBK.HasValue)
				request.WithQueryParameter("RPBK", m3_RPBK.Value.ToString());

			// Execute the request
			var result = await Execute<LstRelatedTableResponse>(
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
		/// Name UpdRelatedTable
		/// Description Update related table
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_IBCA">Information browser category (Required)</param>
		/// <param name="m3_FILE">File (Required)</param>
		/// <param name="m3_FIPX">Field prefix (Required)</param>
		/// <param name="m3_OB01">Field</param>
		/// <param name="m3_OB02">Field</param>
		/// <param name="m3_OB03">Field</param>
		/// <param name="m3_OB04">Field</param>
		/// <param name="m3_OB05">Field</param>
		/// <param name="m3_OB06">Field</param>
		/// <param name="m3_OB07">Field</param>
		/// <param name="m3_OB08">Field</param>
		/// <param name="m3_OB09">Field</param>
		/// <param name="m3_OB10">Field</param>
		/// <param name="m3_OB11">Field</param>
		/// <param name="m3_OB12">Field</param>
		/// <param name="m3_OB13">Field</param>
		/// <param name="m3_OB14">Field</param>
		/// <param name="m3_OB15">Field</param>
		/// <param name="m3_OB16">Field</param>
		/// <param name="m3_VAL1">Value field</param>
		/// <param name="m3_VAL2">Value field</param>
		/// <param name="m3_VAL3">Value field</param>
		/// <param name="m3_VAL4">Value field</param>
		/// <param name="m3_VAL5">Value field</param>
		/// <param name="m3_VAL6">Value field</param>
		/// <param name="m3_VAL7">Value field</param>
		/// <param name="m3_VAL8">Value field</param>
		/// <param name="m3_VAL9">Value field</param>
		/// <param name="m3_VA10">Value field</param>
		/// <param name="m3_VA11">Value field</param>
		/// <param name="m3_VA12">Value field</param>
		/// <param name="m3_VA13">Value field</param>
		/// <param name="m3_VA14">Value field</param>
		/// <param name="m3_VA15">Value field</param>
		/// <param name="m3_VA16">Value field</param>
		/// <param name="m3_RO01">Read option</param>
		/// <param name="m3_RO02">Read option</param>
		/// <param name="m3_RO03">Read option</param>
		/// <param name="m3_RO04">Read option</param>
		/// <param name="m3_RO05">Read option</param>
		/// <param name="m3_RO06">Read option</param>
		/// <param name="m3_RO07">Read option</param>
		/// <param name="m3_RO08">Read option</param>
		/// <param name="m3_RO09">Read option</param>
		/// <param name="m3_RO10">Read option</param>
		/// <param name="m3_RO11">Read option</param>
		/// <param name="m3_RO12">Read option</param>
		/// <param name="m3_RO13">Read option</param>
		/// <param name="m3_RO14">Read option</param>
		/// <param name="m3_RO15">Read option</param>
		/// <param name="m3_RO16">Read option</param>
		/// <param name="m3_FI01">File</param>
		/// <param name="m3_FI02">File</param>
		/// <param name="m3_FI03">File</param>
		/// <param name="m3_FI04">File</param>
		/// <param name="m3_FI05">File</param>
		/// <param name="m3_FI06">File</param>
		/// <param name="m3_FI07">File</param>
		/// <param name="m3_FI08">File</param>
		/// <param name="m3_FI09">File</param>
		/// <param name="m3_FI10">File</param>
		/// <param name="m3_FI11">File</param>
		/// <param name="m3_FI12">File</param>
		/// <param name="m3_FI13">File</param>
		/// <param name="m3_FI14">File</param>
		/// <param name="m3_FI15">File</param>
		/// <param name="m3_FI16">File</param>
		/// <param name="m3_SNNO">Sequence number</param>
		/// <param name="m3_SOPT">Sorting option</param>
		/// <param name="m3_CETP">Connection type</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_RPBK">XML section</param>
		/// <param name="m3_TR01">Trim zeros</param>
		/// <param name="m3_TR02">Trim zeros</param>
		/// <param name="m3_TR03">Trim zeros</param>
		/// <param name="m3_TR04">Trim zeros</param>
		/// <param name="m3_TR05">Trim zeros</param>
		/// <param name="m3_TR06">Trim zeros</param>
		/// <param name="m3_TR07">Trim zeros</param>
		/// <param name="m3_TR08">Trim zeros</param>
		/// <param name="m3_TR09">Trim zeros</param>
		/// <param name="m3_TR10">Trim zeros</param>
		/// <param name="m3_TR11">Trim zeros</param>
		/// <param name="m3_TR12">Trim zeros</param>
		/// <param name="m3_TR13">Trim zeros</param>
		/// <param name="m3_TR14">Trim zeros</param>
		/// <param name="m3_TR15">Trim zeros</param>
		/// <param name="m3_TR16">Trim zeros</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdRelatedTable(
			string m3_IBCA, 
			string m3_FILE, 
			string m3_FIPX, 
			string m3_OB01 = null, 
			string m3_OB02 = null, 
			string m3_OB03 = null, 
			string m3_OB04 = null, 
			string m3_OB05 = null, 
			string m3_OB06 = null, 
			string m3_OB07 = null, 
			string m3_OB08 = null, 
			string m3_OB09 = null, 
			string m3_OB10 = null, 
			string m3_OB11 = null, 
			string m3_OB12 = null, 
			string m3_OB13 = null, 
			string m3_OB14 = null, 
			string m3_OB15 = null, 
			string m3_OB16 = null, 
			string m3_VAL1 = null, 
			string m3_VAL2 = null, 
			string m3_VAL3 = null, 
			string m3_VAL4 = null, 
			string m3_VAL5 = null, 
			string m3_VAL6 = null, 
			string m3_VAL7 = null, 
			string m3_VAL8 = null, 
			string m3_VAL9 = null, 
			string m3_VA10 = null, 
			string m3_VA11 = null, 
			string m3_VA12 = null, 
			string m3_VA13 = null, 
			string m3_VA14 = null, 
			string m3_VA15 = null, 
			string m3_VA16 = null, 
			int? m3_RO01 = null, 
			int? m3_RO02 = null, 
			int? m3_RO03 = null, 
			int? m3_RO04 = null, 
			int? m3_RO05 = null, 
			int? m3_RO06 = null, 
			int? m3_RO07 = null, 
			int? m3_RO08 = null, 
			int? m3_RO09 = null, 
			int? m3_RO10 = null, 
			int? m3_RO11 = null, 
			int? m3_RO12 = null, 
			int? m3_RO13 = null, 
			int? m3_RO14 = null, 
			int? m3_RO15 = null, 
			int? m3_RO16 = null, 
			string m3_FI01 = null, 
			string m3_FI02 = null, 
			string m3_FI03 = null, 
			string m3_FI04 = null, 
			string m3_FI05 = null, 
			string m3_FI06 = null, 
			string m3_FI07 = null, 
			string m3_FI08 = null, 
			string m3_FI09 = null, 
			string m3_FI10 = null, 
			string m3_FI11 = null, 
			string m3_FI12 = null, 
			string m3_FI13 = null, 
			string m3_FI14 = null, 
			string m3_FI15 = null, 
			string m3_FI16 = null, 
			int? m3_SNNO = null, 
			string m3_SOPT = null, 
			int? m3_CETP = null, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			int? m3_RPBK = null, 
			int? m3_TR01 = null, 
			int? m3_TR02 = null, 
			int? m3_TR03 = null, 
			int? m3_TR04 = null, 
			int? m3_TR05 = null, 
			int? m3_TR06 = null, 
			int? m3_TR07 = null, 
			int? m3_TR08 = null, 
			int? m3_TR09 = null, 
			int? m3_TR10 = null, 
			int? m3_TR11 = null, 
			int? m3_TR12 = null, 
			int? m3_TR13 = null, 
			int? m3_TR14 = null, 
			int? m3_TR15 = null, 
			int? m3_TR16 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdRelatedTable",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_IBCA))
				throw new ArgumentNullException("m3_IBCA");
			if (string.IsNullOrWhiteSpace(m3_FILE))
				throw new ArgumentNullException("m3_FILE");
			if (string.IsNullOrWhiteSpace(m3_FIPX))
				throw new ArgumentNullException("m3_FIPX");

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3_IBCA.Trim())
				.WithQueryParameter("FILE", m3_FILE.Trim())
				.WithQueryParameter("FIPX", m3_FIPX.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_OB01))
				request.WithQueryParameter("OB01", m3_OB01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB02))
				request.WithQueryParameter("OB02", m3_OB02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB03))
				request.WithQueryParameter("OB03", m3_OB03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB04))
				request.WithQueryParameter("OB04", m3_OB04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB05))
				request.WithQueryParameter("OB05", m3_OB05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB06))
				request.WithQueryParameter("OB06", m3_OB06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB07))
				request.WithQueryParameter("OB07", m3_OB07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB08))
				request.WithQueryParameter("OB08", m3_OB08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB09))
				request.WithQueryParameter("OB09", m3_OB09.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB10))
				request.WithQueryParameter("OB10", m3_OB10.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB11))
				request.WithQueryParameter("OB11", m3_OB11.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB12))
				request.WithQueryParameter("OB12", m3_OB12.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB13))
				request.WithQueryParameter("OB13", m3_OB13.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB14))
				request.WithQueryParameter("OB14", m3_OB14.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB15))
				request.WithQueryParameter("OB15", m3_OB15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OB16))
				request.WithQueryParameter("OB16", m3_OB16.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL1))
				request.WithQueryParameter("VAL1", m3_VAL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL2))
				request.WithQueryParameter("VAL2", m3_VAL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL3))
				request.WithQueryParameter("VAL3", m3_VAL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL4))
				request.WithQueryParameter("VAL4", m3_VAL4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL5))
				request.WithQueryParameter("VAL5", m3_VAL5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL6))
				request.WithQueryParameter("VAL6", m3_VAL6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL7))
				request.WithQueryParameter("VAL7", m3_VAL7.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL8))
				request.WithQueryParameter("VAL8", m3_VAL8.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VAL9))
				request.WithQueryParameter("VAL9", m3_VAL9.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VA10))
				request.WithQueryParameter("VA10", m3_VA10.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VA11))
				request.WithQueryParameter("VA11", m3_VA11.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VA12))
				request.WithQueryParameter("VA12", m3_VA12.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VA13))
				request.WithQueryParameter("VA13", m3_VA13.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VA14))
				request.WithQueryParameter("VA14", m3_VA14.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VA15))
				request.WithQueryParameter("VA15", m3_VA15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VA16))
				request.WithQueryParameter("VA16", m3_VA16.Trim());
			if (m3_RO01.HasValue)
				request.WithQueryParameter("RO01", m3_RO01.Value.ToString());
			if (m3_RO02.HasValue)
				request.WithQueryParameter("RO02", m3_RO02.Value.ToString());
			if (m3_RO03.HasValue)
				request.WithQueryParameter("RO03", m3_RO03.Value.ToString());
			if (m3_RO04.HasValue)
				request.WithQueryParameter("RO04", m3_RO04.Value.ToString());
			if (m3_RO05.HasValue)
				request.WithQueryParameter("RO05", m3_RO05.Value.ToString());
			if (m3_RO06.HasValue)
				request.WithQueryParameter("RO06", m3_RO06.Value.ToString());
			if (m3_RO07.HasValue)
				request.WithQueryParameter("RO07", m3_RO07.Value.ToString());
			if (m3_RO08.HasValue)
				request.WithQueryParameter("RO08", m3_RO08.Value.ToString());
			if (m3_RO09.HasValue)
				request.WithQueryParameter("RO09", m3_RO09.Value.ToString());
			if (m3_RO10.HasValue)
				request.WithQueryParameter("RO10", m3_RO10.Value.ToString());
			if (m3_RO11.HasValue)
				request.WithQueryParameter("RO11", m3_RO11.Value.ToString());
			if (m3_RO12.HasValue)
				request.WithQueryParameter("RO12", m3_RO12.Value.ToString());
			if (m3_RO13.HasValue)
				request.WithQueryParameter("RO13", m3_RO13.Value.ToString());
			if (m3_RO14.HasValue)
				request.WithQueryParameter("RO14", m3_RO14.Value.ToString());
			if (m3_RO15.HasValue)
				request.WithQueryParameter("RO15", m3_RO15.Value.ToString());
			if (m3_RO16.HasValue)
				request.WithQueryParameter("RO16", m3_RO16.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FI01))
				request.WithQueryParameter("FI01", m3_FI01.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FI02))
				request.WithQueryParameter("FI02", m3_FI02.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FI03))
				request.WithQueryParameter("FI03", m3_FI03.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FI04))
				request.WithQueryParameter("FI04", m3_FI04.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FI05))
				request.WithQueryParameter("FI05", m3_FI05.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FI06))
				request.WithQueryParameter("FI06", m3_FI06.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FI07))
				request.WithQueryParameter("FI07", m3_FI07.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FI08))
				request.WithQueryParameter("FI08", m3_FI08.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FI09))
				request.WithQueryParameter("FI09", m3_FI09.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FI10))
				request.WithQueryParameter("FI10", m3_FI10.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FI11))
				request.WithQueryParameter("FI11", m3_FI11.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FI12))
				request.WithQueryParameter("FI12", m3_FI12.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FI13))
				request.WithQueryParameter("FI13", m3_FI13.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FI14))
				request.WithQueryParameter("FI14", m3_FI14.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FI15))
				request.WithQueryParameter("FI15", m3_FI15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FI16))
				request.WithQueryParameter("FI16", m3_FI16.Trim());
			if (m3_SNNO.HasValue)
				request.WithQueryParameter("SNNO", m3_SNNO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SOPT))
				request.WithQueryParameter("SOPT", m3_SOPT.Trim());
			if (m3_CETP.HasValue)
				request.WithQueryParameter("CETP", m3_CETP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (m3_RPBK.HasValue)
				request.WithQueryParameter("RPBK", m3_RPBK.Value.ToString());
			if (m3_TR01.HasValue)
				request.WithQueryParameter("TR01", m3_TR01.Value.ToString());
			if (m3_TR02.HasValue)
				request.WithQueryParameter("TR02", m3_TR02.Value.ToString());
			if (m3_TR03.HasValue)
				request.WithQueryParameter("TR03", m3_TR03.Value.ToString());
			if (m3_TR04.HasValue)
				request.WithQueryParameter("TR04", m3_TR04.Value.ToString());
			if (m3_TR05.HasValue)
				request.WithQueryParameter("TR05", m3_TR05.Value.ToString());
			if (m3_TR06.HasValue)
				request.WithQueryParameter("TR06", m3_TR06.Value.ToString());
			if (m3_TR07.HasValue)
				request.WithQueryParameter("TR07", m3_TR07.Value.ToString());
			if (m3_TR08.HasValue)
				request.WithQueryParameter("TR08", m3_TR08.Value.ToString());
			if (m3_TR09.HasValue)
				request.WithQueryParameter("TR09", m3_TR09.Value.ToString());
			if (m3_TR10.HasValue)
				request.WithQueryParameter("TR10", m3_TR10.Value.ToString());
			if (m3_TR11.HasValue)
				request.WithQueryParameter("TR11", m3_TR11.Value.ToString());
			if (m3_TR12.HasValue)
				request.WithQueryParameter("TR12", m3_TR12.Value.ToString());
			if (m3_TR13.HasValue)
				request.WithQueryParameter("TR13", m3_TR13.Value.ToString());
			if (m3_TR14.HasValue)
				request.WithQueryParameter("TR14", m3_TR14.Value.ToString());
			if (m3_TR15.HasValue)
				request.WithQueryParameter("TR15", m3_TR15.Value.ToString());
			if (m3_TR16.HasValue)
				request.WithQueryParameter("TR16", m3_TR16.Value.ToString());

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
