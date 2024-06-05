/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAddress
		/// Description Add Addresses
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3ODPN">Our delivery schedule number</param>
		/// <param name="m3ODPI">Line number</param>
		/// <param name="m3ADRT">Address type</param>
		/// <param name="m3CDEA">Address coded</param>
		/// <param name="m3E0QA">Code list qualifier</param>
		/// <param name="m3CONM">Company name</param>
		/// <param name="m3ADR1">Address line 1</param>
		/// <param name="m3ADR2">Address line 2</param>
		/// <param name="m3ADR3">Address line 3</param>
		/// <param name="m3ADR4">Address line 4</param>
		/// <param name="m3PONO">Postal code</param>
		/// <param name="m3PHNO">Telephone number 1</param>
		/// <param name="m3TFNO">Facsimile transmission number</param>
		/// <param name="m3YREF">Your reference 1</param>
		/// <param name="m3CSCD">Country</param>
		/// <param name="m3VRNO">VAT registration number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAddress(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3ODPN = null, 
			int? m3ODPI = null, 
			int? m3ADRT = null, 
			string m3CDEA = null, 
			string m3E0QA = null, 
			string m3CONM = null, 
			string m3ADR1 = null, 
			string m3ADR2 = null, 
			string m3ADR3 = null, 
			string m3ADR4 = null, 
			string m3PONO = null, 
			string m3PHNO = null, 
			string m3TFNO = null, 
			string m3YREF = null, 
			string m3CSCD = null, 
			string m3VRNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddAddress",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ODPN))
				request.WithQueryParameter("ODPN", m3ODPN.Trim());
			if (m3ODPI.HasValue)
				request.WithQueryParameter("ODPI", m3ODPI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ADRT.HasValue)
				request.WithQueryParameter("ADRT", m3ADRT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CDEA))
				request.WithQueryParameter("CDEA", m3CDEA.Trim());
			if (!string.IsNullOrWhiteSpace(m3E0QA))
				request.WithQueryParameter("E0QA", m3E0QA.Trim());
			if (!string.IsNullOrWhiteSpace(m3CONM))
				request.WithQueryParameter("CONM", m3CONM.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADR1))
				request.WithQueryParameter("ADR1", m3ADR1.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADR2))
				request.WithQueryParameter("ADR2", m3ADR2.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADR3))
				request.WithQueryParameter("ADR3", m3ADR3.Trim());
			if (!string.IsNullOrWhiteSpace(m3ADR4))
				request.WithQueryParameter("ADR4", m3ADR4.Trim());
			if (!string.IsNullOrWhiteSpace(m3PONO))
				request.WithQueryParameter("PONO", m3PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PHNO))
				request.WithQueryParameter("PHNO", m3PHNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFNO))
				request.WithQueryParameter("TFNO", m3TFNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3VRNO))
				request.WithQueryParameter("VRNO", m3VRNO.Trim());

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
		/// Name AddCumQuantity
		/// Description Add Cumulative Quantity
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3ODPN">Our delivery schedule number</param>
		/// <param name="m3ODPI">Line number</param>
		/// <param name="m3CUMT">Cumulative type</param>
		/// <param name="m3CQCF">Cumulative quantity</param>
		/// <param name="m3CUMD">Cumulative calculation date</param>
		/// <param name="m3CUFD">Cumulative from date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCumQuantity(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3ODPN = null, 
			int? m3ODPI = null, 
			int? m3CUMT = null, 
			decimal? m3CQCF = null, 
			DateTime? m3CUMD = null, 
			DateTime? m3CUFD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddCumQuantity",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ODPN))
				request.WithQueryParameter("ODPN", m3ODPN.Trim());
			if (m3ODPI.HasValue)
				request.WithQueryParameter("ODPI", m3ODPI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CUMT.HasValue)
				request.WithQueryParameter("CUMT", m3CUMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CQCF.HasValue)
				request.WithQueryParameter("CQCF", m3CQCF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CUMD.HasValue)
				request.WithQueryParameter("CUMD", m3CUMD.Value.ToM3String());
			if (m3CUFD.HasValue)
				request.WithQueryParameter("CUFD", m3CUFD.Value.ToM3String());

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
		/// Name AddDeliveryNote
		/// Description Add Delivery Note
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3ODPN">Our delivery schedule number</param>
		/// <param name="m3ODPI">Line number</param>
		/// <param name="m3DNNO">Delivery note number</param>
		/// <param name="m3DNDT">Delivery note date</param>
		/// <param name="m3DNTM">Delivery note time</param>
		/// <param name="m3RCQT">Receipt quantity</param>
		/// <param name="m3RCDT">Receipt date</param>
		/// <param name="m3RCTM">Receipt time</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddDeliveryNote(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3ODPN = null, 
			int? m3ODPI = null, 
			string m3DNNO = null, 
			DateTime? m3DNDT = null, 
			int? m3DNTM = null, 
			decimal? m3RCQT = null, 
			DateTime? m3RCDT = null, 
			int? m3RCTM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddDeliveryNote",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ODPN))
				request.WithQueryParameter("ODPN", m3ODPN.Trim());
			if (m3ODPI.HasValue)
				request.WithQueryParameter("ODPI", m3ODPI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DNNO))
				request.WithQueryParameter("DNNO", m3DNNO.Trim());
			if (m3DNDT.HasValue)
				request.WithQueryParameter("DNDT", m3DNDT.Value.ToM3String());
			if (m3DNTM.HasValue)
				request.WithQueryParameter("DNTM", m3DNTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RCQT.HasValue)
				request.WithQueryParameter("RCQT", m3RCQT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RCDT.HasValue)
				request.WithQueryParameter("RCDT", m3RCDT.Value.ToM3String());
			if (m3RCTM.HasValue)
				request.WithQueryParameter("RCTM", m3RCTM.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddHeader
		/// Description Add Delivery Schedule Header
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3E0IO">Message direction</param>
		/// <param name="m3DPNR">Delivery schedule</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3CHGD">Date changed</param>
		/// <param name="m3E0PA">Partner</param>
		/// <param name="m3E065">Message type</param>
		/// <param name="m3E026">Application reference</param>
		/// <param name="m3E068">Access reference</param>
		/// <param name="m3E035">Test indicator</param>
		/// <param name="m3E052">Message version</param>
		/// <param name="m3E054">Message release</param>
		/// <param name="m3E051">Controlling organization</param>
		/// <param name="m3E057">Organization assigned code</param>
		/// <param name="m3DPRF">Release frequency</param>
		/// <param name="m3DONR">Document number</param>
		/// <param name="m3EDFR">EDI reference</param>
		/// <param name="m3EXDT">Start date</param>
		/// <param name="m3EXTM">Start time</param>
		/// <param name="m3ENDT">Finish date</param>
		/// <param name="m3ENTM">End time</param>
		/// <param name="m3DPMA">Delivery schedule origin</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3CUDT">Customer´s purchase order date</param>
		/// <param name="m3RSAG">Delivery contract number</param>
		/// <param name="m3RSAC">Update method</param>
		/// <param name="m3DTTP">Date type</param>
		/// <param name="m3CUPA">Customers packaging identity</param>
		/// <param name="m3D1QT">Standard quantity (Replaced by D1Q2)</param>
		/// <param name="m3PARE">Package reference</param>
		/// <param name="m3AMKO">Number of packages</param>
		/// <param name="m3NEWE">Net weight</param>
		/// <param name="m3GRWE">Gross weight</param>
		/// <param name="m3VOL3">Volume</param>
		/// <param name="m3CROU">Customer route</param>
		/// <param name="m3CCAR">Customer´s carrier name</param>
		/// <param name="m3SHRF">Shipment reference</param>
		/// <param name="m3INRC">Invoice recipient</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3FWNO">Forwarding agent</param>
		/// <param name="m3D1Q2">Standard quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddHeaderResponse></returns>
		/// <exception cref="M3Exception<AddHeaderResponse>"></exception>
		public async Task<M3Response<AddHeaderResponse>> AddHeader(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3E0IO = null, 
			string m3DPNR = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			DateTime? m3CHGD = null, 
			string m3E0PA = null, 
			string m3E065 = null, 
			string m3E026 = null, 
			string m3E068 = null, 
			int? m3E035 = null, 
			string m3E052 = null, 
			string m3E054 = null, 
			string m3E051 = null, 
			string m3E057 = null, 
			int? m3DPRF = null, 
			string m3DONR = null, 
			string m3EDFR = null, 
			DateTime? m3EXDT = null, 
			int? m3EXTM = null, 
			DateTime? m3ENDT = null, 
			int? m3ENTM = null, 
			int? m3DPMA = null, 
			string m3CUOR = null, 
			DateTime? m3CUDT = null, 
			string m3RSAG = null, 
			int? m3RSAC = null, 
			int? m3DTTP = null, 
			string m3CUPA = null, 
			decimal? m3D1QT = null, 
			string m3PARE = null, 
			int? m3AMKO = null, 
			decimal? m3NEWE = null, 
			decimal? m3GRWE = null, 
			decimal? m3VOL3 = null, 
			string m3CROU = null, 
			string m3CCAR = null, 
			string m3SHRF = null, 
			string m3INRC = null, 
			string m3PYNO = null, 
			string m3FWNO = null, 
			decimal? m3D1Q2 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddHeader",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3E0IO))
				request.WithQueryParameter("E0IO", m3E0IO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DPNR))
				request.WithQueryParameter("DPNR", m3DPNR.Trim());
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHGD.HasValue)
				request.WithQueryParameter("CHGD", m3CHGD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3E0PA))
				request.WithQueryParameter("E0PA", m3E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3E065))
				request.WithQueryParameter("E065", m3E065.Trim());
			if (!string.IsNullOrWhiteSpace(m3E026))
				request.WithQueryParameter("E026", m3E026.Trim());
			if (!string.IsNullOrWhiteSpace(m3E068))
				request.WithQueryParameter("E068", m3E068.Trim());
			if (m3E035.HasValue)
				request.WithQueryParameter("E035", m3E035.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3E052))
				request.WithQueryParameter("E052", m3E052.Trim());
			if (!string.IsNullOrWhiteSpace(m3E054))
				request.WithQueryParameter("E054", m3E054.Trim());
			if (!string.IsNullOrWhiteSpace(m3E051))
				request.WithQueryParameter("E051", m3E051.Trim());
			if (!string.IsNullOrWhiteSpace(m3E057))
				request.WithQueryParameter("E057", m3E057.Trim());
			if (m3DPRF.HasValue)
				request.WithQueryParameter("DPRF", m3DPRF.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DONR))
				request.WithQueryParameter("DONR", m3DONR.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDFR))
				request.WithQueryParameter("EDFR", m3EDFR.Trim());
			if (m3EXDT.HasValue)
				request.WithQueryParameter("EXDT", m3EXDT.Value.ToM3String());
			if (m3EXTM.HasValue)
				request.WithQueryParameter("EXTM", m3EXTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ENDT.HasValue)
				request.WithQueryParameter("ENDT", m3ENDT.Value.ToM3String());
			if (m3ENTM.HasValue)
				request.WithQueryParameter("ENTM", m3ENTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DPMA.HasValue)
				request.WithQueryParameter("DPMA", m3DPMA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (m3CUDT.HasValue)
				request.WithQueryParameter("CUDT", m3CUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3RSAG))
				request.WithQueryParameter("RSAG", m3RSAG.Trim());
			if (m3RSAC.HasValue)
				request.WithQueryParameter("RSAC", m3RSAC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DTTP.HasValue)
				request.WithQueryParameter("DTTP", m3DTTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUPA))
				request.WithQueryParameter("CUPA", m3CUPA.Trim());
			if (m3D1QT.HasValue)
				request.WithQueryParameter("D1QT", m3D1QT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PARE))
				request.WithQueryParameter("PARE", m3PARE.Trim());
			if (m3AMKO.HasValue)
				request.WithQueryParameter("AMKO", m3AMKO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3NEWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3GRWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VOL3.HasValue)
				request.WithQueryParameter("VOL3", m3VOL3.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CROU))
				request.WithQueryParameter("CROU", m3CROU.Trim());
			if (!string.IsNullOrWhiteSpace(m3CCAR))
				request.WithQueryParameter("CCAR", m3CCAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SHRF))
				request.WithQueryParameter("SHRF", m3SHRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3INRC))
				request.WithQueryParameter("INRC", m3INRC.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FWNO))
				request.WithQueryParameter("FWNO", m3FWNO.Trim());
			if (m3D1Q2.HasValue)
				request.WithQueryParameter("D1Q2", m3D1Q2.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddHeaderResponse>(
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
		/// Name AddInstruction
		/// Description Add Delivery Schedule Instruction
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3ODPN">Our delivery schedule number</param>
		/// <param name="m3ODPI">Line number</param>
		/// <param name="m3RLDT">Requested delivery date</param>
		/// <param name="m3RLTM">Requested delivery time</param>
		/// <param name="m3DEMQ">Requested quantity</param>
		/// <param name="m3RSIN">Delivery status indicator</param>
		/// <param name="m3QTQL">Quantity qualifier</param>
		/// <param name="m3INRA">Instruction reason</param>
		/// <param name="m3INSA">Instruction activity code</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3CUDT">Customer´s purchase order date</param>
		/// <param name="m3RSAG">Delivery contract number</param>
		/// <param name="m3RSAC">Update method</param>
		/// <param name="m3RTDT">Period to date</param>
		/// <param name="m3RTTM">Period to time</param>
		/// <param name="m3CQCF">Cumulative quantity</param>
		/// <param name="m3PDSQ">Production sequence number</param>
		/// <param name="m3RSKN">Kanban card number</param>
		/// <param name="m3CHAS">Chassi number</param>
		/// <param name="m3YREF">Your reference 1</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddInstructionResponse></returns>
		/// <exception cref="M3Exception<AddInstructionResponse>"></exception>
		public async Task<M3Response<AddInstructionResponse>> AddInstruction(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3ODPN = null, 
			int? m3ODPI = null, 
			DateTime? m3RLDT = null, 
			int? m3RLTM = null, 
			decimal? m3DEMQ = null, 
			int? m3RSIN = null, 
			int? m3QTQL = null, 
			int? m3INRA = null, 
			int? m3INSA = null, 
			string m3CUOR = null, 
			DateTime? m3CUDT = null, 
			string m3RSAG = null, 
			int? m3RSAC = null, 
			DateTime? m3RTDT = null, 
			int? m3RTTM = null, 
			decimal? m3CQCF = null, 
			string m3PDSQ = null, 
			string m3RSKN = null, 
			string m3CHAS = null, 
			string m3YREF = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddInstruction",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ODPN))
				request.WithQueryParameter("ODPN", m3ODPN.Trim());
			if (m3ODPI.HasValue)
				request.WithQueryParameter("ODPI", m3ODPI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RLDT.HasValue)
				request.WithQueryParameter("RLDT", m3RLDT.Value.ToM3String());
			if (m3RLTM.HasValue)
				request.WithQueryParameter("RLTM", m3RLTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DEMQ.HasValue)
				request.WithQueryParameter("DEMQ", m3DEMQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RSIN.HasValue)
				request.WithQueryParameter("RSIN", m3RSIN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QTQL.HasValue)
				request.WithQueryParameter("QTQL", m3QTQL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INRA.HasValue)
				request.WithQueryParameter("INRA", m3INRA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INSA.HasValue)
				request.WithQueryParameter("INSA", m3INSA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (m3CUDT.HasValue)
				request.WithQueryParameter("CUDT", m3CUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3RSAG))
				request.WithQueryParameter("RSAG", m3RSAG.Trim());
			if (m3RSAC.HasValue)
				request.WithQueryParameter("RSAC", m3RSAC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RTDT.HasValue)
				request.WithQueryParameter("RTDT", m3RTDT.Value.ToM3String());
			if (m3RTTM.HasValue)
				request.WithQueryParameter("RTTM", m3RTTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CQCF.HasValue)
				request.WithQueryParameter("CQCF", m3CQCF.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PDSQ))
				request.WithQueryParameter("PDSQ", m3PDSQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSKN))
				request.WithQueryParameter("RSKN", m3RSKN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHAS))
				request.WithQueryParameter("CHAS", m3CHAS.Trim());
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());

			// Execute the request
			var result = await Execute<AddInstructionResponse>(
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
		/// Name AddItem
		/// Description Add Delivery Schedule Item
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3ODPN">Our delivery schedule number</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWT">Alias category</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3ITDS">Name</param>
		/// <param name="m3UNIT">Unit of measure</param>
		/// <param name="m3ORCO">Country of origin</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3CUDT">Customers purchase order date</param>
		/// <param name="m3RSAG">Delivery contract number</param>
		/// <param name="m3RSAC">Update method</param>
		/// <param name="m3PUSN">Delivery note reference</param>
		/// <param name="m3PUTP">Delivery note reference qualifier</param>
		/// <param name="m3CFXX">Old CFIN</param>
		/// <param name="m3DSLV">Delivery schedule level</param>
		/// <param name="m3DTTP">Date type</param>
		/// <param name="m3RSRN">Partner´s design revision number</param>
		/// <param name="m3RSEC">Partner´s engineering change order no</param>
		/// <param name="m3RSED">Engineering change order date</param>
		/// <param name="m3RSPS">Previous delivery schedule number</param>
		/// <param name="m3ITRL">Status - item release</param>
		/// <param name="m3NEWE">Net weight</param>
		/// <param name="m3GRWE">Gross weight</param>
		/// <param name="m3VOL3">Volume</param>
		/// <param name="m3CUPA">Customers packaging identity</param>
		/// <param name="m3D1QT">Standard quantity (Replaced by D1Q2)</param>
		/// <param name="m3PARE">Package reference</param>
		/// <param name="m3AMKO">Number of packages</param>
		/// <param name="m3CUMY">Customer´s model year</param>
		/// <param name="m3SAPR">Sales price</param>
		/// <param name="m3SACD">Sales price quantity</param>
		/// <param name="m3CUCS">Currency - sales price</param>
		/// <param name="m3SPUN">Sales price unit of measure</param>
		/// <param name="m3EXPI">Expiration date</param>
		/// <param name="m3CDLP">Customer´s delivery pattern</param>
		/// <param name="m3RSK2">Customer´s internal kanban card number</param>
		/// <param name="m3ECNM">EU number</param>
		/// <param name="m3AUSD">Authorization firm to date</param>
		/// <param name="m3AUST">Firm period qualifier</param>
		/// <param name="m3AUSP">Firm periods</param>
		/// <param name="m3AUFD">Authorization fabrication to date</param>
		/// <param name="m3AUFT">Fabrication period qualifier</param>
		/// <param name="m3AUFP">Fabrication periods</param>
		/// <param name="m3AUMD">Authorization material to date</param>
		/// <param name="m3AUMT">Material period qualifier</param>
		/// <param name="m3AUMP">Material periods</param>
		/// <param name="m3AUUD">Forecast to date</param>
		/// <param name="m3AUUT">Forecast period qualifier</param>
		/// <param name="m3AUUP">Forecast periods</param>
		/// <param name="m3AUXD">Reference agreement to date</param>
		/// <param name="m3AUXT">Total quantity reference agreement</param>
		/// <param name="m3AUXP">Reference agreement period qualifier</param>
		/// <param name="m3CDE1">Consolidate item demand - field 1</param>
		/// <param name="m3CDE2">Consolidate item demand - field 2</param>
		/// <param name="m3CDE3">Consolidate item demand - field 3</param>
		/// <param name="m3MOYE">Model/year</param>
		/// <param name="m3INRC">Invoice recipient</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3FWNO">Forwarding agent</param>
		/// <param name="m3CFIN">Configuration number</param>
		/// <param name="m3D1Q2">Standard quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddItemResponse></returns>
		/// <exception cref="M3Exception<AddItemResponse>"></exception>
		public async Task<M3Response<AddItemResponse>> AddItem(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3ODPN = null, 
			string m3POPN = null, 
			int? m3ALWT = null, 
			string m3ALWQ = null, 
			string m3ITNO = null, 
			string m3ITDS = null, 
			string m3UNIT = null, 
			string m3ORCO = null, 
			string m3WHLO = null, 
			string m3FACI = null, 
			string m3CUOR = null, 
			DateTime? m3CUDT = null, 
			string m3RSAG = null, 
			int? m3RSAC = null, 
			string m3PUSN = null, 
			int? m3PUTP = null, 
			int? m3CFXX = null, 
			int? m3DSLV = null, 
			int? m3DTTP = null, 
			string m3RSRN = null, 
			string m3RSEC = null, 
			DateTime? m3RSED = null, 
			string m3RSPS = null, 
			string m3ITRL = null, 
			decimal? m3NEWE = null, 
			decimal? m3GRWE = null, 
			decimal? m3VOL3 = null, 
			string m3CUPA = null, 
			decimal? m3D1QT = null, 
			string m3PARE = null, 
			int? m3AMKO = null, 
			string m3CUMY = null, 
			decimal? m3SAPR = null, 
			int? m3SACD = null, 
			string m3CUCS = null, 
			string m3SPUN = null, 
			DateTime? m3EXPI = null, 
			string m3CDLP = null, 
			string m3RSK2 = null, 
			string m3ECNM = null, 
			DateTime? m3AUSD = null, 
			int? m3AUST = null, 
			int? m3AUSP = null, 
			DateTime? m3AUFD = null, 
			int? m3AUFT = null, 
			int? m3AUFP = null, 
			DateTime? m3AUMD = null, 
			int? m3AUMT = null, 
			int? m3AUMP = null, 
			DateTime? m3AUUD = null, 
			int? m3AUUT = null, 
			int? m3AUUP = null, 
			DateTime? m3AUXD = null, 
			int? m3AUXT = null, 
			int? m3AUXP = null, 
			string m3CDE1 = null, 
			string m3CDE2 = null, 
			string m3CDE3 = null, 
			string m3MOYE = null, 
			string m3INRC = null, 
			string m3PYNO = null, 
			string m3FWNO = null, 
			long? m3CFIN = null, 
			decimal? m3D1Q2 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddItem",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ODPN))
				request.WithQueryParameter("ODPN", m3ODPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3UNIT))
				request.WithQueryParameter("UNIT", m3UNIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORCO))
				request.WithQueryParameter("ORCO", m3ORCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (m3CUDT.HasValue)
				request.WithQueryParameter("CUDT", m3CUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3RSAG))
				request.WithQueryParameter("RSAG", m3RSAG.Trim());
			if (m3RSAC.HasValue)
				request.WithQueryParameter("RSAC", m3RSAC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PUSN))
				request.WithQueryParameter("PUSN", m3PUSN.Trim());
			if (m3PUTP.HasValue)
				request.WithQueryParameter("PUTP", m3PUTP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CFXX.HasValue)
				request.WithQueryParameter("CFXX", m3CFXX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSLV.HasValue)
				request.WithQueryParameter("DSLV", m3DSLV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DTTP.HasValue)
				request.WithQueryParameter("DTTP", m3DTTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RSRN))
				request.WithQueryParameter("RSRN", m3RSRN.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSEC))
				request.WithQueryParameter("RSEC", m3RSEC.Trim());
			if (m3RSED.HasValue)
				request.WithQueryParameter("RSED", m3RSED.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3RSPS))
				request.WithQueryParameter("RSPS", m3RSPS.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITRL))
				request.WithQueryParameter("ITRL", m3ITRL.Trim());
			if (m3NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3NEWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3GRWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VOL3.HasValue)
				request.WithQueryParameter("VOL3", m3VOL3.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUPA))
				request.WithQueryParameter("CUPA", m3CUPA.Trim());
			if (m3D1QT.HasValue)
				request.WithQueryParameter("D1QT", m3D1QT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PARE))
				request.WithQueryParameter("PARE", m3PARE.Trim());
			if (m3AMKO.HasValue)
				request.WithQueryParameter("AMKO", m3AMKO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUMY))
				request.WithQueryParameter("CUMY", m3CUMY.Trim());
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SACD.HasValue)
				request.WithQueryParameter("SACD", m3SACD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCS))
				request.WithQueryParameter("CUCS", m3CUCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPUN))
				request.WithQueryParameter("SPUN", m3SPUN.Trim());
			if (m3EXPI.HasValue)
				request.WithQueryParameter("EXPI", m3EXPI.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CDLP))
				request.WithQueryParameter("CDLP", m3CDLP.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSK2))
				request.WithQueryParameter("RSK2", m3RSK2.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECNM))
				request.WithQueryParameter("ECNM", m3ECNM.Trim());
			if (m3AUSD.HasValue)
				request.WithQueryParameter("AUSD", m3AUSD.Value.ToM3String());
			if (m3AUST.HasValue)
				request.WithQueryParameter("AUST", m3AUST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUSP.HasValue)
				request.WithQueryParameter("AUSP", m3AUSP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUFD.HasValue)
				request.WithQueryParameter("AUFD", m3AUFD.Value.ToM3String());
			if (m3AUFT.HasValue)
				request.WithQueryParameter("AUFT", m3AUFT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUFP.HasValue)
				request.WithQueryParameter("AUFP", m3AUFP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUMD.HasValue)
				request.WithQueryParameter("AUMD", m3AUMD.Value.ToM3String());
			if (m3AUMT.HasValue)
				request.WithQueryParameter("AUMT", m3AUMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUMP.HasValue)
				request.WithQueryParameter("AUMP", m3AUMP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUUD.HasValue)
				request.WithQueryParameter("AUUD", m3AUUD.Value.ToM3String());
			if (m3AUUT.HasValue)
				request.WithQueryParameter("AUUT", m3AUUT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUUP.HasValue)
				request.WithQueryParameter("AUUP", m3AUUP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUXD.HasValue)
				request.WithQueryParameter("AUXD", m3AUXD.Value.ToM3String());
			if (m3AUXT.HasValue)
				request.WithQueryParameter("AUXT", m3AUXT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUXP.HasValue)
				request.WithQueryParameter("AUXP", m3AUXP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CDE1))
				request.WithQueryParameter("CDE1", m3CDE1.Trim());
			if (!string.IsNullOrWhiteSpace(m3CDE2))
				request.WithQueryParameter("CDE2", m3CDE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3CDE3))
				request.WithQueryParameter("CDE3", m3CDE3.Trim());
			if (!string.IsNullOrWhiteSpace(m3MOYE))
				request.WithQueryParameter("MOYE", m3MOYE.Trim());
			if (!string.IsNullOrWhiteSpace(m3INRC))
				request.WithQueryParameter("INRC", m3INRC.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FWNO))
				request.WithQueryParameter("FWNO", m3FWNO.Trim());
			if (m3CFIN.HasValue)
				request.WithQueryParameter("CFIN", m3CFIN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D1Q2.HasValue)
				request.WithQueryParameter("D1Q2", m3D1Q2.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddItemResponse>(
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
		/// Name ExecuteSchedule
		/// Description Execute Delivery schedule
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3ODPN">Our delivery schedule number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ExecuteScheduleResponse></returns>
		/// <exception cref="M3Exception<ExecuteScheduleResponse>"></exception>
		public async Task<M3Response<ExecuteScheduleResponse>> ExecuteSchedule(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3ODPN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ExecuteSchedule",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ODPN))
				request.WithQueryParameter("ODPN", m3ODPN.Trim());

			// Execute the request
			var result = await Execute<ExecuteScheduleResponse>(
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
		/// Name GetAddress
		/// Description Get Addresses
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3ODPN">Our delivery schedule number (Required)</param>
		/// <param name="m3ODPI">Line number (Required)</param>
		/// <param name="m3ADRT">Address type (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetAddressResponse></returns>
		/// <exception cref="M3Exception<GetAddressResponse>"></exception>
		public async Task<M3Response<GetAddressResponse>> GetAddress(
			string m3ODPN, 
			int m3ODPI, 
			int m3ADRT, 
			int? m3CONO = null, 
			string m3DIVI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetAddress",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ODPN))
				throw new ArgumentNullException(nameof(m3ODPN));

			// Set mandatory parameters
			request
				.WithQueryParameter("ODPN", m3ODPN.Trim())
				.WithQueryParameter("ODPI", m3ODPI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ADRT", m3ADRT.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<GetAddressResponse>(
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
		/// Name GetCumQuantity
		/// Description Get Cumulative Quantity
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3ODPN">Our delivery schedule number</param>
		/// <param name="m3ODPI">Line number</param>
		/// <param name="m3CUMT">Cumulative type</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetCumQuantityResponse></returns>
		/// <exception cref="M3Exception<GetCumQuantityResponse>"></exception>
		public async Task<M3Response<GetCumQuantityResponse>> GetCumQuantity(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3ODPN = null, 
			int? m3ODPI = null, 
			int? m3CUMT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetCumQuantity",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ODPN))
				request.WithQueryParameter("ODPN", m3ODPN.Trim());
			if (m3ODPI.HasValue)
				request.WithQueryParameter("ODPI", m3ODPI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CUMT.HasValue)
				request.WithQueryParameter("CUMT", m3CUMT.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetCumQuantityResponse>(
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
		/// Name GetDeliveryNote
		/// Description Get Delivery Note
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3ODPN">Our delivery schedule number</param>
		/// <param name="m3ODPI">Line number</param>
		/// <param name="m3DNNO">Delivery note number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetDeliveryNoteResponse></returns>
		/// <exception cref="M3Exception<GetDeliveryNoteResponse>"></exception>
		public async Task<M3Response<GetDeliveryNoteResponse>> GetDeliveryNote(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3ODPN = null, 
			int? m3ODPI = null, 
			string m3DNNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetDeliveryNote",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ODPN))
				request.WithQueryParameter("ODPN", m3ODPN.Trim());
			if (m3ODPI.HasValue)
				request.WithQueryParameter("ODPI", m3ODPI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DNNO))
				request.WithQueryParameter("DNNO", m3DNNO.Trim());

			// Execute the request
			var result = await Execute<GetDeliveryNoteResponse>(
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
		/// Name GetHeader
		/// Description Get Delivery Schedule Header
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3E0IO">Message direction</param>
		/// <param name="m3ODPN">Our delivery schedule number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetHeaderResponse></returns>
		/// <exception cref="M3Exception<GetHeaderResponse>"></exception>
		public async Task<M3Response<GetHeaderResponse>> GetHeader(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3E0IO = null, 
			string m3ODPN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetHeader",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3E0IO))
				request.WithQueryParameter("E0IO", m3E0IO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ODPN))
				request.WithQueryParameter("ODPN", m3ODPN.Trim());

			// Execute the request
			var result = await Execute<GetHeaderResponse>(
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
		/// Name GetInstruction
		/// Description Get Delivery Schedule Instruction
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3ODPN">Our delivery schedule number</param>
		/// <param name="m3ODPI">Line number</param>
		/// <param name="m3ODPS">Line sequence</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetInstructionResponse></returns>
		/// <exception cref="M3Exception<GetInstructionResponse>"></exception>
		public async Task<M3Response<GetInstructionResponse>> GetInstruction(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3ODPN = null, 
			int? m3ODPI = null, 
			int? m3ODPS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetInstruction",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ODPN))
				request.WithQueryParameter("ODPN", m3ODPN.Trim());
			if (m3ODPI.HasValue)
				request.WithQueryParameter("ODPI", m3ODPI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ODPS.HasValue)
				request.WithQueryParameter("ODPS", m3ODPS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetInstructionResponse>(
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
		/// Name GetItem
		/// Description Get Delivery Schedule Item
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3ODPN">Our delivery schedule number</param>
		/// <param name="m3ODPI">Line number</param>
		/// <param name="m3E0IO">Message direction</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItemResponse></returns>
		/// <exception cref="M3Exception<GetItemResponse>"></exception>
		public async Task<M3Response<GetItemResponse>> GetItem(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3ODPN = null, 
			int? m3ODPI = null, 
			string m3E0IO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetItem",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ODPN))
				request.WithQueryParameter("ODPN", m3ODPN.Trim());
			if (m3ODPI.HasValue)
				request.WithQueryParameter("ODPI", m3ODPI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3E0IO))
				request.WithQueryParameter("E0IO", m3E0IO.Trim());

			// Execute the request
			var result = await Execute<GetItemResponse>(
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
		/// Name GetPartner
		/// Description Get Partner
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3PAAL">Partner alias</param>
		/// <param name="m3PAA1">Partner alias 1</param>
		/// <param name="m3PAA2">Partner alias 2</param>
		/// <param name="m3PAAQ">Partner alias qualifier</param>
		/// <param name="m3PAAC">Partner alias category</param>
		/// <param name="m3QCTG">Qualifying partner category</param>
		/// <param name="m3QPAI">Partner identity 1</param>
		/// <param name="m3QPA1">Partner identity 2</param>
		/// <param name="m3QPA2">Partner identity 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPartnerResponse></returns>
		/// <exception cref="M3Exception<GetPartnerResponse>"></exception>
		public async Task<M3Response<GetPartnerResponse>> GetPartner(
			int? m3CONO = null, 
			string m3PAAL = null, 
			string m3PAA1 = null, 
			string m3PAA2 = null, 
			string m3PAAQ = null, 
			int? m3PAAC = null, 
			int? m3QCTG = null, 
			string m3QPAI = null, 
			string m3QPA1 = null, 
			string m3QPA2 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetPartner",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PAAL))
				request.WithQueryParameter("PAAL", m3PAAL.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAA1))
				request.WithQueryParameter("PAA1", m3PAA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAA2))
				request.WithQueryParameter("PAA2", m3PAA2.Trim());
			if (!string.IsNullOrWhiteSpace(m3PAAQ))
				request.WithQueryParameter("PAAQ", m3PAAQ.Trim());
			if (m3PAAC.HasValue)
				request.WithQueryParameter("PAAC", m3PAAC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QCTG.HasValue)
				request.WithQueryParameter("QCTG", m3QCTG.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3QPAI))
				request.WithQueryParameter("QPAI", m3QPAI.Trim());
			if (!string.IsNullOrWhiteSpace(m3QPA1))
				request.WithQueryParameter("QPA1", m3QPA1.Trim());
			if (!string.IsNullOrWhiteSpace(m3QPA2))
				request.WithQueryParameter("QPA2", m3QPA2.Trim());

			// Execute the request
			var result = await Execute<GetPartnerResponse>(
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
		/// Name GetPartnerParms
		/// Description Get Partner Parameters
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3E0IO">Message direction</param>
		/// <param name="m3E0PA">Partner</param>
		/// <param name="m3E065">Message type</param>
		/// <param name="m3E026">Application reference</param>
		/// <param name="m3E068">Access reference</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPartnerParmsResponse></returns>
		/// <exception cref="M3Exception<GetPartnerParmsResponse>"></exception>
		public async Task<M3Response<GetPartnerParmsResponse>> GetPartnerParms(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3E0IO = null, 
			string m3E0PA = null, 
			string m3E065 = null, 
			string m3E026 = null, 
			string m3E068 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetPartnerParms",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3E0IO))
				request.WithQueryParameter("E0IO", m3E0IO.Trim());
			if (!string.IsNullOrWhiteSpace(m3E0PA))
				request.WithQueryParameter("E0PA", m3E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3E065))
				request.WithQueryParameter("E065", m3E065.Trim());
			if (!string.IsNullOrWhiteSpace(m3E026))
				request.WithQueryParameter("E026", m3E026.Trim());
			if (!string.IsNullOrWhiteSpace(m3E068))
				request.WithQueryParameter("E068", m3E068.Trim());

			// Execute the request
			var result = await Execute<GetPartnerParmsResponse>(
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
		/// Name SetProcessing
		/// Description Set Processing
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3PROC">Mode (I=Interactive, B=Batch (default)) (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SetProcessing(
			string m3PROC, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SetProcessing",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PROC))
				throw new ArgumentNullException(nameof(m3PROC));

			// Set mandatory parameters
			request
				.WithQueryParameter("PROC", m3PROC.Trim());

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
		/// Name SndInstruction
		/// Description Send Delivery Schedule Instruction (no response)
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3ODPN">Our delivery schedule number</param>
		/// <param name="m3ODPI">Line number</param>
		/// <param name="m3RLDT">Requested delivery date</param>
		/// <param name="m3RLTM">Requested delivery time</param>
		/// <param name="m3DEMQ">Requested quantity</param>
		/// <param name="m3RSIN">Delivery status indicator</param>
		/// <param name="m3QTQL">Quantity qualifier</param>
		/// <param name="m3INRA">Instruction reason</param>
		/// <param name="m3INSA">Instruction activity code</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3CUDT">Customer´s purchase order date</param>
		/// <param name="m3RSAG">Delivery contract number</param>
		/// <param name="m3RSAC">Update method</param>
		/// <param name="m3RTDT">Period to date</param>
		/// <param name="m3RTTM">Period to time</param>
		/// <param name="m3CQCF">Cumulative quantity</param>
		/// <param name="m3PDSQ">Production sequence number</param>
		/// <param name="m3RSKN">Kanban card number</param>
		/// <param name="m3CHAS">Chassi number</param>
		/// <param name="m3YREF">Your reference 1</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndInstruction(
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3ODPN = null, 
			int? m3ODPI = null, 
			DateTime? m3RLDT = null, 
			int? m3RLTM = null, 
			decimal? m3DEMQ = null, 
			int? m3RSIN = null, 
			int? m3QTQL = null, 
			int? m3INRA = null, 
			int? m3INSA = null, 
			string m3CUOR = null, 
			DateTime? m3CUDT = null, 
			string m3RSAG = null, 
			int? m3RSAC = null, 
			DateTime? m3RTDT = null, 
			int? m3RTTM = null, 
			decimal? m3CQCF = null, 
			string m3PDSQ = null, 
			string m3RSKN = null, 
			string m3CHAS = null, 
			string m3YREF = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SndInstruction",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ODPN))
				request.WithQueryParameter("ODPN", m3ODPN.Trim());
			if (m3ODPI.HasValue)
				request.WithQueryParameter("ODPI", m3ODPI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RLDT.HasValue)
				request.WithQueryParameter("RLDT", m3RLDT.Value.ToM3String());
			if (m3RLTM.HasValue)
				request.WithQueryParameter("RLTM", m3RLTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DEMQ.HasValue)
				request.WithQueryParameter("DEMQ", m3DEMQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RSIN.HasValue)
				request.WithQueryParameter("RSIN", m3RSIN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QTQL.HasValue)
				request.WithQueryParameter("QTQL", m3QTQL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INRA.HasValue)
				request.WithQueryParameter("INRA", m3INRA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INSA.HasValue)
				request.WithQueryParameter("INSA", m3INSA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (m3CUDT.HasValue)
				request.WithQueryParameter("CUDT", m3CUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3RSAG))
				request.WithQueryParameter("RSAG", m3RSAG.Trim());
			if (m3RSAC.HasValue)
				request.WithQueryParameter("RSAC", m3RSAC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RTDT.HasValue)
				request.WithQueryParameter("RTDT", m3RTDT.Value.ToM3String());
			if (m3RTTM.HasValue)
				request.WithQueryParameter("RTTM", m3RTTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CQCF.HasValue)
				request.WithQueryParameter("CQCF", m3CQCF.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PDSQ))
				request.WithQueryParameter("PDSQ", m3PDSQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSKN))
				request.WithQueryParameter("RSKN", m3RSKN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHAS))
				request.WithQueryParameter("CHAS", m3CHAS.Trim());
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());

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
		/// Name SndTextLine
		/// Description Send Text Line (no response)
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3ODPN">Our delivery schedule number (Required)</param>
		/// <param name="m3TXQA">Qualifier (H-Head, I-Item, O-Order) (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3ODPI">Line number</param>
		/// <param name="m3TX60">Text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> SndTextLine(
			string m3ODPN, 
			string m3TXQA, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			int? m3ODPI = null, 
			string m3TX60 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/SndTextLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ODPN))
				throw new ArgumentNullException(nameof(m3ODPN));
			if (string.IsNullOrWhiteSpace(m3TXQA))
				throw new ArgumentNullException(nameof(m3TXQA));

			// Set mandatory parameters
			request
				.WithQueryParameter("ODPN", m3ODPN.Trim())
				.WithQueryParameter("TXQA", m3TXQA.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3ODPI.HasValue)
				request.WithQueryParameter("ODPI", m3ODPI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX60))
				request.WithQueryParameter("TX60", m3TX60.Trim());

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
		/// Name UpdHeader
		/// Description Update Delivery Schedule Header
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3E0IO">Message direction (Required)</param>
		/// <param name="m3ODPN">Our delivery schedule number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3DPNR">Delivery schedule</param>
		/// <param name="m3GEDT">Date generated</param>
		/// <param name="m3GETM">Time generated</param>
		/// <param name="m3CHGD">Date changed</param>
		/// <param name="m3E0PA">Partner</param>
		/// <param name="m3E065">Message type</param>
		/// <param name="m3E026">Application reference</param>
		/// <param name="m3E068">Access reference</param>
		/// <param name="m3E035">Test indicator</param>
		/// <param name="m3E052">Message version</param>
		/// <param name="m3E054">Message release</param>
		/// <param name="m3E051">Controlling organization</param>
		/// <param name="m3E057">Organization assigned code</param>
		/// <param name="m3DPRF">Release frequency</param>
		/// <param name="m3DONR">Document number</param>
		/// <param name="m3EDFR">EDI reference</param>
		/// <param name="m3EXDT">Start date</param>
		/// <param name="m3EXTM">Start time</param>
		/// <param name="m3ENDT">Finish date</param>
		/// <param name="m3ENTM">End time</param>
		/// <param name="m3DPMA">Delivery schedule origin</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3CUDT">Customer´s purchase order date</param>
		/// <param name="m3RSAG">Delivery contract number</param>
		/// <param name="m3RSAC">Update method</param>
		/// <param name="m3DTTP">Date type</param>
		/// <param name="m3CUPA">Customers packaging identity</param>
		/// <param name="m3D1QT">Standard quantity (Replaced by D1Q2)</param>
		/// <param name="m3PARE">Package reference</param>
		/// <param name="m3AMKO">Number of packages</param>
		/// <param name="m3NEWE">Net weight</param>
		/// <param name="m3GRWE">Gross weight</param>
		/// <param name="m3VOL3">Volume</param>
		/// <param name="m3CROU">Customer route</param>
		/// <param name="m3CCAR">Customer´s carrier name</param>
		/// <param name="m3SHRF">Shipment reference</param>
		/// <param name="m3D1Q2">Standard quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdHeader(
			string m3E0IO, 
			string m3ODPN, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3DPNR = null, 
			DateTime? m3GEDT = null, 
			int? m3GETM = null, 
			DateTime? m3CHGD = null, 
			string m3E0PA = null, 
			string m3E065 = null, 
			string m3E026 = null, 
			string m3E068 = null, 
			int? m3E035 = null, 
			string m3E052 = null, 
			string m3E054 = null, 
			string m3E051 = null, 
			string m3E057 = null, 
			int? m3DPRF = null, 
			string m3DONR = null, 
			string m3EDFR = null, 
			DateTime? m3EXDT = null, 
			int? m3EXTM = null, 
			DateTime? m3ENDT = null, 
			int? m3ENTM = null, 
			int? m3DPMA = null, 
			string m3CUOR = null, 
			DateTime? m3CUDT = null, 
			string m3RSAG = null, 
			int? m3RSAC = null, 
			int? m3DTTP = null, 
			string m3CUPA = null, 
			decimal? m3D1QT = null, 
			string m3PARE = null, 
			int? m3AMKO = null, 
			decimal? m3NEWE = null, 
			decimal? m3GRWE = null, 
			decimal? m3VOL3 = null, 
			string m3CROU = null, 
			string m3CCAR = null, 
			string m3SHRF = null, 
			decimal? m3D1Q2 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdHeader",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3E0IO))
				throw new ArgumentNullException(nameof(m3E0IO));
			if (string.IsNullOrWhiteSpace(m3ODPN))
				throw new ArgumentNullException(nameof(m3ODPN));

			// Set mandatory parameters
			request
				.WithQueryParameter("E0IO", m3E0IO.Trim())
				.WithQueryParameter("ODPN", m3ODPN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3DPNR))
				request.WithQueryParameter("DPNR", m3DPNR.Trim());
			if (m3GEDT.HasValue)
				request.WithQueryParameter("GEDT", m3GEDT.Value.ToM3String());
			if (m3GETM.HasValue)
				request.WithQueryParameter("GETM", m3GETM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHGD.HasValue)
				request.WithQueryParameter("CHGD", m3CHGD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3E0PA))
				request.WithQueryParameter("E0PA", m3E0PA.Trim());
			if (!string.IsNullOrWhiteSpace(m3E065))
				request.WithQueryParameter("E065", m3E065.Trim());
			if (!string.IsNullOrWhiteSpace(m3E026))
				request.WithQueryParameter("E026", m3E026.Trim());
			if (!string.IsNullOrWhiteSpace(m3E068))
				request.WithQueryParameter("E068", m3E068.Trim());
			if (m3E035.HasValue)
				request.WithQueryParameter("E035", m3E035.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3E052))
				request.WithQueryParameter("E052", m3E052.Trim());
			if (!string.IsNullOrWhiteSpace(m3E054))
				request.WithQueryParameter("E054", m3E054.Trim());
			if (!string.IsNullOrWhiteSpace(m3E051))
				request.WithQueryParameter("E051", m3E051.Trim());
			if (!string.IsNullOrWhiteSpace(m3E057))
				request.WithQueryParameter("E057", m3E057.Trim());
			if (m3DPRF.HasValue)
				request.WithQueryParameter("DPRF", m3DPRF.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DONR))
				request.WithQueryParameter("DONR", m3DONR.Trim());
			if (!string.IsNullOrWhiteSpace(m3EDFR))
				request.WithQueryParameter("EDFR", m3EDFR.Trim());
			if (m3EXDT.HasValue)
				request.WithQueryParameter("EXDT", m3EXDT.Value.ToM3String());
			if (m3EXTM.HasValue)
				request.WithQueryParameter("EXTM", m3EXTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ENDT.HasValue)
				request.WithQueryParameter("ENDT", m3ENDT.Value.ToM3String());
			if (m3ENTM.HasValue)
				request.WithQueryParameter("ENTM", m3ENTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DPMA.HasValue)
				request.WithQueryParameter("DPMA", m3DPMA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (m3CUDT.HasValue)
				request.WithQueryParameter("CUDT", m3CUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3RSAG))
				request.WithQueryParameter("RSAG", m3RSAG.Trim());
			if (m3RSAC.HasValue)
				request.WithQueryParameter("RSAC", m3RSAC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DTTP.HasValue)
				request.WithQueryParameter("DTTP", m3DTTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUPA))
				request.WithQueryParameter("CUPA", m3CUPA.Trim());
			if (m3D1QT.HasValue)
				request.WithQueryParameter("D1QT", m3D1QT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PARE))
				request.WithQueryParameter("PARE", m3PARE.Trim());
			if (m3AMKO.HasValue)
				request.WithQueryParameter("AMKO", m3AMKO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3NEWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3GRWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VOL3.HasValue)
				request.WithQueryParameter("VOL3", m3VOL3.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CROU))
				request.WithQueryParameter("CROU", m3CROU.Trim());
			if (!string.IsNullOrWhiteSpace(m3CCAR))
				request.WithQueryParameter("CCAR", m3CCAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SHRF))
				request.WithQueryParameter("SHRF", m3SHRF.Trim());
			if (m3D1Q2.HasValue)
				request.WithQueryParameter("D1Q2", m3D1Q2.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdInstruction
		/// Description Add Delivery Schedule Instruction
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3ODPN">Our delivery schedule number (Required)</param>
		/// <param name="m3ODPI">Line number (Required)</param>
		/// <param name="m3ODPS">Line sequence (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3RLDT">Requested delivery date</param>
		/// <param name="m3RLTM">Requested delivery time</param>
		/// <param name="m3DEMQ">Requested quantity</param>
		/// <param name="m3RSIN">Delivery status indicator</param>
		/// <param name="m3QTQL">Quantity qualifier</param>
		/// <param name="m3INRA">Instruction reason</param>
		/// <param name="m3INSA">Instruction activity code</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3CUDT">Customer´s purchase order date</param>
		/// <param name="m3RSAG">Delivery contract number</param>
		/// <param name="m3RSAC">Update method</param>
		/// <param name="m3RTDT">Period to date</param>
		/// <param name="m3RTTM">Period to time</param>
		/// <param name="m3CQCF">Cumulative quantity</param>
		/// <param name="m3PDSQ">Production sequence number</param>
		/// <param name="m3RSKN">Kanban card number</param>
		/// <param name="m3CHAS">Chassi number</param>
		/// <param name="m3YREF">Your reference 1</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdInstruction(
			string m3ODPN, 
			int m3ODPI, 
			int m3ODPS, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			DateTime? m3RLDT = null, 
			int? m3RLTM = null, 
			decimal? m3DEMQ = null, 
			int? m3RSIN = null, 
			int? m3QTQL = null, 
			int? m3INRA = null, 
			int? m3INSA = null, 
			string m3CUOR = null, 
			DateTime? m3CUDT = null, 
			string m3RSAG = null, 
			int? m3RSAC = null, 
			DateTime? m3RTDT = null, 
			int? m3RTTM = null, 
			decimal? m3CQCF = null, 
			string m3PDSQ = null, 
			string m3RSKN = null, 
			string m3CHAS = null, 
			string m3YREF = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdInstruction",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ODPN))
				throw new ArgumentNullException(nameof(m3ODPN));

			// Set mandatory parameters
			request
				.WithQueryParameter("ODPN", m3ODPN.Trim())
				.WithQueryParameter("ODPI", m3ODPI.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("ODPS", m3ODPS.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3RLDT.HasValue)
				request.WithQueryParameter("RLDT", m3RLDT.Value.ToM3String());
			if (m3RLTM.HasValue)
				request.WithQueryParameter("RLTM", m3RLTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DEMQ.HasValue)
				request.WithQueryParameter("DEMQ", m3DEMQ.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RSIN.HasValue)
				request.WithQueryParameter("RSIN", m3RSIN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3QTQL.HasValue)
				request.WithQueryParameter("QTQL", m3QTQL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INRA.HasValue)
				request.WithQueryParameter("INRA", m3INRA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INSA.HasValue)
				request.WithQueryParameter("INSA", m3INSA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (m3CUDT.HasValue)
				request.WithQueryParameter("CUDT", m3CUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3RSAG))
				request.WithQueryParameter("RSAG", m3RSAG.Trim());
			if (m3RSAC.HasValue)
				request.WithQueryParameter("RSAC", m3RSAC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RTDT.HasValue)
				request.WithQueryParameter("RTDT", m3RTDT.Value.ToM3String());
			if (m3RTTM.HasValue)
				request.WithQueryParameter("RTTM", m3RTTM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CQCF.HasValue)
				request.WithQueryParameter("CQCF", m3CQCF.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PDSQ))
				request.WithQueryParameter("PDSQ", m3PDSQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSKN))
				request.WithQueryParameter("RSKN", m3RSKN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CHAS))
				request.WithQueryParameter("CHAS", m3CHAS.Trim());
			if (!string.IsNullOrWhiteSpace(m3YREF))
				request.WithQueryParameter("YREF", m3YREF.Trim());

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
		/// Name UpdItem
		/// Description Update Delivery Schedule Item
		/// Version Release: 13.1
		/// </summary>
		/// <param name="m3ODPN">Our delivery schedule number (Required)</param>
		/// <param name="m3ODPI">Line number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ALWT">Alias category</param>
		/// <param name="m3ALWQ">Alias qualifier</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3ITDS">Name</param>
		/// <param name="m3UNIT">Unit of measure</param>
		/// <param name="m3ORCO">Country of origin</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3CUDT">Customer´s purchase order date</param>
		/// <param name="m3RSAG">Delivery contract number</param>
		/// <param name="m3RSAC">Update method</param>
		/// <param name="m3PUSN">Delivery note reference</param>
		/// <param name="m3PUTP">Delivery note reference qualifier</param>
		/// <param name="m3CFXX">Old CFIN</param>
		/// <param name="m3DSLV">Delivery schedule level</param>
		/// <param name="m3DTTP">Date type</param>
		/// <param name="m3RSRN">Partner´s design revision number</param>
		/// <param name="m3RSEC">Partner´s engineering change order no</param>
		/// <param name="m3RSED">Engineering change order date</param>
		/// <param name="m3RSPS">Previous delivery schedule number</param>
		/// <param name="m3ITRL">Status - item release</param>
		/// <param name="m3NEWE">Net weight</param>
		/// <param name="m3GRWE">Gross weight</param>
		/// <param name="m3VOL3">Volume</param>
		/// <param name="m3CUPA">Customers packaging identity</param>
		/// <param name="m3D1QT">Standard quantity (Replaced by D1Q2)</param>
		/// <param name="m3PARE">Package reference</param>
		/// <param name="m3AMKO">Number of packages</param>
		/// <param name="m3CUMY">Customer´s model year</param>
		/// <param name="m3SAPR">Sales price</param>
		/// <param name="m3SACD">Sales price quantity</param>
		/// <param name="m3CUCS">Currency - sales price</param>
		/// <param name="m3SPUN">Sales price unit of measure</param>
		/// <param name="m3EXPI">Expiration date</param>
		/// <param name="m3CDLP">Customer´s delivery pattern</param>
		/// <param name="m3RSK2">Customer´s internal kanban card number</param>
		/// <param name="m3ECNM">EU number</param>
		/// <param name="m3AUSD">Authorization firm to date</param>
		/// <param name="m3AUST">Firm period qualifier</param>
		/// <param name="m3AUSP">Firm periods</param>
		/// <param name="m3AUFD">Authorization fabrication to date</param>
		/// <param name="m3AUFT">Fabrication period qualifier</param>
		/// <param name="m3AUFP">Fabrication periods</param>
		/// <param name="m3AUMD">Authorization material to date</param>
		/// <param name="m3AUMT">Material period qualifier</param>
		/// <param name="m3AUMP">Material periods</param>
		/// <param name="m3AUUD">Forecast to date</param>
		/// <param name="m3AUUT">Forecast period qualifier</param>
		/// <param name="m3AUUP">Forecast periods</param>
		/// <param name="m3AUXD">Reference agreement to date</param>
		/// <param name="m3AUXT">Total quantity reference agreement</param>
		/// <param name="m3AUXP">Reference agreement period qualifier</param>
		/// <param name="m3CFIN">Configuration number</param>
		/// <param name="m3D1Q2">Standard quantity</param>
		/// <param name="m3MOYE">Model/Year</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdItem(
			string m3ODPN, 
			int m3ODPI, 
			int? m3CONO = null, 
			string m3DIVI = null, 
			string m3POPN = null, 
			int? m3ALWT = null, 
			string m3ALWQ = null, 
			string m3ITNO = null, 
			string m3ITDS = null, 
			string m3UNIT = null, 
			string m3ORCO = null, 
			string m3WHLO = null, 
			string m3FACI = null, 
			string m3CUOR = null, 
			DateTime? m3CUDT = null, 
			string m3RSAG = null, 
			int? m3RSAC = null, 
			string m3PUSN = null, 
			int? m3PUTP = null, 
			int? m3CFXX = null, 
			int? m3DSLV = null, 
			int? m3DTTP = null, 
			string m3RSRN = null, 
			string m3RSEC = null, 
			DateTime? m3RSED = null, 
			string m3RSPS = null, 
			string m3ITRL = null, 
			decimal? m3NEWE = null, 
			decimal? m3GRWE = null, 
			decimal? m3VOL3 = null, 
			string m3CUPA = null, 
			decimal? m3D1QT = null, 
			string m3PARE = null, 
			int? m3AMKO = null, 
			string m3CUMY = null, 
			decimal? m3SAPR = null, 
			int? m3SACD = null, 
			string m3CUCS = null, 
			string m3SPUN = null, 
			DateTime? m3EXPI = null, 
			string m3CDLP = null, 
			string m3RSK2 = null, 
			string m3ECNM = null, 
			DateTime? m3AUSD = null, 
			int? m3AUST = null, 
			int? m3AUSP = null, 
			DateTime? m3AUFD = null, 
			int? m3AUFT = null, 
			int? m3AUFP = null, 
			DateTime? m3AUMD = null, 
			int? m3AUMT = null, 
			int? m3AUMP = null, 
			DateTime? m3AUUD = null, 
			int? m3AUUT = null, 
			int? m3AUUP = null, 
			DateTime? m3AUXD = null, 
			int? m3AUXT = null, 
			int? m3AUXP = null, 
			long? m3CFIN = null, 
			decimal? m3D1Q2 = null, 
			string m3MOYE = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdItem",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ODPN))
				throw new ArgumentNullException(nameof(m3ODPN));

			// Set mandatory parameters
			request
				.WithQueryParameter("ODPN", m3ODPN.Trim())
				.WithQueryParameter("ODPI", m3ODPI.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (m3ALWT.HasValue)
				request.WithQueryParameter("ALWT", m3ALWT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ALWQ))
				request.WithQueryParameter("ALWQ", m3ALWQ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3UNIT))
				request.WithQueryParameter("UNIT", m3UNIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORCO))
				request.WithQueryParameter("ORCO", m3ORCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (m3CUDT.HasValue)
				request.WithQueryParameter("CUDT", m3CUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3RSAG))
				request.WithQueryParameter("RSAG", m3RSAG.Trim());
			if (m3RSAC.HasValue)
				request.WithQueryParameter("RSAC", m3RSAC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PUSN))
				request.WithQueryParameter("PUSN", m3PUSN.Trim());
			if (m3PUTP.HasValue)
				request.WithQueryParameter("PUTP", m3PUTP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CFXX.HasValue)
				request.WithQueryParameter("CFXX", m3CFXX.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DSLV.HasValue)
				request.WithQueryParameter("DSLV", m3DSLV.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DTTP.HasValue)
				request.WithQueryParameter("DTTP", m3DTTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RSRN))
				request.WithQueryParameter("RSRN", m3RSRN.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSEC))
				request.WithQueryParameter("RSEC", m3RSEC.Trim());
			if (m3RSED.HasValue)
				request.WithQueryParameter("RSED", m3RSED.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3RSPS))
				request.WithQueryParameter("RSPS", m3RSPS.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITRL))
				request.WithQueryParameter("ITRL", m3ITRL.Trim());
			if (m3NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3NEWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3GRWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3VOL3.HasValue)
				request.WithQueryParameter("VOL3", m3VOL3.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUPA))
				request.WithQueryParameter("CUPA", m3CUPA.Trim());
			if (m3D1QT.HasValue)
				request.WithQueryParameter("D1QT", m3D1QT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PARE))
				request.WithQueryParameter("PARE", m3PARE.Trim());
			if (m3AMKO.HasValue)
				request.WithQueryParameter("AMKO", m3AMKO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUMY))
				request.WithQueryParameter("CUMY", m3CUMY.Trim());
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SACD.HasValue)
				request.WithQueryParameter("SACD", m3SACD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CUCS))
				request.WithQueryParameter("CUCS", m3CUCS.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPUN))
				request.WithQueryParameter("SPUN", m3SPUN.Trim());
			if (m3EXPI.HasValue)
				request.WithQueryParameter("EXPI", m3EXPI.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CDLP))
				request.WithQueryParameter("CDLP", m3CDLP.Trim());
			if (!string.IsNullOrWhiteSpace(m3RSK2))
				request.WithQueryParameter("RSK2", m3RSK2.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECNM))
				request.WithQueryParameter("ECNM", m3ECNM.Trim());
			if (m3AUSD.HasValue)
				request.WithQueryParameter("AUSD", m3AUSD.Value.ToM3String());
			if (m3AUST.HasValue)
				request.WithQueryParameter("AUST", m3AUST.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUSP.HasValue)
				request.WithQueryParameter("AUSP", m3AUSP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUFD.HasValue)
				request.WithQueryParameter("AUFD", m3AUFD.Value.ToM3String());
			if (m3AUFT.HasValue)
				request.WithQueryParameter("AUFT", m3AUFT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUFP.HasValue)
				request.WithQueryParameter("AUFP", m3AUFP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUMD.HasValue)
				request.WithQueryParameter("AUMD", m3AUMD.Value.ToM3String());
			if (m3AUMT.HasValue)
				request.WithQueryParameter("AUMT", m3AUMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUMP.HasValue)
				request.WithQueryParameter("AUMP", m3AUMP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUUD.HasValue)
				request.WithQueryParameter("AUUD", m3AUUD.Value.ToM3String());
			if (m3AUUT.HasValue)
				request.WithQueryParameter("AUUT", m3AUUT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUUP.HasValue)
				request.WithQueryParameter("AUUP", m3AUUP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUXD.HasValue)
				request.WithQueryParameter("AUXD", m3AUXD.Value.ToM3String());
			if (m3AUXT.HasValue)
				request.WithQueryParameter("AUXT", m3AUXT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AUXP.HasValue)
				request.WithQueryParameter("AUXP", m3AUXP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CFIN.HasValue)
				request.WithQueryParameter("CFIN", m3CFIN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D1Q2.HasValue)
				request.WithQueryParameter("D1Q2", m3D1Q2.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3MOYE))
				request.WithQueryParameter("MOYE", m3MOYE.Trim());

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
