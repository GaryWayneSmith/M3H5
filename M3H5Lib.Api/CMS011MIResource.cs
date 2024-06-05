/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3IBCA">Information browser category</param>
		/// <param name="m3MGRP">Field group</param>
		/// <param name="m3FILE">File</param>
		/// <param name="m3FIPX">Field prefix</param>
		/// <param name="m3FDI1">Field</param>
		/// <param name="m3FDI2">Field</param>
		/// <param name="m3FDI3">Field</param>
		/// <param name="m3FDI4">Field</param>
		/// <param name="m3FDI5">Field</param>
		/// <param name="m3FDI6">Field</param>
		/// <param name="m3FDI7">Field</param>
		/// <param name="m3FDI8">Field</param>
		/// <param name="m3FDI9">Field</param>
		/// <param name="m3FDIA">Field</param>
		/// <param name="m3FDB1">Field length</param>
		/// <param name="m3FDB2">Field length</param>
		/// <param name="m3FDB3">Field length</param>
		/// <param name="m3FDB4">Field length</param>
		/// <param name="m3FDB5">Field length</param>
		/// <param name="m3FDB6">Field length</param>
		/// <param name="m3FDB7">Field length</param>
		/// <param name="m3FDB8">Field length</param>
		/// <param name="m3FDB9">Field length</param>
		/// <param name="m3FDBA">Field length</param>
		/// <param name="m3OVM1">Overriding message ID</param>
		/// <param name="m3OVM2">Overriding message ID</param>
		/// <param name="m3OVM3">Overriding message ID</param>
		/// <param name="m3OVM4">Overriding message ID</param>
		/// <param name="m3OVM5">Overriding message ID</param>
		/// <param name="m3OVM6">Overriding message ID</param>
		/// <param name="m3OVM7">Overriding message ID</param>
		/// <param name="m3OVM8">Overriding message ID</param>
		/// <param name="m3OVM9">Overriding message ID</param>
		/// <param name="m3OVMA">Overriding message ID</param>
		/// <param name="m3OVN1">Overriding name</param>
		/// <param name="m3OVN2">Overriding name</param>
		/// <param name="m3OVN3">Overriding name</param>
		/// <param name="m3OVN4">Overriding name</param>
		/// <param name="m3OVN5">Overriding name</param>
		/// <param name="m3OVN6">Overriding name</param>
		/// <param name="m3OVN7">Overriding name</param>
		/// <param name="m3OVN8">Overriding name</param>
		/// <param name="m3OVN9">Overriding name</param>
		/// <param name="m3OVNA">Overriding name</param>
		/// <param name="m3MSF1">Message file</param>
		/// <param name="m3MSF2">Message file</param>
		/// <param name="m3MSF3">Message file</param>
		/// <param name="m3MSF4">Message file</param>
		/// <param name="m3MSF5">Message file</param>
		/// <param name="m3MSF6">Message file</param>
		/// <param name="m3MSF7">Message file</param>
		/// <param name="m3MSF8">Message file</param>
		/// <param name="m3MSF9">Message file</param>
		/// <param name="m3MSFA">Message file</param>
		/// <param name="m3RPBK">XML section</param>
		/// <param name="m3COCO">Configuration component</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddFields(
			string m3IBCA = null, 
			string m3MGRP = null, 
			string m3FILE = null, 
			string m3FIPX = null, 
			string m3FDI1 = null, 
			string m3FDI2 = null, 
			string m3FDI3 = null, 
			string m3FDI4 = null, 
			string m3FDI5 = null, 
			string m3FDI6 = null, 
			string m3FDI7 = null, 
			string m3FDI8 = null, 
			string m3FDI9 = null, 
			string m3FDIA = null, 
			int? m3FDB1 = null, 
			int? m3FDB2 = null, 
			int? m3FDB3 = null, 
			int? m3FDB4 = null, 
			int? m3FDB5 = null, 
			int? m3FDB6 = null, 
			int? m3FDB7 = null, 
			int? m3FDB8 = null, 
			int? m3FDB9 = null, 
			int? m3FDBA = null, 
			string m3OVM1 = null, 
			string m3OVM2 = null, 
			string m3OVM3 = null, 
			string m3OVM4 = null, 
			string m3OVM5 = null, 
			string m3OVM6 = null, 
			string m3OVM7 = null, 
			string m3OVM8 = null, 
			string m3OVM9 = null, 
			string m3OVMA = null, 
			string m3OVN1 = null, 
			string m3OVN2 = null, 
			string m3OVN3 = null, 
			string m3OVN4 = null, 
			string m3OVN5 = null, 
			string m3OVN6 = null, 
			string m3OVN7 = null, 
			string m3OVN8 = null, 
			string m3OVN9 = null, 
			string m3OVNA = null, 
			string m3MSF1 = null, 
			string m3MSF2 = null, 
			string m3MSF3 = null, 
			string m3MSF4 = null, 
			string m3MSF5 = null, 
			string m3MSF6 = null, 
			string m3MSF7 = null, 
			string m3MSF8 = null, 
			string m3MSF9 = null, 
			string m3MSFA = null, 
			int? m3RPBK = null, 
			string m3COCO = null, 
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
			if (!string.IsNullOrWhiteSpace(m3IBCA))
				request.WithQueryParameter("IBCA", m3IBCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3MGRP))
				request.WithQueryParameter("MGRP", m3MGRP.Trim());
			if (!string.IsNullOrWhiteSpace(m3FILE))
				request.WithQueryParameter("FILE", m3FILE.Trim());
			if (!string.IsNullOrWhiteSpace(m3FIPX))
				request.WithQueryParameter("FIPX", m3FIPX.Trim());
			if (!string.IsNullOrWhiteSpace(m3FDI1))
				request.WithQueryParameter("FDI1", m3FDI1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FDI2))
				request.WithQueryParameter("FDI2", m3FDI2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FDI3))
				request.WithQueryParameter("FDI3", m3FDI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3FDI4))
				request.WithQueryParameter("FDI4", m3FDI4.Trim());
			if (!string.IsNullOrWhiteSpace(m3FDI5))
				request.WithQueryParameter("FDI5", m3FDI5.Trim());
			if (!string.IsNullOrWhiteSpace(m3FDI6))
				request.WithQueryParameter("FDI6", m3FDI6.Trim());
			if (!string.IsNullOrWhiteSpace(m3FDI7))
				request.WithQueryParameter("FDI7", m3FDI7.Trim());
			if (!string.IsNullOrWhiteSpace(m3FDI8))
				request.WithQueryParameter("FDI8", m3FDI8.Trim());
			if (!string.IsNullOrWhiteSpace(m3FDI9))
				request.WithQueryParameter("FDI9", m3FDI9.Trim());
			if (!string.IsNullOrWhiteSpace(m3FDIA))
				request.WithQueryParameter("FDIA", m3FDIA.Trim());
			if (m3FDB1.HasValue)
				request.WithQueryParameter("FDB1", m3FDB1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FDB2.HasValue)
				request.WithQueryParameter("FDB2", m3FDB2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FDB3.HasValue)
				request.WithQueryParameter("FDB3", m3FDB3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FDB4.HasValue)
				request.WithQueryParameter("FDB4", m3FDB4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FDB5.HasValue)
				request.WithQueryParameter("FDB5", m3FDB5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FDB6.HasValue)
				request.WithQueryParameter("FDB6", m3FDB6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FDB7.HasValue)
				request.WithQueryParameter("FDB7", m3FDB7.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FDB8.HasValue)
				request.WithQueryParameter("FDB8", m3FDB8.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FDB9.HasValue)
				request.WithQueryParameter("FDB9", m3FDB9.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FDBA.HasValue)
				request.WithQueryParameter("FDBA", m3FDBA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OVM1))
				request.WithQueryParameter("OVM1", m3OVM1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OVM2))
				request.WithQueryParameter("OVM2", m3OVM2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OVM3))
				request.WithQueryParameter("OVM3", m3OVM3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OVM4))
				request.WithQueryParameter("OVM4", m3OVM4.Trim());
			if (!string.IsNullOrWhiteSpace(m3OVM5))
				request.WithQueryParameter("OVM5", m3OVM5.Trim());
			if (!string.IsNullOrWhiteSpace(m3OVM6))
				request.WithQueryParameter("OVM6", m3OVM6.Trim());
			if (!string.IsNullOrWhiteSpace(m3OVM7))
				request.WithQueryParameter("OVM7", m3OVM7.Trim());
			if (!string.IsNullOrWhiteSpace(m3OVM8))
				request.WithQueryParameter("OVM8", m3OVM8.Trim());
			if (!string.IsNullOrWhiteSpace(m3OVM9))
				request.WithQueryParameter("OVM9", m3OVM9.Trim());
			if (!string.IsNullOrWhiteSpace(m3OVMA))
				request.WithQueryParameter("OVMA", m3OVMA.Trim());
			if (!string.IsNullOrWhiteSpace(m3OVN1))
				request.WithQueryParameter("OVN1", m3OVN1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OVN2))
				request.WithQueryParameter("OVN2", m3OVN2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OVN3))
				request.WithQueryParameter("OVN3", m3OVN3.Trim());
			if (!string.IsNullOrWhiteSpace(m3OVN4))
				request.WithQueryParameter("OVN4", m3OVN4.Trim());
			if (!string.IsNullOrWhiteSpace(m3OVN5))
				request.WithQueryParameter("OVN5", m3OVN5.Trim());
			if (!string.IsNullOrWhiteSpace(m3OVN6))
				request.WithQueryParameter("OVN6", m3OVN6.Trim());
			if (!string.IsNullOrWhiteSpace(m3OVN7))
				request.WithQueryParameter("OVN7", m3OVN7.Trim());
			if (!string.IsNullOrWhiteSpace(m3OVN8))
				request.WithQueryParameter("OVN8", m3OVN8.Trim());
			if (!string.IsNullOrWhiteSpace(m3OVN9))
				request.WithQueryParameter("OVN9", m3OVN9.Trim());
			if (!string.IsNullOrWhiteSpace(m3OVNA))
				request.WithQueryParameter("OVNA", m3OVNA.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSF1))
				request.WithQueryParameter("MSF1", m3MSF1.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSF2))
				request.WithQueryParameter("MSF2", m3MSF2.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSF3))
				request.WithQueryParameter("MSF3", m3MSF3.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSF4))
				request.WithQueryParameter("MSF4", m3MSF4.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSF5))
				request.WithQueryParameter("MSF5", m3MSF5.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSF6))
				request.WithQueryParameter("MSF6", m3MSF6.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSF7))
				request.WithQueryParameter("MSF7", m3MSF7.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSF8))
				request.WithQueryParameter("MSF8", m3MSF8.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSF9))
				request.WithQueryParameter("MSF9", m3MSF9.Trim());
			if (!string.IsNullOrWhiteSpace(m3MSFA))
				request.WithQueryParameter("MSFA", m3MSFA.Trim());
			if (m3RPBK.HasValue)
				request.WithQueryParameter("RPBK", m3RPBK.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3COCO))
				request.WithQueryParameter("COCO", m3COCO.Trim());

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
		/// Name AddRelatedTable
		/// Description Add related table
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3IBCA">Information browser category (Required)</param>
		/// <param name="m3FILE">File (Required)</param>
		/// <param name="m3FIPX">Field prefix (Required)</param>
		/// <param name="m3SOPT">Sorting option (Required)</param>
		/// <param name="m3CETP">Connection type (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3OB01">Field</param>
		/// <param name="m3OB02">Field</param>
		/// <param name="m3OB03">Field</param>
		/// <param name="m3OB04">Field</param>
		/// <param name="m3OB05">Field</param>
		/// <param name="m3OB06">Field</param>
		/// <param name="m3OB07">Field</param>
		/// <param name="m3OB08">Field</param>
		/// <param name="m3OB09">Field</param>
		/// <param name="m3OB10">Field</param>
		/// <param name="m3OB11">Field</param>
		/// <param name="m3OB12">Field</param>
		/// <param name="m3OB13">Field</param>
		/// <param name="m3OB14">Field</param>
		/// <param name="m3OB15">Field</param>
		/// <param name="m3OB16">Field</param>
		/// <param name="m3VAL1">Value field</param>
		/// <param name="m3VAL2">Value field</param>
		/// <param name="m3VAL3">Value field</param>
		/// <param name="m3VAL4">Value field</param>
		/// <param name="m3VAL5">Value field</param>
		/// <param name="m3VAL6">Value field</param>
		/// <param name="m3VAL7">Value field</param>
		/// <param name="m3VAL8">Value field</param>
		/// <param name="m3VAL9">Value field</param>
		/// <param name="m3VA10">Value field</param>
		/// <param name="m3VA11">Value field</param>
		/// <param name="m3VA12">Value field</param>
		/// <param name="m3VA13">Value field</param>
		/// <param name="m3VA14">Value field</param>
		/// <param name="m3VA15">Value field</param>
		/// <param name="m3VA16">Value field</param>
		/// <param name="m3RO01">Read option</param>
		/// <param name="m3RO02">Read option</param>
		/// <param name="m3RO03">Read option</param>
		/// <param name="m3RO04">Read option</param>
		/// <param name="m3RO05">Read option</param>
		/// <param name="m3RO06">Read option</param>
		/// <param name="m3RO07">Read option</param>
		/// <param name="m3RO08">Read option</param>
		/// <param name="m3RO09">Read option</param>
		/// <param name="m3RO10">Read option</param>
		/// <param name="m3RO11">Read option</param>
		/// <param name="m3RO12">Read option</param>
		/// <param name="m3RO13">Read option</param>
		/// <param name="m3RO14">Read option</param>
		/// <param name="m3RO15">Read option</param>
		/// <param name="m3RO16">Read option</param>
		/// <param name="m3FI01">File</param>
		/// <param name="m3FI02">File</param>
		/// <param name="m3FI03">File</param>
		/// <param name="m3FI04">File</param>
		/// <param name="m3FI05">File</param>
		/// <param name="m3FI06">File</param>
		/// <param name="m3FI07">File</param>
		/// <param name="m3FI08">File</param>
		/// <param name="m3FI09">File</param>
		/// <param name="m3FI10">File</param>
		/// <param name="m3FI11">File</param>
		/// <param name="m3FI12">File</param>
		/// <param name="m3FI13">File</param>
		/// <param name="m3FI14">File</param>
		/// <param name="m3FI15">File</param>
		/// <param name="m3FI16">File</param>
		/// <param name="m3SNNO">Sequence number</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3RPBK">XML section</param>
		/// <param name="m3COCO">Configuration component</param>
		/// <param name="m3MAST">Master table</param>
		/// <param name="m3TR01">Trim zeros</param>
		/// <param name="m3TR02">Trim zeros</param>
		/// <param name="m3TR03">Trim zeros</param>
		/// <param name="m3TR04">Trim zeros</param>
		/// <param name="m3TR05">Trim zeros</param>
		/// <param name="m3TR06">Trim zeros</param>
		/// <param name="m3TR07">Trim zeros</param>
		/// <param name="m3TR08">Trim zeros</param>
		/// <param name="m3TR09">Trim zeros</param>
		/// <param name="m3TR10">Trim zeros</param>
		/// <param name="m3TR11">Trim zeros</param>
		/// <param name="m3TR12">Trim zeros</param>
		/// <param name="m3TR13">Trim zeros</param>
		/// <param name="m3TR14">Trim zeros</param>
		/// <param name="m3TR15">Trim zeros</param>
		/// <param name="m3TR16">Trim zeros</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddRelatedTable(
			string m3IBCA, 
			string m3FILE, 
			string m3FIPX, 
			string m3SOPT, 
			int m3CETP, 
			string m3TX40, 
			string m3OB01 = null, 
			string m3OB02 = null, 
			string m3OB03 = null, 
			string m3OB04 = null, 
			string m3OB05 = null, 
			string m3OB06 = null, 
			string m3OB07 = null, 
			string m3OB08 = null, 
			string m3OB09 = null, 
			string m3OB10 = null, 
			string m3OB11 = null, 
			string m3OB12 = null, 
			string m3OB13 = null, 
			string m3OB14 = null, 
			string m3OB15 = null, 
			string m3OB16 = null, 
			string m3VAL1 = null, 
			string m3VAL2 = null, 
			string m3VAL3 = null, 
			string m3VAL4 = null, 
			string m3VAL5 = null, 
			string m3VAL6 = null, 
			string m3VAL7 = null, 
			string m3VAL8 = null, 
			string m3VAL9 = null, 
			string m3VA10 = null, 
			string m3VA11 = null, 
			string m3VA12 = null, 
			string m3VA13 = null, 
			string m3VA14 = null, 
			string m3VA15 = null, 
			string m3VA16 = null, 
			int? m3RO01 = null, 
			int? m3RO02 = null, 
			int? m3RO03 = null, 
			int? m3RO04 = null, 
			int? m3RO05 = null, 
			int? m3RO06 = null, 
			int? m3RO07 = null, 
			int? m3RO08 = null, 
			int? m3RO09 = null, 
			int? m3RO10 = null, 
			int? m3RO11 = null, 
			int? m3RO12 = null, 
			int? m3RO13 = null, 
			int? m3RO14 = null, 
			int? m3RO15 = null, 
			int? m3RO16 = null, 
			string m3FI01 = null, 
			string m3FI02 = null, 
			string m3FI03 = null, 
			string m3FI04 = null, 
			string m3FI05 = null, 
			string m3FI06 = null, 
			string m3FI07 = null, 
			string m3FI08 = null, 
			string m3FI09 = null, 
			string m3FI10 = null, 
			string m3FI11 = null, 
			string m3FI12 = null, 
			string m3FI13 = null, 
			string m3FI14 = null, 
			string m3FI15 = null, 
			string m3FI16 = null, 
			int? m3SNNO = null, 
			string m3TX15 = null, 
			int? m3RPBK = null, 
			string m3COCO = null, 
			string m3MAST = null, 
			int? m3TR01 = null, 
			int? m3TR02 = null, 
			int? m3TR03 = null, 
			int? m3TR04 = null, 
			int? m3TR05 = null, 
			int? m3TR06 = null, 
			int? m3TR07 = null, 
			int? m3TR08 = null, 
			int? m3TR09 = null, 
			int? m3TR10 = null, 
			int? m3TR11 = null, 
			int? m3TR12 = null, 
			int? m3TR13 = null, 
			int? m3TR14 = null, 
			int? m3TR15 = null, 
			int? m3TR16 = null, 
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
			if (string.IsNullOrWhiteSpace(m3IBCA))
				throw new ArgumentNullException(nameof(m3IBCA));
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3FIPX))
				throw new ArgumentNullException(nameof(m3FIPX));
			if (string.IsNullOrWhiteSpace(m3SOPT))
				throw new ArgumentNullException(nameof(m3SOPT));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3IBCA.Trim())
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("FIPX", m3FIPX.Trim())
				.WithQueryParameter("SOPT", m3SOPT.Trim())
				.WithQueryParameter("CETP", m3CETP.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TX40", m3TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OB01))
				request.WithQueryParameter("OB01", m3OB01.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB02))
				request.WithQueryParameter("OB02", m3OB02.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB03))
				request.WithQueryParameter("OB03", m3OB03.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB04))
				request.WithQueryParameter("OB04", m3OB04.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB05))
				request.WithQueryParameter("OB05", m3OB05.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB06))
				request.WithQueryParameter("OB06", m3OB06.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB07))
				request.WithQueryParameter("OB07", m3OB07.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB08))
				request.WithQueryParameter("OB08", m3OB08.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB09))
				request.WithQueryParameter("OB09", m3OB09.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB10))
				request.WithQueryParameter("OB10", m3OB10.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB11))
				request.WithQueryParameter("OB11", m3OB11.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB12))
				request.WithQueryParameter("OB12", m3OB12.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB13))
				request.WithQueryParameter("OB13", m3OB13.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB14))
				request.WithQueryParameter("OB14", m3OB14.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB15))
				request.WithQueryParameter("OB15", m3OB15.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB16))
				request.WithQueryParameter("OB16", m3OB16.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL1))
				request.WithQueryParameter("VAL1", m3VAL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL2))
				request.WithQueryParameter("VAL2", m3VAL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL3))
				request.WithQueryParameter("VAL3", m3VAL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL4))
				request.WithQueryParameter("VAL4", m3VAL4.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL5))
				request.WithQueryParameter("VAL5", m3VAL5.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL6))
				request.WithQueryParameter("VAL6", m3VAL6.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL7))
				request.WithQueryParameter("VAL7", m3VAL7.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL8))
				request.WithQueryParameter("VAL8", m3VAL8.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL9))
				request.WithQueryParameter("VAL9", m3VAL9.Trim());
			if (!string.IsNullOrWhiteSpace(m3VA10))
				request.WithQueryParameter("VA10", m3VA10.Trim());
			if (!string.IsNullOrWhiteSpace(m3VA11))
				request.WithQueryParameter("VA11", m3VA11.Trim());
			if (!string.IsNullOrWhiteSpace(m3VA12))
				request.WithQueryParameter("VA12", m3VA12.Trim());
			if (!string.IsNullOrWhiteSpace(m3VA13))
				request.WithQueryParameter("VA13", m3VA13.Trim());
			if (!string.IsNullOrWhiteSpace(m3VA14))
				request.WithQueryParameter("VA14", m3VA14.Trim());
			if (!string.IsNullOrWhiteSpace(m3VA15))
				request.WithQueryParameter("VA15", m3VA15.Trim());
			if (!string.IsNullOrWhiteSpace(m3VA16))
				request.WithQueryParameter("VA16", m3VA16.Trim());
			if (m3RO01.HasValue)
				request.WithQueryParameter("RO01", m3RO01.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO02.HasValue)
				request.WithQueryParameter("RO02", m3RO02.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO03.HasValue)
				request.WithQueryParameter("RO03", m3RO03.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO04.HasValue)
				request.WithQueryParameter("RO04", m3RO04.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO05.HasValue)
				request.WithQueryParameter("RO05", m3RO05.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO06.HasValue)
				request.WithQueryParameter("RO06", m3RO06.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO07.HasValue)
				request.WithQueryParameter("RO07", m3RO07.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO08.HasValue)
				request.WithQueryParameter("RO08", m3RO08.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO09.HasValue)
				request.WithQueryParameter("RO09", m3RO09.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO10.HasValue)
				request.WithQueryParameter("RO10", m3RO10.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO11.HasValue)
				request.WithQueryParameter("RO11", m3RO11.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO12.HasValue)
				request.WithQueryParameter("RO12", m3RO12.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO13.HasValue)
				request.WithQueryParameter("RO13", m3RO13.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO14.HasValue)
				request.WithQueryParameter("RO14", m3RO14.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO15.HasValue)
				request.WithQueryParameter("RO15", m3RO15.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO16.HasValue)
				request.WithQueryParameter("RO16", m3RO16.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FI01))
				request.WithQueryParameter("FI01", m3FI01.Trim());
			if (!string.IsNullOrWhiteSpace(m3FI02))
				request.WithQueryParameter("FI02", m3FI02.Trim());
			if (!string.IsNullOrWhiteSpace(m3FI03))
				request.WithQueryParameter("FI03", m3FI03.Trim());
			if (!string.IsNullOrWhiteSpace(m3FI04))
				request.WithQueryParameter("FI04", m3FI04.Trim());
			if (!string.IsNullOrWhiteSpace(m3FI05))
				request.WithQueryParameter("FI05", m3FI05.Trim());
			if (!string.IsNullOrWhiteSpace(m3FI06))
				request.WithQueryParameter("FI06", m3FI06.Trim());
			if (!string.IsNullOrWhiteSpace(m3FI07))
				request.WithQueryParameter("FI07", m3FI07.Trim());
			if (!string.IsNullOrWhiteSpace(m3FI08))
				request.WithQueryParameter("FI08", m3FI08.Trim());
			if (!string.IsNullOrWhiteSpace(m3FI09))
				request.WithQueryParameter("FI09", m3FI09.Trim());
			if (!string.IsNullOrWhiteSpace(m3FI10))
				request.WithQueryParameter("FI10", m3FI10.Trim());
			if (!string.IsNullOrWhiteSpace(m3FI11))
				request.WithQueryParameter("FI11", m3FI11.Trim());
			if (!string.IsNullOrWhiteSpace(m3FI12))
				request.WithQueryParameter("FI12", m3FI12.Trim());
			if (!string.IsNullOrWhiteSpace(m3FI13))
				request.WithQueryParameter("FI13", m3FI13.Trim());
			if (!string.IsNullOrWhiteSpace(m3FI14))
				request.WithQueryParameter("FI14", m3FI14.Trim());
			if (!string.IsNullOrWhiteSpace(m3FI15))
				request.WithQueryParameter("FI15", m3FI15.Trim());
			if (!string.IsNullOrWhiteSpace(m3FI16))
				request.WithQueryParameter("FI16", m3FI16.Trim());
			if (m3SNNO.HasValue)
				request.WithQueryParameter("SNNO", m3SNNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (m3RPBK.HasValue)
				request.WithQueryParameter("RPBK", m3RPBK.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3COCO))
				request.WithQueryParameter("COCO", m3COCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3MAST))
				request.WithQueryParameter("MAST", m3MAST.Trim());
			if (m3TR01.HasValue)
				request.WithQueryParameter("TR01", m3TR01.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TR02.HasValue)
				request.WithQueryParameter("TR02", m3TR02.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TR03.HasValue)
				request.WithQueryParameter("TR03", m3TR03.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TR04.HasValue)
				request.WithQueryParameter("TR04", m3TR04.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TR05.HasValue)
				request.WithQueryParameter("TR05", m3TR05.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TR06.HasValue)
				request.WithQueryParameter("TR06", m3TR06.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TR07.HasValue)
				request.WithQueryParameter("TR07", m3TR07.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TR08.HasValue)
				request.WithQueryParameter("TR08", m3TR08.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TR09.HasValue)
				request.WithQueryParameter("TR09", m3TR09.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TR10.HasValue)
				request.WithQueryParameter("TR10", m3TR10.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TR11.HasValue)
				request.WithQueryParameter("TR11", m3TR11.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TR12.HasValue)
				request.WithQueryParameter("TR12", m3TR12.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TR13.HasValue)
				request.WithQueryParameter("TR13", m3TR13.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TR14.HasValue)
				request.WithQueryParameter("TR14", m3TR14.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TR15.HasValue)
				request.WithQueryParameter("TR15", m3TR15.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TR16.HasValue)
				request.WithQueryParameter("TR16", m3TR16.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelRelatedTable
		/// Description Delete related table
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3IBCA">Information browser category (Required)</param>
		/// <param name="m3FILE">File (Required)</param>
		/// <param name="m3FIPX">Field prefix (Required)</param>
		/// <param name="m3RPBK">XML section</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelRelatedTable(
			string m3IBCA, 
			string m3FILE, 
			string m3FIPX, 
			int? m3RPBK = null, 
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
			if (string.IsNullOrWhiteSpace(m3IBCA))
				throw new ArgumentNullException(nameof(m3IBCA));
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3FIPX))
				throw new ArgumentNullException(nameof(m3FIPX));

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3IBCA.Trim())
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("FIPX", m3FIPX.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3RPBK.HasValue)
				request.WithQueryParameter("RPBK", m3RPBK.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetRelatedTable
		/// Description Get related table
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3IBCA">Information browser category (Required)</param>
		/// <param name="m3FILE">File (Required)</param>
		/// <param name="m3FIPX">Field prefix (Required)</param>
		/// <param name="m3RPBK">XML section</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetRelatedTableResponse></returns>
		/// <exception cref="M3Exception<GetRelatedTableResponse>"></exception>
		public async Task<M3Response<GetRelatedTableResponse>> GetRelatedTable(
			string m3IBCA, 
			string m3FILE, 
			string m3FIPX, 
			int? m3RPBK = null, 
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
			if (string.IsNullOrWhiteSpace(m3IBCA))
				throw new ArgumentNullException(nameof(m3IBCA));
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3FIPX))
				throw new ArgumentNullException(nameof(m3FIPX));

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3IBCA.Trim())
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("FIPX", m3FIPX.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3RPBK.HasValue)
				request.WithQueryParameter("RPBK", m3RPBK.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetRelatedTableResponse>(
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
		/// Name LstRelatedTable
		/// Description List data for related table
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3IBCA">Information browser category (Required)</param>
		/// <param name="m3FILE">File (Required)</param>
		/// <param name="m3FIPX">Field prefix (Required)</param>
		/// <param name="m3RPBK">XML section</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRelatedTableResponse></returns>
		/// <exception cref="M3Exception<LstRelatedTableResponse>"></exception>
		public async Task<M3Response<LstRelatedTableResponse>> LstRelatedTable(
			string m3IBCA, 
			string m3FILE, 
			string m3FIPX, 
			int? m3RPBK = null, 
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
			if (string.IsNullOrWhiteSpace(m3IBCA))
				throw new ArgumentNullException(nameof(m3IBCA));
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3FIPX))
				throw new ArgumentNullException(nameof(m3FIPX));

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3IBCA.Trim())
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("FIPX", m3FIPX.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3RPBK.HasValue)
				request.WithQueryParameter("RPBK", m3RPBK.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstRelatedTableResponse>(
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
		/// Name UpdRelatedTable
		/// Description Update related table
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3IBCA">Information browser category (Required)</param>
		/// <param name="m3FILE">File (Required)</param>
		/// <param name="m3FIPX">Field prefix (Required)</param>
		/// <param name="m3OB01">Field</param>
		/// <param name="m3OB02">Field</param>
		/// <param name="m3OB03">Field</param>
		/// <param name="m3OB04">Field</param>
		/// <param name="m3OB05">Field</param>
		/// <param name="m3OB06">Field</param>
		/// <param name="m3OB07">Field</param>
		/// <param name="m3OB08">Field</param>
		/// <param name="m3OB09">Field</param>
		/// <param name="m3OB10">Field</param>
		/// <param name="m3OB11">Field</param>
		/// <param name="m3OB12">Field</param>
		/// <param name="m3OB13">Field</param>
		/// <param name="m3OB14">Field</param>
		/// <param name="m3OB15">Field</param>
		/// <param name="m3OB16">Field</param>
		/// <param name="m3VAL1">Value field</param>
		/// <param name="m3VAL2">Value field</param>
		/// <param name="m3VAL3">Value field</param>
		/// <param name="m3VAL4">Value field</param>
		/// <param name="m3VAL5">Value field</param>
		/// <param name="m3VAL6">Value field</param>
		/// <param name="m3VAL7">Value field</param>
		/// <param name="m3VAL8">Value field</param>
		/// <param name="m3VAL9">Value field</param>
		/// <param name="m3VA10">Value field</param>
		/// <param name="m3VA11">Value field</param>
		/// <param name="m3VA12">Value field</param>
		/// <param name="m3VA13">Value field</param>
		/// <param name="m3VA14">Value field</param>
		/// <param name="m3VA15">Value field</param>
		/// <param name="m3VA16">Value field</param>
		/// <param name="m3RO01">Read option</param>
		/// <param name="m3RO02">Read option</param>
		/// <param name="m3RO03">Read option</param>
		/// <param name="m3RO04">Read option</param>
		/// <param name="m3RO05">Read option</param>
		/// <param name="m3RO06">Read option</param>
		/// <param name="m3RO07">Read option</param>
		/// <param name="m3RO08">Read option</param>
		/// <param name="m3RO09">Read option</param>
		/// <param name="m3RO10">Read option</param>
		/// <param name="m3RO11">Read option</param>
		/// <param name="m3RO12">Read option</param>
		/// <param name="m3RO13">Read option</param>
		/// <param name="m3RO14">Read option</param>
		/// <param name="m3RO15">Read option</param>
		/// <param name="m3RO16">Read option</param>
		/// <param name="m3FI01">File</param>
		/// <param name="m3FI02">File</param>
		/// <param name="m3FI03">File</param>
		/// <param name="m3FI04">File</param>
		/// <param name="m3FI05">File</param>
		/// <param name="m3FI06">File</param>
		/// <param name="m3FI07">File</param>
		/// <param name="m3FI08">File</param>
		/// <param name="m3FI09">File</param>
		/// <param name="m3FI10">File</param>
		/// <param name="m3FI11">File</param>
		/// <param name="m3FI12">File</param>
		/// <param name="m3FI13">File</param>
		/// <param name="m3FI14">File</param>
		/// <param name="m3FI15">File</param>
		/// <param name="m3FI16">File</param>
		/// <param name="m3SNNO">Sequence number</param>
		/// <param name="m3SOPT">Sorting option</param>
		/// <param name="m3CETP">Connection type</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3RPBK">XML section</param>
		/// <param name="m3TR01">Trim zeros</param>
		/// <param name="m3TR02">Trim zeros</param>
		/// <param name="m3TR03">Trim zeros</param>
		/// <param name="m3TR04">Trim zeros</param>
		/// <param name="m3TR05">Trim zeros</param>
		/// <param name="m3TR06">Trim zeros</param>
		/// <param name="m3TR07">Trim zeros</param>
		/// <param name="m3TR08">Trim zeros</param>
		/// <param name="m3TR09">Trim zeros</param>
		/// <param name="m3TR10">Trim zeros</param>
		/// <param name="m3TR11">Trim zeros</param>
		/// <param name="m3TR12">Trim zeros</param>
		/// <param name="m3TR13">Trim zeros</param>
		/// <param name="m3TR14">Trim zeros</param>
		/// <param name="m3TR15">Trim zeros</param>
		/// <param name="m3TR16">Trim zeros</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdRelatedTable(
			string m3IBCA, 
			string m3FILE, 
			string m3FIPX, 
			string m3OB01 = null, 
			string m3OB02 = null, 
			string m3OB03 = null, 
			string m3OB04 = null, 
			string m3OB05 = null, 
			string m3OB06 = null, 
			string m3OB07 = null, 
			string m3OB08 = null, 
			string m3OB09 = null, 
			string m3OB10 = null, 
			string m3OB11 = null, 
			string m3OB12 = null, 
			string m3OB13 = null, 
			string m3OB14 = null, 
			string m3OB15 = null, 
			string m3OB16 = null, 
			string m3VAL1 = null, 
			string m3VAL2 = null, 
			string m3VAL3 = null, 
			string m3VAL4 = null, 
			string m3VAL5 = null, 
			string m3VAL6 = null, 
			string m3VAL7 = null, 
			string m3VAL8 = null, 
			string m3VAL9 = null, 
			string m3VA10 = null, 
			string m3VA11 = null, 
			string m3VA12 = null, 
			string m3VA13 = null, 
			string m3VA14 = null, 
			string m3VA15 = null, 
			string m3VA16 = null, 
			int? m3RO01 = null, 
			int? m3RO02 = null, 
			int? m3RO03 = null, 
			int? m3RO04 = null, 
			int? m3RO05 = null, 
			int? m3RO06 = null, 
			int? m3RO07 = null, 
			int? m3RO08 = null, 
			int? m3RO09 = null, 
			int? m3RO10 = null, 
			int? m3RO11 = null, 
			int? m3RO12 = null, 
			int? m3RO13 = null, 
			int? m3RO14 = null, 
			int? m3RO15 = null, 
			int? m3RO16 = null, 
			string m3FI01 = null, 
			string m3FI02 = null, 
			string m3FI03 = null, 
			string m3FI04 = null, 
			string m3FI05 = null, 
			string m3FI06 = null, 
			string m3FI07 = null, 
			string m3FI08 = null, 
			string m3FI09 = null, 
			string m3FI10 = null, 
			string m3FI11 = null, 
			string m3FI12 = null, 
			string m3FI13 = null, 
			string m3FI14 = null, 
			string m3FI15 = null, 
			string m3FI16 = null, 
			int? m3SNNO = null, 
			string m3SOPT = null, 
			int? m3CETP = null, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			int? m3RPBK = null, 
			int? m3TR01 = null, 
			int? m3TR02 = null, 
			int? m3TR03 = null, 
			int? m3TR04 = null, 
			int? m3TR05 = null, 
			int? m3TR06 = null, 
			int? m3TR07 = null, 
			int? m3TR08 = null, 
			int? m3TR09 = null, 
			int? m3TR10 = null, 
			int? m3TR11 = null, 
			int? m3TR12 = null, 
			int? m3TR13 = null, 
			int? m3TR14 = null, 
			int? m3TR15 = null, 
			int? m3TR16 = null, 
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
			if (string.IsNullOrWhiteSpace(m3IBCA))
				throw new ArgumentNullException(nameof(m3IBCA));
			if (string.IsNullOrWhiteSpace(m3FILE))
				throw new ArgumentNullException(nameof(m3FILE));
			if (string.IsNullOrWhiteSpace(m3FIPX))
				throw new ArgumentNullException(nameof(m3FIPX));

			// Set mandatory parameters
			request
				.WithQueryParameter("IBCA", m3IBCA.Trim())
				.WithQueryParameter("FILE", m3FILE.Trim())
				.WithQueryParameter("FIPX", m3FIPX.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3OB01))
				request.WithQueryParameter("OB01", m3OB01.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB02))
				request.WithQueryParameter("OB02", m3OB02.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB03))
				request.WithQueryParameter("OB03", m3OB03.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB04))
				request.WithQueryParameter("OB04", m3OB04.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB05))
				request.WithQueryParameter("OB05", m3OB05.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB06))
				request.WithQueryParameter("OB06", m3OB06.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB07))
				request.WithQueryParameter("OB07", m3OB07.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB08))
				request.WithQueryParameter("OB08", m3OB08.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB09))
				request.WithQueryParameter("OB09", m3OB09.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB10))
				request.WithQueryParameter("OB10", m3OB10.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB11))
				request.WithQueryParameter("OB11", m3OB11.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB12))
				request.WithQueryParameter("OB12", m3OB12.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB13))
				request.WithQueryParameter("OB13", m3OB13.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB14))
				request.WithQueryParameter("OB14", m3OB14.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB15))
				request.WithQueryParameter("OB15", m3OB15.Trim());
			if (!string.IsNullOrWhiteSpace(m3OB16))
				request.WithQueryParameter("OB16", m3OB16.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL1))
				request.WithQueryParameter("VAL1", m3VAL1.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL2))
				request.WithQueryParameter("VAL2", m3VAL2.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL3))
				request.WithQueryParameter("VAL3", m3VAL3.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL4))
				request.WithQueryParameter("VAL4", m3VAL4.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL5))
				request.WithQueryParameter("VAL5", m3VAL5.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL6))
				request.WithQueryParameter("VAL6", m3VAL6.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL7))
				request.WithQueryParameter("VAL7", m3VAL7.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL8))
				request.WithQueryParameter("VAL8", m3VAL8.Trim());
			if (!string.IsNullOrWhiteSpace(m3VAL9))
				request.WithQueryParameter("VAL9", m3VAL9.Trim());
			if (!string.IsNullOrWhiteSpace(m3VA10))
				request.WithQueryParameter("VA10", m3VA10.Trim());
			if (!string.IsNullOrWhiteSpace(m3VA11))
				request.WithQueryParameter("VA11", m3VA11.Trim());
			if (!string.IsNullOrWhiteSpace(m3VA12))
				request.WithQueryParameter("VA12", m3VA12.Trim());
			if (!string.IsNullOrWhiteSpace(m3VA13))
				request.WithQueryParameter("VA13", m3VA13.Trim());
			if (!string.IsNullOrWhiteSpace(m3VA14))
				request.WithQueryParameter("VA14", m3VA14.Trim());
			if (!string.IsNullOrWhiteSpace(m3VA15))
				request.WithQueryParameter("VA15", m3VA15.Trim());
			if (!string.IsNullOrWhiteSpace(m3VA16))
				request.WithQueryParameter("VA16", m3VA16.Trim());
			if (m3RO01.HasValue)
				request.WithQueryParameter("RO01", m3RO01.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO02.HasValue)
				request.WithQueryParameter("RO02", m3RO02.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO03.HasValue)
				request.WithQueryParameter("RO03", m3RO03.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO04.HasValue)
				request.WithQueryParameter("RO04", m3RO04.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO05.HasValue)
				request.WithQueryParameter("RO05", m3RO05.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO06.HasValue)
				request.WithQueryParameter("RO06", m3RO06.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO07.HasValue)
				request.WithQueryParameter("RO07", m3RO07.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO08.HasValue)
				request.WithQueryParameter("RO08", m3RO08.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO09.HasValue)
				request.WithQueryParameter("RO09", m3RO09.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO10.HasValue)
				request.WithQueryParameter("RO10", m3RO10.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO11.HasValue)
				request.WithQueryParameter("RO11", m3RO11.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO12.HasValue)
				request.WithQueryParameter("RO12", m3RO12.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO13.HasValue)
				request.WithQueryParameter("RO13", m3RO13.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO14.HasValue)
				request.WithQueryParameter("RO14", m3RO14.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO15.HasValue)
				request.WithQueryParameter("RO15", m3RO15.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RO16.HasValue)
				request.WithQueryParameter("RO16", m3RO16.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FI01))
				request.WithQueryParameter("FI01", m3FI01.Trim());
			if (!string.IsNullOrWhiteSpace(m3FI02))
				request.WithQueryParameter("FI02", m3FI02.Trim());
			if (!string.IsNullOrWhiteSpace(m3FI03))
				request.WithQueryParameter("FI03", m3FI03.Trim());
			if (!string.IsNullOrWhiteSpace(m3FI04))
				request.WithQueryParameter("FI04", m3FI04.Trim());
			if (!string.IsNullOrWhiteSpace(m3FI05))
				request.WithQueryParameter("FI05", m3FI05.Trim());
			if (!string.IsNullOrWhiteSpace(m3FI06))
				request.WithQueryParameter("FI06", m3FI06.Trim());
			if (!string.IsNullOrWhiteSpace(m3FI07))
				request.WithQueryParameter("FI07", m3FI07.Trim());
			if (!string.IsNullOrWhiteSpace(m3FI08))
				request.WithQueryParameter("FI08", m3FI08.Trim());
			if (!string.IsNullOrWhiteSpace(m3FI09))
				request.WithQueryParameter("FI09", m3FI09.Trim());
			if (!string.IsNullOrWhiteSpace(m3FI10))
				request.WithQueryParameter("FI10", m3FI10.Trim());
			if (!string.IsNullOrWhiteSpace(m3FI11))
				request.WithQueryParameter("FI11", m3FI11.Trim());
			if (!string.IsNullOrWhiteSpace(m3FI12))
				request.WithQueryParameter("FI12", m3FI12.Trim());
			if (!string.IsNullOrWhiteSpace(m3FI13))
				request.WithQueryParameter("FI13", m3FI13.Trim());
			if (!string.IsNullOrWhiteSpace(m3FI14))
				request.WithQueryParameter("FI14", m3FI14.Trim());
			if (!string.IsNullOrWhiteSpace(m3FI15))
				request.WithQueryParameter("FI15", m3FI15.Trim());
			if (!string.IsNullOrWhiteSpace(m3FI16))
				request.WithQueryParameter("FI16", m3FI16.Trim());
			if (m3SNNO.HasValue)
				request.WithQueryParameter("SNNO", m3SNNO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SOPT))
				request.WithQueryParameter("SOPT", m3SOPT.Trim());
			if (m3CETP.HasValue)
				request.WithQueryParameter("CETP", m3CETP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (m3RPBK.HasValue)
				request.WithQueryParameter("RPBK", m3RPBK.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TR01.HasValue)
				request.WithQueryParameter("TR01", m3TR01.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TR02.HasValue)
				request.WithQueryParameter("TR02", m3TR02.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TR03.HasValue)
				request.WithQueryParameter("TR03", m3TR03.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TR04.HasValue)
				request.WithQueryParameter("TR04", m3TR04.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TR05.HasValue)
				request.WithQueryParameter("TR05", m3TR05.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TR06.HasValue)
				request.WithQueryParameter("TR06", m3TR06.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TR07.HasValue)
				request.WithQueryParameter("TR07", m3TR07.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TR08.HasValue)
				request.WithQueryParameter("TR08", m3TR08.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TR09.HasValue)
				request.WithQueryParameter("TR09", m3TR09.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TR10.HasValue)
				request.WithQueryParameter("TR10", m3TR10.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TR11.HasValue)
				request.WithQueryParameter("TR11", m3TR11.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TR12.HasValue)
				request.WithQueryParameter("TR12", m3TR12.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TR13.HasValue)
				request.WithQueryParameter("TR13", m3TR13.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TR14.HasValue)
				request.WithQueryParameter("TR14", m3TR14.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TR15.HasValue)
				request.WithQueryParameter("TR15", m3TR15.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TR16.HasValue)
				request.WithQueryParameter("TR16", m3TR16.Value.ToString(CultureInfo.CurrentCulture));

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
