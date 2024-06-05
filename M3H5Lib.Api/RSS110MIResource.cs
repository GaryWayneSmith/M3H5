/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.RSS110MI;
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
	/// Name: RSS110MI
	/// Component Name: CustomerDeliverySchedule
	/// Description: Customer delivery schedule interface
	/// Version Release: 13.1
	///</summary>
	public partial class RSS110MIResource : M3BaseResourceEndpoint
	{
		public RSS110MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "RSS110MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAddress
		/// Description Add Addresses
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_ODPN">Our delivery schedule number</param>
		/// <param name="m3_ODPI">Line number</param>
		/// <param name="m3_ADRT">Address type</param>
		/// <param name="m3_CDEA">Address coded</param>
		/// <param name="m3_E0QA">Code list qualifier</param>
		/// <param name="m3_CONM">Company name</param>
		/// <param name="m3_ADR1">Address line 1</param>
		/// <param name="m3_ADR2">Address line 2</param>
		/// <param name="m3_ADR3">Address line 3</param>
		/// <param name="m3_ADR4">Address line 4</param>
		/// <param name="m3_PONO">Postal code</param>
		/// <param name="m3_PHNO">Telephone number 1</param>
		/// <param name="m3_TFNO">Facsimile transmission number</param>
		/// <param name="m3_YREF">Your reference 1</param>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="m3_VRNO">VAT registration number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAddress(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_ODPN = null, 
			int? m3_ODPI = null, 
			int? m3_ADRT = null, 
			string m3_CDEA = null, 
			string m3_E0QA = null, 
			string m3_CONM = null, 
			string m3_ADR1 = null, 
			string m3_ADR2 = null, 
			string m3_ADR3 = null, 
			string m3_ADR4 = null, 
			string m3_PONO = null, 
			string m3_PHNO = null, 
			string m3_TFNO = null, 
			string m3_YREF = null, 
			string m3_CSCD = null, 
			string m3_VRNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddAddress",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ODPN))
				request.WithQueryParameter("ODPN", m3_ODPN.Trim());
			if (m3_ODPI.HasValue)
				request.WithQueryParameter("ODPI", m3_ODPI.Value.ToString());
			if (m3_ADRT.HasValue)
				request.WithQueryParameter("ADRT", m3_ADRT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CDEA))
				request.WithQueryParameter("CDEA", m3_CDEA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0QA))
				request.WithQueryParameter("E0QA", m3_E0QA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CONM))
				request.WithQueryParameter("CONM", m3_CONM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADR1))
				request.WithQueryParameter("ADR1", m3_ADR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADR2))
				request.WithQueryParameter("ADR2", m3_ADR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADR3))
				request.WithQueryParameter("ADR3", m3_ADR3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ADR4))
				request.WithQueryParameter("ADR4", m3_ADR4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PONO))
				request.WithQueryParameter("PONO", m3_PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PHNO))
				request.WithQueryParameter("PHNO", m3_PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFNO))
				request.WithQueryParameter("TFNO", m3_TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VRNO))
				request.WithQueryParameter("VRNO", m3_VRNO.Trim());

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
		/// Name AddCumQuantity
		/// Description Add Cumulative Quantity
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_ODPN">Our delivery schedule number</param>
		/// <param name="m3_ODPI">Line number</param>
		/// <param name="m3_CUMT">Cumulative type</param>
		/// <param name="m3_CQCF">Cumulative quantity</param>
		/// <param name="m3_CUMD">Cumulative calculation date</param>
		/// <param name="m3_CUFD">Cumulative from date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCumQuantity(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_ODPN = null, 
			int? m3_ODPI = null, 
			int? m3_CUMT = null, 
			decimal? m3_CQCF = null, 
			DateTime? m3_CUMD = null, 
			DateTime? m3_CUFD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddCumQuantity",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ODPN))
				request.WithQueryParameter("ODPN", m3_ODPN.Trim());
			if (m3_ODPI.HasValue)
				request.WithQueryParameter("ODPI", m3_ODPI.Value.ToString());
			if (m3_CUMT.HasValue)
				request.WithQueryParameter("CUMT", m3_CUMT.Value.ToString());
			if (m3_CQCF.HasValue)
				request.WithQueryParameter("CQCF", m3_CQCF.Value.ToString());
			if (m3_CUMD.HasValue)
				request.WithQueryParameter("CUMD", m3_CUMD.Value.ToM3String());
			if (m3_CUFD.HasValue)
				request.WithQueryParameter("CUFD", m3_CUFD.Value.ToM3String());

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
		/// Name AddDeliveryNote
		/// Description Add Delivery Note
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_ODPN">Our delivery schedule number</param>
		/// <param name="m3_ODPI">Line number</param>
		/// <param name="m3_DNNO">Delivery note number</param>
		/// <param name="m3_DNDT">Delivery note date</param>
		/// <param name="m3_DNTM">Delivery note time</param>
		/// <param name="m3_RCQT">Receipt quantity</param>
		/// <param name="m3_RCDT">Receipt date</param>
		/// <param name="m3_RCTM">Receipt time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddDeliveryNote(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_ODPN = null, 
			int? m3_ODPI = null, 
			string m3_DNNO = null, 
			DateTime? m3_DNDT = null, 
			int? m3_DNTM = null, 
			decimal? m3_RCQT = null, 
			DateTime? m3_RCDT = null, 
			int? m3_RCTM = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddDeliveryNote",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ODPN))
				request.WithQueryParameter("ODPN", m3_ODPN.Trim());
			if (m3_ODPI.HasValue)
				request.WithQueryParameter("ODPI", m3_ODPI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DNNO))
				request.WithQueryParameter("DNNO", m3_DNNO.Trim());
			if (m3_DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3_DNDT.Value.ToM3String());
			if (m3_DNTM.HasValue)
				request.WithQueryParameter("DNTM", m3_DNTM.Value.ToString());
			if (m3_RCQT.HasValue)
				request.WithQueryParameter("RCQT", m3_RCQT.Value.ToString());
			if (m3_RCDT.HasValue)
				request.WithQueryParameter("RCDT", m3_RCDT.Value.ToM3String());
			if (m3_RCTM.HasValue)
				request.WithQueryParameter("RCTM", m3_RCTM.Value.ToString());

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
		/// Name AddHeader
		/// Description Add Delivery Schedule Header
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_E0IO">Message direction</param>
		/// <param name="m3_DPNR">Delivery schedule</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_CHGD">Date changed</param>
		/// <param name="m3_E0PA">Partner</param>
		/// <param name="m3_E065">Message type</param>
		/// <param name="m3_E026">Application reference</param>
		/// <param name="m3_E068">Access reference</param>
		/// <param name="m3_E035">Test indicator</param>
		/// <param name="m3_E052">Message version</param>
		/// <param name="m3_E054">Message release</param>
		/// <param name="m3_E051">Controlling organization</param>
		/// <param name="m3_E057">Organization assigned code</param>
		/// <param name="m3_DPRF">Release frequency</param>
		/// <param name="m3_DONR">Document number</param>
		/// <param name="m3_EDFR">EDI reference</param>
		/// <param name="m3_EXDT">Start date</param>
		/// <param name="m3_EXTM">Start time</param>
		/// <param name="m3_ENDT">Finish date</param>
		/// <param name="m3_ENTM">End time</param>
		/// <param name="m3_DPMA">Delivery schedule origin</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_CUDT">Customer´s purchase order date</param>
		/// <param name="m3_RSAG">Delivery contract number</param>
		/// <param name="m3_RSAC">Update method</param>
		/// <param name="m3_DTTP">Date type</param>
		/// <param name="m3_CUPA">Customers packaging identity</param>
		/// <param name="m3_D1QT">Standard quantity (Replaced by D1Q2)</param>
		/// <param name="m3_PARE">Package reference</param>
		/// <param name="m3_AMKO">Number of packages</param>
		/// <param name="m3_NEWE">Net weight</param>
		/// <param name="m3_GRWE">Gross weight</param>
		/// <param name="m3_VOL3">Volume</param>
		/// <param name="m3_CROU">Customer route</param>
		/// <param name="m3_CCAR">Customer´s carrier name</param>
		/// <param name="m3_SHRF">Shipment reference</param>
		/// <param name="m3_INRC">Invoice recipient</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_FWNO">Forwarding agent</param>
		/// <param name="m3_D1Q2">Standard quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddHeaderResponse></returns>
		/// <exception cref="M3Exception<AddHeaderResponse>"></exception>
		public async Task<M3Response<AddHeaderResponse>> AddHeader(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_E0IO = null, 
			string m3_DPNR = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			DateTime? m3_CHGD = null, 
			string m3_E0PA = null, 
			string m3_E065 = null, 
			string m3_E026 = null, 
			string m3_E068 = null, 
			int? m3_E035 = null, 
			string m3_E052 = null, 
			string m3_E054 = null, 
			string m3_E051 = null, 
			string m3_E057 = null, 
			int? m3_DPRF = null, 
			string m3_DONR = null, 
			string m3_EDFR = null, 
			DateTime? m3_EXDT = null, 
			int? m3_EXTM = null, 
			DateTime? m3_ENDT = null, 
			int? m3_ENTM = null, 
			int? m3_DPMA = null, 
			string m3_CUOR = null, 
			DateTime? m3_CUDT = null, 
			string m3_RSAG = null, 
			int? m3_RSAC = null, 
			int? m3_DTTP = null, 
			string m3_CUPA = null, 
			decimal? m3_D1QT = null, 
			string m3_PARE = null, 
			int? m3_AMKO = null, 
			decimal? m3_NEWE = null, 
			decimal? m3_GRWE = null, 
			decimal? m3_VOL3 = null, 
			string m3_CROU = null, 
			string m3_CCAR = null, 
			string m3_SHRF = null, 
			string m3_INRC = null, 
			string m3_PYNO = null, 
			string m3_FWNO = null, 
			decimal? m3_D1Q2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddHeader",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0IO))
				request.WithQueryParameter("E0IO", m3_E0IO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DPNR))
				request.WithQueryParameter("DPNR", m3_DPNR.Trim());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (m3_CHGD.HasValue)
				request.WithQueryParameter("CHGD", m3_CHGD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_E0PA))
				request.WithQueryParameter("E0PA", m3_E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E065))
				request.WithQueryParameter("E065", m3_E065.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E026))
				request.WithQueryParameter("E026", m3_E026.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E068))
				request.WithQueryParameter("E068", m3_E068.Trim());
			if (m3_E035.HasValue)
				request.WithQueryParameter("E035", m3_E035.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_E052))
				request.WithQueryParameter("E052", m3_E052.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E054))
				request.WithQueryParameter("E054", m3_E054.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E051))
				request.WithQueryParameter("E051", m3_E051.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E057))
				request.WithQueryParameter("E057", m3_E057.Trim());
			if (m3_DPRF.HasValue)
				request.WithQueryParameter("DPRF", m3_DPRF.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DONR))
				request.WithQueryParameter("DONR", m3_DONR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDFR))
				request.WithQueryParameter("EDFR", m3_EDFR.Trim());
			if (m3_EXDT.HasValue)
				request.WithQueryParameter("EXDT", m3_EXDT.Value.ToM3String());
			if (m3_EXTM.HasValue)
				request.WithQueryParameter("EXTM", m3_EXTM.Value.ToString());
			if (m3_ENDT.HasValue)
				request.WithQueryParameter("ENDT", m3_ENDT.Value.ToM3String());
			if (m3_ENTM.HasValue)
				request.WithQueryParameter("ENTM", m3_ENTM.Value.ToString());
			if (m3_DPMA.HasValue)
				request.WithQueryParameter("DPMA", m3_DPMA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (m3_CUDT.HasValue)
				request.WithQueryParameter("CUDT", m3_CUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_RSAG))
				request.WithQueryParameter("RSAG", m3_RSAG.Trim());
			if (m3_RSAC.HasValue)
				request.WithQueryParameter("RSAC", m3_RSAC.Value.ToString());
			if (m3_DTTP.HasValue)
				request.WithQueryParameter("DTTP", m3_DTTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUPA))
				request.WithQueryParameter("CUPA", m3_CUPA.Trim());
			if (m3_D1QT.HasValue)
				request.WithQueryParameter("D1QT", m3_D1QT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PARE))
				request.WithQueryParameter("PARE", m3_PARE.Trim());
			if (m3_AMKO.HasValue)
				request.WithQueryParameter("AMKO", m3_AMKO.Value.ToString());
			if (m3_NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3_NEWE.Value.ToString());
			if (m3_GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3_GRWE.Value.ToString());
			if (m3_VOL3.HasValue)
				request.WithQueryParameter("VOL3", m3_VOL3.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CROU))
				request.WithQueryParameter("CROU", m3_CROU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CCAR))
				request.WithQueryParameter("CCAR", m3_CCAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SHRF))
				request.WithQueryParameter("SHRF", m3_SHRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INRC))
				request.WithQueryParameter("INRC", m3_INRC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FWNO))
				request.WithQueryParameter("FWNO", m3_FWNO.Trim());
			if (m3_D1Q2.HasValue)
				request.WithQueryParameter("D1Q2", m3_D1Q2.Value.ToString());

			// Execute the request
			var result = await Execute<AddHeaderResponse>(
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
		/// Name AddInstruction
		/// Description Add Delivery Schedule Instruction
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_ODPN">Our delivery schedule number</param>
		/// <param name="m3_ODPI">Line number</param>
		/// <param name="m3_RLDT">Requested delivery date</param>
		/// <param name="m3_RLTM">Requested delivery time</param>
		/// <param name="m3_DEMQ">Requested quantity</param>
		/// <param name="m3_RSIN">Delivery status indicator</param>
		/// <param name="m3_QTQL">Quantity qualifier</param>
		/// <param name="m3_INRA">Instruction reason</param>
		/// <param name="m3_INSA">Instruction activity code</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_CUDT">Customer´s purchase order date</param>
		/// <param name="m3_RSAG">Delivery contract number</param>
		/// <param name="m3_RSAC">Update method</param>
		/// <param name="m3_RTDT">Period to date</param>
		/// <param name="m3_RTTM">Period to time</param>
		/// <param name="m3_CQCF">Cumulative quantity</param>
		/// <param name="m3_PDSQ">Production sequence number</param>
		/// <param name="m3_RSKN">Kanban card number</param>
		/// <param name="m3_CHAS">Chassi number</param>
		/// <param name="m3_YREF">Your reference 1</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddInstructionResponse></returns>
		/// <exception cref="M3Exception<AddInstructionResponse>"></exception>
		public async Task<M3Response<AddInstructionResponse>> AddInstruction(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_ODPN = null, 
			int? m3_ODPI = null, 
			DateTime? m3_RLDT = null, 
			int? m3_RLTM = null, 
			decimal? m3_DEMQ = null, 
			int? m3_RSIN = null, 
			int? m3_QTQL = null, 
			int? m3_INRA = null, 
			int? m3_INSA = null, 
			string m3_CUOR = null, 
			DateTime? m3_CUDT = null, 
			string m3_RSAG = null, 
			int? m3_RSAC = null, 
			DateTime? m3_RTDT = null, 
			int? m3_RTTM = null, 
			decimal? m3_CQCF = null, 
			string m3_PDSQ = null, 
			string m3_RSKN = null, 
			string m3_CHAS = null, 
			string m3_YREF = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddInstruction",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ODPN))
				request.WithQueryParameter("ODPN", m3_ODPN.Trim());
			if (m3_ODPI.HasValue)
				request.WithQueryParameter("ODPI", m3_ODPI.Value.ToString());
			if (m3_RLDT.HasValue)
				request.WithQueryParameter("RLDT", m3_RLDT.Value.ToM3String());
			if (m3_RLTM.HasValue)
				request.WithQueryParameter("RLTM", m3_RLTM.Value.ToString());
			if (m3_DEMQ.HasValue)
				request.WithQueryParameter("DEMQ", m3_DEMQ.Value.ToString());
			if (m3_RSIN.HasValue)
				request.WithQueryParameter("RSIN", m3_RSIN.Value.ToString());
			if (m3_QTQL.HasValue)
				request.WithQueryParameter("QTQL", m3_QTQL.Value.ToString());
			if (m3_INRA.HasValue)
				request.WithQueryParameter("INRA", m3_INRA.Value.ToString());
			if (m3_INSA.HasValue)
				request.WithQueryParameter("INSA", m3_INSA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (m3_CUDT.HasValue)
				request.WithQueryParameter("CUDT", m3_CUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_RSAG))
				request.WithQueryParameter("RSAG", m3_RSAG.Trim());
			if (m3_RSAC.HasValue)
				request.WithQueryParameter("RSAC", m3_RSAC.Value.ToString());
			if (m3_RTDT.HasValue)
				request.WithQueryParameter("RTDT", m3_RTDT.Value.ToM3String());
			if (m3_RTTM.HasValue)
				request.WithQueryParameter("RTTM", m3_RTTM.Value.ToString());
			if (m3_CQCF.HasValue)
				request.WithQueryParameter("CQCF", m3_CQCF.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PDSQ))
				request.WithQueryParameter("PDSQ", m3_PDSQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSKN))
				request.WithQueryParameter("RSKN", m3_RSKN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHAS))
				request.WithQueryParameter("CHAS", m3_CHAS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());

			// Execute the request
			var result = await Execute<AddInstructionResponse>(
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
		/// Name AddItem
		/// Description Add Delivery Schedule Item
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_ODPN">Our delivery schedule number</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWT">Alias category</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_ITDS">Name</param>
		/// <param name="m3_UNIT">Unit of measure</param>
		/// <param name="m3_ORCO">Country of origin</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_CUDT">Customers purchase order date</param>
		/// <param name="m3_RSAG">Delivery contract number</param>
		/// <param name="m3_RSAC">Update method</param>
		/// <param name="m3_PUSN">Delivery note reference</param>
		/// <param name="m3_PUTP">Delivery note reference qualifier</param>
		/// <param name="m3_CFXX">Old CFIN</param>
		/// <param name="m3_DSLV">Delivery schedule level</param>
		/// <param name="m3_DTTP">Date type</param>
		/// <param name="m3_RSRN">Partner´s design revision number</param>
		/// <param name="m3_RSEC">Partner´s engineering change order no</param>
		/// <param name="m3_RSED">Engineering change order date</param>
		/// <param name="m3_RSPS">Previous delivery schedule number</param>
		/// <param name="m3_ITRL">Status - item release</param>
		/// <param name="m3_NEWE">Net weight</param>
		/// <param name="m3_GRWE">Gross weight</param>
		/// <param name="m3_VOL3">Volume</param>
		/// <param name="m3_CUPA">Customers packaging identity</param>
		/// <param name="m3_D1QT">Standard quantity (Replaced by D1Q2)</param>
		/// <param name="m3_PARE">Package reference</param>
		/// <param name="m3_AMKO">Number of packages</param>
		/// <param name="m3_CUMY">Customer´s model year</param>
		/// <param name="m3_SAPR">Sales price</param>
		/// <param name="m3_SACD">Sales price quantity</param>
		/// <param name="m3_CUCS">Currency - sales price</param>
		/// <param name="m3_SPUN">Sales price unit of measure</param>
		/// <param name="m3_EXPI">Expiration date</param>
		/// <param name="m3_CDLP">Customer´s delivery pattern</param>
		/// <param name="m3_RSK2">Customer´s internal kanban card number</param>
		/// <param name="m3_ECNM">EU number</param>
		/// <param name="m3_AUSD">Authorization firm to date</param>
		/// <param name="m3_AUST">Firm period qualifier</param>
		/// <param name="m3_AUSP">Firm periods</param>
		/// <param name="m3_AUFD">Authorization fabrication to date</param>
		/// <param name="m3_AUFT">Fabrication period qualifier</param>
		/// <param name="m3_AUFP">Fabrication periods</param>
		/// <param name="m3_AUMD">Authorization material to date</param>
		/// <param name="m3_AUMT">Material period qualifier</param>
		/// <param name="m3_AUMP">Material periods</param>
		/// <param name="m3_AUUD">Forecast to date</param>
		/// <param name="m3_AUUT">Forecast period qualifier</param>
		/// <param name="m3_AUUP">Forecast periods</param>
		/// <param name="m3_AUXD">Reference agreement to date</param>
		/// <param name="m3_AUXT">Total quantity reference agreement</param>
		/// <param name="m3_AUXP">Reference agreement period qualifier</param>
		/// <param name="m3_CDE1">Consolidate item demand - field 1</param>
		/// <param name="m3_CDE2">Consolidate item demand - field 2</param>
		/// <param name="m3_CDE3">Consolidate item demand - field 3</param>
		/// <param name="m3_MOYE">Model/year</param>
		/// <param name="m3_INRC">Invoice recipient</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_FWNO">Forwarding agent</param>
		/// <param name="m3_CFIN">Configuration number</param>
		/// <param name="m3_D1Q2">Standard quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddItemResponse></returns>
		/// <exception cref="M3Exception<AddItemResponse>"></exception>
		public async Task<M3Response<AddItemResponse>> AddItem(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_ODPN = null, 
			string m3_POPN = null, 
			int? m3_ALWT = null, 
			string m3_ALWQ = null, 
			string m3_ITNO = null, 
			string m3_ITDS = null, 
			string m3_UNIT = null, 
			string m3_ORCO = null, 
			string m3_WHLO = null, 
			string m3_FACI = null, 
			string m3_CUOR = null, 
			DateTime? m3_CUDT = null, 
			string m3_RSAG = null, 
			int? m3_RSAC = null, 
			string m3_PUSN = null, 
			int? m3_PUTP = null, 
			int? m3_CFXX = null, 
			int? m3_DSLV = null, 
			int? m3_DTTP = null, 
			string m3_RSRN = null, 
			string m3_RSEC = null, 
			DateTime? m3_RSED = null, 
			string m3_RSPS = null, 
			string m3_ITRL = null, 
			decimal? m3_NEWE = null, 
			decimal? m3_GRWE = null, 
			decimal? m3_VOL3 = null, 
			string m3_CUPA = null, 
			decimal? m3_D1QT = null, 
			string m3_PARE = null, 
			int? m3_AMKO = null, 
			string m3_CUMY = null, 
			decimal? m3_SAPR = null, 
			int? m3_SACD = null, 
			string m3_CUCS = null, 
			string m3_SPUN = null, 
			DateTime? m3_EXPI = null, 
			string m3_CDLP = null, 
			string m3_RSK2 = null, 
			string m3_ECNM = null, 
			DateTime? m3_AUSD = null, 
			int? m3_AUST = null, 
			int? m3_AUSP = null, 
			DateTime? m3_AUFD = null, 
			int? m3_AUFT = null, 
			int? m3_AUFP = null, 
			DateTime? m3_AUMD = null, 
			int? m3_AUMT = null, 
			int? m3_AUMP = null, 
			DateTime? m3_AUUD = null, 
			int? m3_AUUT = null, 
			int? m3_AUUP = null, 
			DateTime? m3_AUXD = null, 
			int? m3_AUXT = null, 
			int? m3_AUXP = null, 
			string m3_CDE1 = null, 
			string m3_CDE2 = null, 
			string m3_CDE3 = null, 
			string m3_MOYE = null, 
			string m3_INRC = null, 
			string m3_PYNO = null, 
			string m3_FWNO = null, 
			long? m3_CFIN = null, 
			decimal? m3_D1Q2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddItem",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ODPN))
				request.WithQueryParameter("ODPN", m3_ODPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UNIT))
				request.WithQueryParameter("UNIT", m3_UNIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORCO))
				request.WithQueryParameter("ORCO", m3_ORCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (m3_CUDT.HasValue)
				request.WithQueryParameter("CUDT", m3_CUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_RSAG))
				request.WithQueryParameter("RSAG", m3_RSAG.Trim());
			if (m3_RSAC.HasValue)
				request.WithQueryParameter("RSAC", m3_RSAC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PUSN))
				request.WithQueryParameter("PUSN", m3_PUSN.Trim());
			if (m3_PUTP.HasValue)
				request.WithQueryParameter("PUTP", m3_PUTP.Value.ToString());
			if (m3_CFXX.HasValue)
				request.WithQueryParameter("CFXX", m3_CFXX.Value.ToString());
			if (m3_DSLV.HasValue)
				request.WithQueryParameter("DSLV", m3_DSLV.Value.ToString());
			if (m3_DTTP.HasValue)
				request.WithQueryParameter("DTTP", m3_DTTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RSRN))
				request.WithQueryParameter("RSRN", m3_RSRN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSEC))
				request.WithQueryParameter("RSEC", m3_RSEC.Trim());
			if (m3_RSED.HasValue)
				request.WithQueryParameter("RSED", m3_RSED.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_RSPS))
				request.WithQueryParameter("RSPS", m3_RSPS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITRL))
				request.WithQueryParameter("ITRL", m3_ITRL.Trim());
			if (m3_NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3_NEWE.Value.ToString());
			if (m3_GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3_GRWE.Value.ToString());
			if (m3_VOL3.HasValue)
				request.WithQueryParameter("VOL3", m3_VOL3.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUPA))
				request.WithQueryParameter("CUPA", m3_CUPA.Trim());
			if (m3_D1QT.HasValue)
				request.WithQueryParameter("D1QT", m3_D1QT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PARE))
				request.WithQueryParameter("PARE", m3_PARE.Trim());
			if (m3_AMKO.HasValue)
				request.WithQueryParameter("AMKO", m3_AMKO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUMY))
				request.WithQueryParameter("CUMY", m3_CUMY.Trim());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (m3_SACD.HasValue)
				request.WithQueryParameter("SACD", m3_SACD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCS))
				request.WithQueryParameter("CUCS", m3_CUCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPUN))
				request.WithQueryParameter("SPUN", m3_SPUN.Trim());
			if (m3_EXPI.HasValue)
				request.WithQueryParameter("EXPI", m3_EXPI.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CDLP))
				request.WithQueryParameter("CDLP", m3_CDLP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSK2))
				request.WithQueryParameter("RSK2", m3_RSK2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECNM))
				request.WithQueryParameter("ECNM", m3_ECNM.Trim());
			if (m3_AUSD.HasValue)
				request.WithQueryParameter("AUSD", m3_AUSD.Value.ToM3String());
			if (m3_AUST.HasValue)
				request.WithQueryParameter("AUST", m3_AUST.Value.ToString());
			if (m3_AUSP.HasValue)
				request.WithQueryParameter("AUSP", m3_AUSP.Value.ToString());
			if (m3_AUFD.HasValue)
				request.WithQueryParameter("AUFD", m3_AUFD.Value.ToM3String());
			if (m3_AUFT.HasValue)
				request.WithQueryParameter("AUFT", m3_AUFT.Value.ToString());
			if (m3_AUFP.HasValue)
				request.WithQueryParameter("AUFP", m3_AUFP.Value.ToString());
			if (m3_AUMD.HasValue)
				request.WithQueryParameter("AUMD", m3_AUMD.Value.ToM3String());
			if (m3_AUMT.HasValue)
				request.WithQueryParameter("AUMT", m3_AUMT.Value.ToString());
			if (m3_AUMP.HasValue)
				request.WithQueryParameter("AUMP", m3_AUMP.Value.ToString());
			if (m3_AUUD.HasValue)
				request.WithQueryParameter("AUUD", m3_AUUD.Value.ToM3String());
			if (m3_AUUT.HasValue)
				request.WithQueryParameter("AUUT", m3_AUUT.Value.ToString());
			if (m3_AUUP.HasValue)
				request.WithQueryParameter("AUUP", m3_AUUP.Value.ToString());
			if (m3_AUXD.HasValue)
				request.WithQueryParameter("AUXD", m3_AUXD.Value.ToM3String());
			if (m3_AUXT.HasValue)
				request.WithQueryParameter("AUXT", m3_AUXT.Value.ToString());
			if (m3_AUXP.HasValue)
				request.WithQueryParameter("AUXP", m3_AUXP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CDE1))
				request.WithQueryParameter("CDE1", m3_CDE1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CDE2))
				request.WithQueryParameter("CDE2", m3_CDE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CDE3))
				request.WithQueryParameter("CDE3", m3_CDE3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MOYE))
				request.WithQueryParameter("MOYE", m3_MOYE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_INRC))
				request.WithQueryParameter("INRC", m3_INRC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FWNO))
				request.WithQueryParameter("FWNO", m3_FWNO.Trim());
			if (m3_CFIN.HasValue)
				request.WithQueryParameter("CFIN", m3_CFIN.Value.ToString());
			if (m3_D1Q2.HasValue)
				request.WithQueryParameter("D1Q2", m3_D1Q2.Value.ToString());

			// Execute the request
			var result = await Execute<AddItemResponse>(
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
		/// Name ExecuteSchedule
		/// Description Execute Delivery schedule
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_ODPN">Our delivery schedule number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ExecuteScheduleResponse></returns>
		/// <exception cref="M3Exception<ExecuteScheduleResponse>"></exception>
		public async Task<M3Response<ExecuteScheduleResponse>> ExecuteSchedule(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_ODPN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ExecuteSchedule",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ODPN))
				request.WithQueryParameter("ODPN", m3_ODPN.Trim());

			// Execute the request
			var result = await Execute<ExecuteScheduleResponse>(
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
		/// Name GetAddress
		/// Description Get Addresses
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_ODPN">Our delivery schedule number (Required)</param>
		/// <param name="m3_ODPI">Line number (Required)</param>
		/// <param name="m3_ADRT">Address type (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAddressResponse></returns>
		/// <exception cref="M3Exception<GetAddressResponse>"></exception>
		public async Task<M3Response<GetAddressResponse>> GetAddress(
			string m3_ODPN, 
			int m3_ODPI, 
			int m3_ADRT, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetAddress",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ODPN))
				throw new ArgumentNullException("m3_ODPN");

			// Set mandatory parameters
			request
				.WithQueryParameter("ODPN", m3_ODPN.Trim())
				.WithQueryParameter("ODPI", m3_ODPI.ToString())
				.WithQueryParameter("ADRT", m3_ADRT.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<GetAddressResponse>(
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
		/// Name GetCumQuantity
		/// Description Get Cumulative Quantity
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_ODPN">Our delivery schedule number</param>
		/// <param name="m3_ODPI">Line number</param>
		/// <param name="m3_CUMT">Cumulative type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCumQuantityResponse></returns>
		/// <exception cref="M3Exception<GetCumQuantityResponse>"></exception>
		public async Task<M3Response<GetCumQuantityResponse>> GetCumQuantity(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_ODPN = null, 
			int? m3_ODPI = null, 
			int? m3_CUMT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetCumQuantity",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ODPN))
				request.WithQueryParameter("ODPN", m3_ODPN.Trim());
			if (m3_ODPI.HasValue)
				request.WithQueryParameter("ODPI", m3_ODPI.Value.ToString());
			if (m3_CUMT.HasValue)
				request.WithQueryParameter("CUMT", m3_CUMT.Value.ToString());

			// Execute the request
			var result = await Execute<GetCumQuantityResponse>(
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
		/// Name GetDeliveryNote
		/// Description Get Delivery Note
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_ODPN">Our delivery schedule number</param>
		/// <param name="m3_ODPI">Line number</param>
		/// <param name="m3_DNNO">Delivery note number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDeliveryNoteResponse></returns>
		/// <exception cref="M3Exception<GetDeliveryNoteResponse>"></exception>
		public async Task<M3Response<GetDeliveryNoteResponse>> GetDeliveryNote(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_ODPN = null, 
			int? m3_ODPI = null, 
			string m3_DNNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetDeliveryNote",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ODPN))
				request.WithQueryParameter("ODPN", m3_ODPN.Trim());
			if (m3_ODPI.HasValue)
				request.WithQueryParameter("ODPI", m3_ODPI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DNNO))
				request.WithQueryParameter("DNNO", m3_DNNO.Trim());

			// Execute the request
			var result = await Execute<GetDeliveryNoteResponse>(
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
		/// Name GetHeader
		/// Description Get Delivery Schedule Header
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_E0IO">Message direction</param>
		/// <param name="m3_ODPN">Our delivery schedule number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeaderResponse></returns>
		/// <exception cref="M3Exception<GetHeaderResponse>"></exception>
		public async Task<M3Response<GetHeaderResponse>> GetHeader(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_E0IO = null, 
			string m3_ODPN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetHeader",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0IO))
				request.WithQueryParameter("E0IO", m3_E0IO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ODPN))
				request.WithQueryParameter("ODPN", m3_ODPN.Trim());

			// Execute the request
			var result = await Execute<GetHeaderResponse>(
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
		/// Name GetInstruction
		/// Description Get Delivery Schedule Instruction
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_ODPN">Our delivery schedule number</param>
		/// <param name="m3_ODPI">Line number</param>
		/// <param name="m3_ODPS">Line sequence</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetInstructionResponse></returns>
		/// <exception cref="M3Exception<GetInstructionResponse>"></exception>
		public async Task<M3Response<GetInstructionResponse>> GetInstruction(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_ODPN = null, 
			int? m3_ODPI = null, 
			int? m3_ODPS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetInstruction",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ODPN))
				request.WithQueryParameter("ODPN", m3_ODPN.Trim());
			if (m3_ODPI.HasValue)
				request.WithQueryParameter("ODPI", m3_ODPI.Value.ToString());
			if (m3_ODPS.HasValue)
				request.WithQueryParameter("ODPS", m3_ODPS.Value.ToString());

			// Execute the request
			var result = await Execute<GetInstructionResponse>(
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
		/// Name GetItem
		/// Description Get Delivery Schedule Item
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_ODPN">Our delivery schedule number</param>
		/// <param name="m3_ODPI">Line number</param>
		/// <param name="m3_E0IO">Message direction</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItemResponse></returns>
		/// <exception cref="M3Exception<GetItemResponse>"></exception>
		public async Task<M3Response<GetItemResponse>> GetItem(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_ODPN = null, 
			int? m3_ODPI = null, 
			string m3_E0IO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetItem",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ODPN))
				request.WithQueryParameter("ODPN", m3_ODPN.Trim());
			if (m3_ODPI.HasValue)
				request.WithQueryParameter("ODPI", m3_ODPI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_E0IO))
				request.WithQueryParameter("E0IO", m3_E0IO.Trim());

			// Execute the request
			var result = await Execute<GetItemResponse>(
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
		/// Name GetPartner
		/// Description Get Partner
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_PAAL">Partner alias</param>
		/// <param name="m3_PAA1">Partner alias 1</param>
		/// <param name="m3_PAA2">Partner alias 2</param>
		/// <param name="m3_PAAQ">Partner alias qualifier</param>
		/// <param name="m3_PAAC">Partner alias category</param>
		/// <param name="m3_QCTG">Qualifying partner category</param>
		/// <param name="m3_QPAI">Partner identity 1</param>
		/// <param name="m3_QPA1">Partner identity 2</param>
		/// <param name="m3_QPA2">Partner identity 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPartnerResponse></returns>
		/// <exception cref="M3Exception<GetPartnerResponse>"></exception>
		public async Task<M3Response<GetPartnerResponse>> GetPartner(
			int? m3_CONO = null, 
			string m3_PAAL = null, 
			string m3_PAA1 = null, 
			string m3_PAA2 = null, 
			string m3_PAAQ = null, 
			int? m3_PAAC = null, 
			int? m3_QCTG = null, 
			string m3_QPAI = null, 
			string m3_QPA1 = null, 
			string m3_QPA2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPartner",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PAAL))
				request.WithQueryParameter("PAAL", m3_PAAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAA1))
				request.WithQueryParameter("PAA1", m3_PAA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAA2))
				request.WithQueryParameter("PAA2", m3_PAA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PAAQ))
				request.WithQueryParameter("PAAQ", m3_PAAQ.Trim());
			if (m3_PAAC.HasValue)
				request.WithQueryParameter("PAAC", m3_PAAC.Value.ToString());
			if (m3_QCTG.HasValue)
				request.WithQueryParameter("QCTG", m3_QCTG.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_QPAI))
				request.WithQueryParameter("QPAI", m3_QPAI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QPA1))
				request.WithQueryParameter("QPA1", m3_QPA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_QPA2))
				request.WithQueryParameter("QPA2", m3_QPA2.Trim());

			// Execute the request
			var result = await Execute<GetPartnerResponse>(
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
		/// Name GetPartnerParms
		/// Description Get Partner Parameters
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_E0IO">Message direction</param>
		/// <param name="m3_E0PA">Partner</param>
		/// <param name="m3_E065">Message type</param>
		/// <param name="m3_E026">Application reference</param>
		/// <param name="m3_E068">Access reference</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPartnerParmsResponse></returns>
		/// <exception cref="M3Exception<GetPartnerParmsResponse>"></exception>
		public async Task<M3Response<GetPartnerParmsResponse>> GetPartnerParms(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_E0IO = null, 
			string m3_E0PA = null, 
			string m3_E065 = null, 
			string m3_E026 = null, 
			string m3_E068 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPartnerParms",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0IO))
				request.WithQueryParameter("E0IO", m3_E0IO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0PA))
				request.WithQueryParameter("E0PA", m3_E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E065))
				request.WithQueryParameter("E065", m3_E065.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E026))
				request.WithQueryParameter("E026", m3_E026.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E068))
				request.WithQueryParameter("E068", m3_E068.Trim());

			// Execute the request
			var result = await Execute<GetPartnerParmsResponse>(
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
		/// Name SetProcessing
		/// Description Set Processing
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_PROC">Mode (I=Interactive, B=Batch (default)) (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SetProcessing(
			string m3_PROC, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SetProcessing",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PROC))
				throw new ArgumentNullException("m3_PROC");

			// Set mandatory parameters
			request
				.WithQueryParameter("PROC", m3_PROC.Trim());

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
		/// Name SndInstruction
		/// Description Send Delivery Schedule Instruction (no response)
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_ODPN">Our delivery schedule number</param>
		/// <param name="m3_ODPI">Line number</param>
		/// <param name="m3_RLDT">Requested delivery date</param>
		/// <param name="m3_RLTM">Requested delivery time</param>
		/// <param name="m3_DEMQ">Requested quantity</param>
		/// <param name="m3_RSIN">Delivery status indicator</param>
		/// <param name="m3_QTQL">Quantity qualifier</param>
		/// <param name="m3_INRA">Instruction reason</param>
		/// <param name="m3_INSA">Instruction activity code</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_CUDT">Customer´s purchase order date</param>
		/// <param name="m3_RSAG">Delivery contract number</param>
		/// <param name="m3_RSAC">Update method</param>
		/// <param name="m3_RTDT">Period to date</param>
		/// <param name="m3_RTTM">Period to time</param>
		/// <param name="m3_CQCF">Cumulative quantity</param>
		/// <param name="m3_PDSQ">Production sequence number</param>
		/// <param name="m3_RSKN">Kanban card number</param>
		/// <param name="m3_CHAS">Chassi number</param>
		/// <param name="m3_YREF">Your reference 1</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndInstruction(
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_ODPN = null, 
			int? m3_ODPI = null, 
			DateTime? m3_RLDT = null, 
			int? m3_RLTM = null, 
			decimal? m3_DEMQ = null, 
			int? m3_RSIN = null, 
			int? m3_QTQL = null, 
			int? m3_INRA = null, 
			int? m3_INSA = null, 
			string m3_CUOR = null, 
			DateTime? m3_CUDT = null, 
			string m3_RSAG = null, 
			int? m3_RSAC = null, 
			DateTime? m3_RTDT = null, 
			int? m3_RTTM = null, 
			decimal? m3_CQCF = null, 
			string m3_PDSQ = null, 
			string m3_RSKN = null, 
			string m3_CHAS = null, 
			string m3_YREF = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndInstruction",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ODPN))
				request.WithQueryParameter("ODPN", m3_ODPN.Trim());
			if (m3_ODPI.HasValue)
				request.WithQueryParameter("ODPI", m3_ODPI.Value.ToString());
			if (m3_RLDT.HasValue)
				request.WithQueryParameter("RLDT", m3_RLDT.Value.ToM3String());
			if (m3_RLTM.HasValue)
				request.WithQueryParameter("RLTM", m3_RLTM.Value.ToString());
			if (m3_DEMQ.HasValue)
				request.WithQueryParameter("DEMQ", m3_DEMQ.Value.ToString());
			if (m3_RSIN.HasValue)
				request.WithQueryParameter("RSIN", m3_RSIN.Value.ToString());
			if (m3_QTQL.HasValue)
				request.WithQueryParameter("QTQL", m3_QTQL.Value.ToString());
			if (m3_INRA.HasValue)
				request.WithQueryParameter("INRA", m3_INRA.Value.ToString());
			if (m3_INSA.HasValue)
				request.WithQueryParameter("INSA", m3_INSA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (m3_CUDT.HasValue)
				request.WithQueryParameter("CUDT", m3_CUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_RSAG))
				request.WithQueryParameter("RSAG", m3_RSAG.Trim());
			if (m3_RSAC.HasValue)
				request.WithQueryParameter("RSAC", m3_RSAC.Value.ToString());
			if (m3_RTDT.HasValue)
				request.WithQueryParameter("RTDT", m3_RTDT.Value.ToM3String());
			if (m3_RTTM.HasValue)
				request.WithQueryParameter("RTTM", m3_RTTM.Value.ToString());
			if (m3_CQCF.HasValue)
				request.WithQueryParameter("CQCF", m3_CQCF.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PDSQ))
				request.WithQueryParameter("PDSQ", m3_PDSQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSKN))
				request.WithQueryParameter("RSKN", m3_RSKN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHAS))
				request.WithQueryParameter("CHAS", m3_CHAS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());

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
		/// Name SndTextLine
		/// Description Send Text Line (no response)
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_ODPN">Our delivery schedule number (Required)</param>
		/// <param name="m3_TXQA">Qualifier (H-Head, I-Item, O-Order) (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_ODPI">Line number</param>
		/// <param name="m3_TX60">Text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndTextLine(
			string m3_ODPN, 
			string m3_TXQA, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			int? m3_ODPI = null, 
			string m3_TX60 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/SndTextLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ODPN))
				throw new ArgumentNullException("m3_ODPN");
			if (string.IsNullOrWhiteSpace(m3_TXQA))
				throw new ArgumentNullException("m3_TXQA");

			// Set mandatory parameters
			request
				.WithQueryParameter("ODPN", m3_ODPN.Trim())
				.WithQueryParameter("TXQA", m3_TXQA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_ODPI.HasValue)
				request.WithQueryParameter("ODPI", m3_ODPI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX60))
				request.WithQueryParameter("TX60", m3_TX60.Trim());

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
		/// Name UpdHeader
		/// Description Update Delivery Schedule Header
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_E0IO">Message direction (Required)</param>
		/// <param name="m3_ODPN">Our delivery schedule number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_DPNR">Delivery schedule</param>
		/// <param name="m3_GEDT">Date generated</param>
		/// <param name="m3_GETM">Time generated</param>
		/// <param name="m3_CHGD">Date changed</param>
		/// <param name="m3_E0PA">Partner</param>
		/// <param name="m3_E065">Message type</param>
		/// <param name="m3_E026">Application reference</param>
		/// <param name="m3_E068">Access reference</param>
		/// <param name="m3_E035">Test indicator</param>
		/// <param name="m3_E052">Message version</param>
		/// <param name="m3_E054">Message release</param>
		/// <param name="m3_E051">Controlling organization</param>
		/// <param name="m3_E057">Organization assigned code</param>
		/// <param name="m3_DPRF">Release frequency</param>
		/// <param name="m3_DONR">Document number</param>
		/// <param name="m3_EDFR">EDI reference</param>
		/// <param name="m3_EXDT">Start date</param>
		/// <param name="m3_EXTM">Start time</param>
		/// <param name="m3_ENDT">Finish date</param>
		/// <param name="m3_ENTM">End time</param>
		/// <param name="m3_DPMA">Delivery schedule origin</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_CUDT">Customer´s purchase order date</param>
		/// <param name="m3_RSAG">Delivery contract number</param>
		/// <param name="m3_RSAC">Update method</param>
		/// <param name="m3_DTTP">Date type</param>
		/// <param name="m3_CUPA">Customers packaging identity</param>
		/// <param name="m3_D1QT">Standard quantity (Replaced by D1Q2)</param>
		/// <param name="m3_PARE">Package reference</param>
		/// <param name="m3_AMKO">Number of packages</param>
		/// <param name="m3_NEWE">Net weight</param>
		/// <param name="m3_GRWE">Gross weight</param>
		/// <param name="m3_VOL3">Volume</param>
		/// <param name="m3_CROU">Customer route</param>
		/// <param name="m3_CCAR">Customer´s carrier name</param>
		/// <param name="m3_SHRF">Shipment reference</param>
		/// <param name="m3_D1Q2">Standard quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdHeader(
			string m3_E0IO, 
			string m3_ODPN, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_DPNR = null, 
			DateTime? m3_GEDT = null, 
			int? m3_GETM = null, 
			DateTime? m3_CHGD = null, 
			string m3_E0PA = null, 
			string m3_E065 = null, 
			string m3_E026 = null, 
			string m3_E068 = null, 
			int? m3_E035 = null, 
			string m3_E052 = null, 
			string m3_E054 = null, 
			string m3_E051 = null, 
			string m3_E057 = null, 
			int? m3_DPRF = null, 
			string m3_DONR = null, 
			string m3_EDFR = null, 
			DateTime? m3_EXDT = null, 
			int? m3_EXTM = null, 
			DateTime? m3_ENDT = null, 
			int? m3_ENTM = null, 
			int? m3_DPMA = null, 
			string m3_CUOR = null, 
			DateTime? m3_CUDT = null, 
			string m3_RSAG = null, 
			int? m3_RSAC = null, 
			int? m3_DTTP = null, 
			string m3_CUPA = null, 
			decimal? m3_D1QT = null, 
			string m3_PARE = null, 
			int? m3_AMKO = null, 
			decimal? m3_NEWE = null, 
			decimal? m3_GRWE = null, 
			decimal? m3_VOL3 = null, 
			string m3_CROU = null, 
			string m3_CCAR = null, 
			string m3_SHRF = null, 
			decimal? m3_D1Q2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdHeader",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_E0IO))
				throw new ArgumentNullException("m3_E0IO");
			if (string.IsNullOrWhiteSpace(m3_ODPN))
				throw new ArgumentNullException("m3_ODPN");

			// Set mandatory parameters
			request
				.WithQueryParameter("E0IO", m3_E0IO.Trim())
				.WithQueryParameter("ODPN", m3_ODPN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DPNR))
				request.WithQueryParameter("DPNR", m3_DPNR.Trim());
			if (m3_GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3_GEDT.Value.ToM3String());
			if (m3_GETM.HasValue)
				request.WithQueryParameter("GETM", m3_GETM.Value.ToString());
			if (m3_CHGD.HasValue)
				request.WithQueryParameter("CHGD", m3_CHGD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_E0PA))
				request.WithQueryParameter("E0PA", m3_E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E065))
				request.WithQueryParameter("E065", m3_E065.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E026))
				request.WithQueryParameter("E026", m3_E026.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E068))
				request.WithQueryParameter("E068", m3_E068.Trim());
			if (m3_E035.HasValue)
				request.WithQueryParameter("E035", m3_E035.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_E052))
				request.WithQueryParameter("E052", m3_E052.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E054))
				request.WithQueryParameter("E054", m3_E054.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E051))
				request.WithQueryParameter("E051", m3_E051.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E057))
				request.WithQueryParameter("E057", m3_E057.Trim());
			if (m3_DPRF.HasValue)
				request.WithQueryParameter("DPRF", m3_DPRF.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DONR))
				request.WithQueryParameter("DONR", m3_DONR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EDFR))
				request.WithQueryParameter("EDFR", m3_EDFR.Trim());
			if (m3_EXDT.HasValue)
				request.WithQueryParameter("EXDT", m3_EXDT.Value.ToM3String());
			if (m3_EXTM.HasValue)
				request.WithQueryParameter("EXTM", m3_EXTM.Value.ToString());
			if (m3_ENDT.HasValue)
				request.WithQueryParameter("ENDT", m3_ENDT.Value.ToM3String());
			if (m3_ENTM.HasValue)
				request.WithQueryParameter("ENTM", m3_ENTM.Value.ToString());
			if (m3_DPMA.HasValue)
				request.WithQueryParameter("DPMA", m3_DPMA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (m3_CUDT.HasValue)
				request.WithQueryParameter("CUDT", m3_CUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_RSAG))
				request.WithQueryParameter("RSAG", m3_RSAG.Trim());
			if (m3_RSAC.HasValue)
				request.WithQueryParameter("RSAC", m3_RSAC.Value.ToString());
			if (m3_DTTP.HasValue)
				request.WithQueryParameter("DTTP", m3_DTTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUPA))
				request.WithQueryParameter("CUPA", m3_CUPA.Trim());
			if (m3_D1QT.HasValue)
				request.WithQueryParameter("D1QT", m3_D1QT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PARE))
				request.WithQueryParameter("PARE", m3_PARE.Trim());
			if (m3_AMKO.HasValue)
				request.WithQueryParameter("AMKO", m3_AMKO.Value.ToString());
			if (m3_NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3_NEWE.Value.ToString());
			if (m3_GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3_GRWE.Value.ToString());
			if (m3_VOL3.HasValue)
				request.WithQueryParameter("VOL3", m3_VOL3.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CROU))
				request.WithQueryParameter("CROU", m3_CROU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CCAR))
				request.WithQueryParameter("CCAR", m3_CCAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SHRF))
				request.WithQueryParameter("SHRF", m3_SHRF.Trim());
			if (m3_D1Q2.HasValue)
				request.WithQueryParameter("D1Q2", m3_D1Q2.Value.ToString());

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
		/// Name UpdInstruction
		/// Description Add Delivery Schedule Instruction
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_ODPN">Our delivery schedule number (Required)</param>
		/// <param name="m3_ODPI">Line number (Required)</param>
		/// <param name="m3_ODPS">Line sequence (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_RLDT">Requested delivery date</param>
		/// <param name="m3_RLTM">Requested delivery time</param>
		/// <param name="m3_DEMQ">Requested quantity</param>
		/// <param name="m3_RSIN">Delivery status indicator</param>
		/// <param name="m3_QTQL">Quantity qualifier</param>
		/// <param name="m3_INRA">Instruction reason</param>
		/// <param name="m3_INSA">Instruction activity code</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_CUDT">Customer´s purchase order date</param>
		/// <param name="m3_RSAG">Delivery contract number</param>
		/// <param name="m3_RSAC">Update method</param>
		/// <param name="m3_RTDT">Period to date</param>
		/// <param name="m3_RTTM">Period to time</param>
		/// <param name="m3_CQCF">Cumulative quantity</param>
		/// <param name="m3_PDSQ">Production sequence number</param>
		/// <param name="m3_RSKN">Kanban card number</param>
		/// <param name="m3_CHAS">Chassi number</param>
		/// <param name="m3_YREF">Your reference 1</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdInstruction(
			string m3_ODPN, 
			int m3_ODPI, 
			int m3_ODPS, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			DateTime? m3_RLDT = null, 
			int? m3_RLTM = null, 
			decimal? m3_DEMQ = null, 
			int? m3_RSIN = null, 
			int? m3_QTQL = null, 
			int? m3_INRA = null, 
			int? m3_INSA = null, 
			string m3_CUOR = null, 
			DateTime? m3_CUDT = null, 
			string m3_RSAG = null, 
			int? m3_RSAC = null, 
			DateTime? m3_RTDT = null, 
			int? m3_RTTM = null, 
			decimal? m3_CQCF = null, 
			string m3_PDSQ = null, 
			string m3_RSKN = null, 
			string m3_CHAS = null, 
			string m3_YREF = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdInstruction",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ODPN))
				throw new ArgumentNullException("m3_ODPN");

			// Set mandatory parameters
			request
				.WithQueryParameter("ODPN", m3_ODPN.Trim())
				.WithQueryParameter("ODPI", m3_ODPI.ToString())
				.WithQueryParameter("ODPS", m3_ODPS.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_RLDT.HasValue)
				request.WithQueryParameter("RLDT", m3_RLDT.Value.ToM3String());
			if (m3_RLTM.HasValue)
				request.WithQueryParameter("RLTM", m3_RLTM.Value.ToString());
			if (m3_DEMQ.HasValue)
				request.WithQueryParameter("DEMQ", m3_DEMQ.Value.ToString());
			if (m3_RSIN.HasValue)
				request.WithQueryParameter("RSIN", m3_RSIN.Value.ToString());
			if (m3_QTQL.HasValue)
				request.WithQueryParameter("QTQL", m3_QTQL.Value.ToString());
			if (m3_INRA.HasValue)
				request.WithQueryParameter("INRA", m3_INRA.Value.ToString());
			if (m3_INSA.HasValue)
				request.WithQueryParameter("INSA", m3_INSA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (m3_CUDT.HasValue)
				request.WithQueryParameter("CUDT", m3_CUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_RSAG))
				request.WithQueryParameter("RSAG", m3_RSAG.Trim());
			if (m3_RSAC.HasValue)
				request.WithQueryParameter("RSAC", m3_RSAC.Value.ToString());
			if (m3_RTDT.HasValue)
				request.WithQueryParameter("RTDT", m3_RTDT.Value.ToM3String());
			if (m3_RTTM.HasValue)
				request.WithQueryParameter("RTTM", m3_RTTM.Value.ToString());
			if (m3_CQCF.HasValue)
				request.WithQueryParameter("CQCF", m3_CQCF.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PDSQ))
				request.WithQueryParameter("PDSQ", m3_PDSQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSKN))
				request.WithQueryParameter("RSKN", m3_RSKN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CHAS))
				request.WithQueryParameter("CHAS", m3_CHAS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YREF))
				request.WithQueryParameter("YREF", m3_YREF.Trim());

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
		/// Name UpdItem
		/// Description Update Delivery Schedule Item
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3_ODPN">Our delivery schedule number (Required)</param>
		/// <param name="m3_ODPI">Line number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ALWT">Alias category</param>
		/// <param name="m3_ALWQ">Alias qualifier</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_ITDS">Name</param>
		/// <param name="m3_UNIT">Unit of measure</param>
		/// <param name="m3_ORCO">Country of origin</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_CUDT">Customer´s purchase order date</param>
		/// <param name="m3_RSAG">Delivery contract number</param>
		/// <param name="m3_RSAC">Update method</param>
		/// <param name="m3_PUSN">Delivery note reference</param>
		/// <param name="m3_PUTP">Delivery note reference qualifier</param>
		/// <param name="m3_CFXX">Old CFIN</param>
		/// <param name="m3_DSLV">Delivery schedule level</param>
		/// <param name="m3_DTTP">Date type</param>
		/// <param name="m3_RSRN">Partner´s design revision number</param>
		/// <param name="m3_RSEC">Partner´s engineering change order no</param>
		/// <param name="m3_RSED">Engineering change order date</param>
		/// <param name="m3_RSPS">Previous delivery schedule number</param>
		/// <param name="m3_ITRL">Status - item release</param>
		/// <param name="m3_NEWE">Net weight</param>
		/// <param name="m3_GRWE">Gross weight</param>
		/// <param name="m3_VOL3">Volume</param>
		/// <param name="m3_CUPA">Customers packaging identity</param>
		/// <param name="m3_D1QT">Standard quantity (Replaced by D1Q2)</param>
		/// <param name="m3_PARE">Package reference</param>
		/// <param name="m3_AMKO">Number of packages</param>
		/// <param name="m3_CUMY">Customer´s model year</param>
		/// <param name="m3_SAPR">Sales price</param>
		/// <param name="m3_SACD">Sales price quantity</param>
		/// <param name="m3_CUCS">Currency - sales price</param>
		/// <param name="m3_SPUN">Sales price unit of measure</param>
		/// <param name="m3_EXPI">Expiration date</param>
		/// <param name="m3_CDLP">Customer´s delivery pattern</param>
		/// <param name="m3_RSK2">Customer´s internal kanban card number</param>
		/// <param name="m3_ECNM">EU number</param>
		/// <param name="m3_AUSD">Authorization firm to date</param>
		/// <param name="m3_AUST">Firm period qualifier</param>
		/// <param name="m3_AUSP">Firm periods</param>
		/// <param name="m3_AUFD">Authorization fabrication to date</param>
		/// <param name="m3_AUFT">Fabrication period qualifier</param>
		/// <param name="m3_AUFP">Fabrication periods</param>
		/// <param name="m3_AUMD">Authorization material to date</param>
		/// <param name="m3_AUMT">Material period qualifier</param>
		/// <param name="m3_AUMP">Material periods</param>
		/// <param name="m3_AUUD">Forecast to date</param>
		/// <param name="m3_AUUT">Forecast period qualifier</param>
		/// <param name="m3_AUUP">Forecast periods</param>
		/// <param name="m3_AUXD">Reference agreement to date</param>
		/// <param name="m3_AUXT">Total quantity reference agreement</param>
		/// <param name="m3_AUXP">Reference agreement period qualifier</param>
		/// <param name="m3_CFIN">Configuration number</param>
		/// <param name="m3_D1Q2">Standard quantity</param>
		/// <param name="m3_MOYE">Model/Year</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdItem(
			string m3_ODPN, 
			int m3_ODPI, 
			int? m3_CONO = null, 
			string m3_DIVI = null, 
			string m3_POPN = null, 
			int? m3_ALWT = null, 
			string m3_ALWQ = null, 
			string m3_ITNO = null, 
			string m3_ITDS = null, 
			string m3_UNIT = null, 
			string m3_ORCO = null, 
			string m3_WHLO = null, 
			string m3_FACI = null, 
			string m3_CUOR = null, 
			DateTime? m3_CUDT = null, 
			string m3_RSAG = null, 
			int? m3_RSAC = null, 
			string m3_PUSN = null, 
			int? m3_PUTP = null, 
			int? m3_CFXX = null, 
			int? m3_DSLV = null, 
			int? m3_DTTP = null, 
			string m3_RSRN = null, 
			string m3_RSEC = null, 
			DateTime? m3_RSED = null, 
			string m3_RSPS = null, 
			string m3_ITRL = null, 
			decimal? m3_NEWE = null, 
			decimal? m3_GRWE = null, 
			decimal? m3_VOL3 = null, 
			string m3_CUPA = null, 
			decimal? m3_D1QT = null, 
			string m3_PARE = null, 
			int? m3_AMKO = null, 
			string m3_CUMY = null, 
			decimal? m3_SAPR = null, 
			int? m3_SACD = null, 
			string m3_CUCS = null, 
			string m3_SPUN = null, 
			DateTime? m3_EXPI = null, 
			string m3_CDLP = null, 
			string m3_RSK2 = null, 
			string m3_ECNM = null, 
			DateTime? m3_AUSD = null, 
			int? m3_AUST = null, 
			int? m3_AUSP = null, 
			DateTime? m3_AUFD = null, 
			int? m3_AUFT = null, 
			int? m3_AUFP = null, 
			DateTime? m3_AUMD = null, 
			int? m3_AUMT = null, 
			int? m3_AUMP = null, 
			DateTime? m3_AUUD = null, 
			int? m3_AUUT = null, 
			int? m3_AUUP = null, 
			DateTime? m3_AUXD = null, 
			int? m3_AUXT = null, 
			int? m3_AUXP = null, 
			long? m3_CFIN = null, 
			decimal? m3_D1Q2 = null, 
			string m3_MOYE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ODPN))
				throw new ArgumentNullException("m3_ODPN");

			// Set mandatory parameters
			request
				.WithQueryParameter("ODPN", m3_ODPN.Trim())
				.WithQueryParameter("ODPI", m3_ODPI.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (m3_ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3_ALWT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALWQ))
				request.WithQueryParameter("ALWQ", m3_ALWQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITDS))
				request.WithQueryParameter("ITDS", m3_ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_UNIT))
				request.WithQueryParameter("UNIT", m3_UNIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORCO))
				request.WithQueryParameter("ORCO", m3_ORCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (m3_CUDT.HasValue)
				request.WithQueryParameter("CUDT", m3_CUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_RSAG))
				request.WithQueryParameter("RSAG", m3_RSAG.Trim());
			if (m3_RSAC.HasValue)
				request.WithQueryParameter("RSAC", m3_RSAC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PUSN))
				request.WithQueryParameter("PUSN", m3_PUSN.Trim());
			if (m3_PUTP.HasValue)
				request.WithQueryParameter("PUTP", m3_PUTP.Value.ToString());
			if (m3_CFXX.HasValue)
				request.WithQueryParameter("CFXX", m3_CFXX.Value.ToString());
			if (m3_DSLV.HasValue)
				request.WithQueryParameter("DSLV", m3_DSLV.Value.ToString());
			if (m3_DTTP.HasValue)
				request.WithQueryParameter("DTTP", m3_DTTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RSRN))
				request.WithQueryParameter("RSRN", m3_RSRN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSEC))
				request.WithQueryParameter("RSEC", m3_RSEC.Trim());
			if (m3_RSED.HasValue)
				request.WithQueryParameter("RSED", m3_RSED.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_RSPS))
				request.WithQueryParameter("RSPS", m3_RSPS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITRL))
				request.WithQueryParameter("ITRL", m3_ITRL.Trim());
			if (m3_NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3_NEWE.Value.ToString());
			if (m3_GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3_GRWE.Value.ToString());
			if (m3_VOL3.HasValue)
				request.WithQueryParameter("VOL3", m3_VOL3.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUPA))
				request.WithQueryParameter("CUPA", m3_CUPA.Trim());
			if (m3_D1QT.HasValue)
				request.WithQueryParameter("D1QT", m3_D1QT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PARE))
				request.WithQueryParameter("PARE", m3_PARE.Trim());
			if (m3_AMKO.HasValue)
				request.WithQueryParameter("AMKO", m3_AMKO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUMY))
				request.WithQueryParameter("CUMY", m3_CUMY.Trim());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (m3_SACD.HasValue)
				request.WithQueryParameter("SACD", m3_SACD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CUCS))
				request.WithQueryParameter("CUCS", m3_CUCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPUN))
				request.WithQueryParameter("SPUN", m3_SPUN.Trim());
			if (m3_EXPI.HasValue)
				request.WithQueryParameter("EXPI", m3_EXPI.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CDLP))
				request.WithQueryParameter("CDLP", m3_CDLP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RSK2))
				request.WithQueryParameter("RSK2", m3_RSK2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECNM))
				request.WithQueryParameter("ECNM", m3_ECNM.Trim());
			if (m3_AUSD.HasValue)
				request.WithQueryParameter("AUSD", m3_AUSD.Value.ToM3String());
			if (m3_AUST.HasValue)
				request.WithQueryParameter("AUST", m3_AUST.Value.ToString());
			if (m3_AUSP.HasValue)
				request.WithQueryParameter("AUSP", m3_AUSP.Value.ToString());
			if (m3_AUFD.HasValue)
				request.WithQueryParameter("AUFD", m3_AUFD.Value.ToM3String());
			if (m3_AUFT.HasValue)
				request.WithQueryParameter("AUFT", m3_AUFT.Value.ToString());
			if (m3_AUFP.HasValue)
				request.WithQueryParameter("AUFP", m3_AUFP.Value.ToString());
			if (m3_AUMD.HasValue)
				request.WithQueryParameter("AUMD", m3_AUMD.Value.ToM3String());
			if (m3_AUMT.HasValue)
				request.WithQueryParameter("AUMT", m3_AUMT.Value.ToString());
			if (m3_AUMP.HasValue)
				request.WithQueryParameter("AUMP", m3_AUMP.Value.ToString());
			if (m3_AUUD.HasValue)
				request.WithQueryParameter("AUUD", m3_AUUD.Value.ToM3String());
			if (m3_AUUT.HasValue)
				request.WithQueryParameter("AUUT", m3_AUUT.Value.ToString());
			if (m3_AUUP.HasValue)
				request.WithQueryParameter("AUUP", m3_AUUP.Value.ToString());
			if (m3_AUXD.HasValue)
				request.WithQueryParameter("AUXD", m3_AUXD.Value.ToM3String());
			if (m3_AUXT.HasValue)
				request.WithQueryParameter("AUXT", m3_AUXT.Value.ToString());
			if (m3_AUXP.HasValue)
				request.WithQueryParameter("AUXP", m3_AUXP.Value.ToString());
			if (m3_CFIN.HasValue)
				request.WithQueryParameter("CFIN", m3_CFIN.Value.ToString());
			if (m3_D1Q2.HasValue)
				request.WithQueryParameter("D1Q2", m3_D1Q2.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_MOYE))
				request.WithQueryParameter("MOYE", m3_MOYE.Trim());

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
