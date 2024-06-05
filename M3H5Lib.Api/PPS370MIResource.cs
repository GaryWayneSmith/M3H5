/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.PPS370MI;
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
	/// Name: PPS370MI
	/// Component Name: PUR
	/// Description: Api: Purchase order batch entry
	/// Version Release: 5e90
	///</summary>
	public partial class PPS370MIResource : M3BaseResourceEndpoint
	{
		public PPS370MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "PPS370MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAccString
		/// Description Add accounting string
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="m3_PUNO">Purchase order number</param>
		/// <param name="m3_HREF">Purchase order head reference</param>
		/// <param name="m3_PNLI">Purchase order line</param>
		/// <param name="m3_LREF">Purchase order line reference</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_AIT1">Accounting dimension 1</param>
		/// <param name="m3_AIT2">Accounting dimension 2</param>
		/// <param name="m3_AIT3">Accounting dimension 3</param>
		/// <param name="m3_AIT4">Accounting dimension 4</param>
		/// <param name="m3_AIT5">Accounting dimension 5</param>
		/// <param name="m3_AIT6">Accounting dimension 6</param>
		/// <param name="m3_AIT7">Accounting dimension 7</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAccString(
			string m3_MSGN, 
			string m3_PUNO = null, 
			string m3_HREF = null, 
			int? m3_PNLI = null, 
			string m3_LREF = null, 
			string m3_SUNO = null, 
			string m3_AIT1 = null, 
			string m3_AIT2 = null, 
			string m3_AIT3 = null, 
			string m3_AIT4 = null, 
			string m3_AIT5 = null, 
			string m3_AIT6 = null, 
			string m3_AIT7 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddAccString",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3_MSGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PUNO))
				request.WithQueryParameter("PUNO", m3_PUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HREF))
				request.WithQueryParameter("HREF", m3_HREF.Trim());
			if (m3_PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3_PNLI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LREF))
				request.WithQueryParameter("LREF", m3_LREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT1))
				request.WithQueryParameter("AIT1", m3_AIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT2))
				request.WithQueryParameter("AIT2", m3_AIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT3))
				request.WithQueryParameter("AIT3", m3_AIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT4))
				request.WithQueryParameter("AIT4", m3_AIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT5))
				request.WithQueryParameter("AIT5", m3_AIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT6))
				request.WithQueryParameter("AIT6", m3_AIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AIT7))
				request.WithQueryParameter("AIT7", m3_AIT7.Trim());

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
		/// Name AddAddress
		/// Description Add address
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="m3_POAD">PO address type (Required)</param>
		/// <param name="m3_PUNO">Purchase order number</param>
		/// <param name="m3_HREF">Purchase order head reference</param>
		/// <param name="m3_PNLI">Purchase order line</param>
		/// <param name="m3_LREF">Purchase order line reference</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_CONM">Company name</param>
		/// <param name="m3_ADR1">Address line 1</param>
		/// <param name="m3_ADR2">Address line 2</param>
		/// <param name="m3_ADR3">Address line 3</param>
		/// <param name="m3_ADR4">Address line 4</param>
		/// <param name="m3_TOWN">City</param>
		/// <param name="m3_ECAR">State</param>
		/// <param name="m3_PONO">Postal code</param>
		/// <param name="m3_CSCD">Country</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_FRCO">County ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAddress(
			string m3_MSGN, 
			int m3_POAD, 
			string m3_PUNO = null, 
			string m3_HREF = null, 
			int? m3_PNLI = null, 
			string m3_LREF = null, 
			string m3_SUNO = null, 
			string m3_CONM = null, 
			string m3_ADR1 = null, 
			string m3_ADR2 = null, 
			string m3_ADR3 = null, 
			string m3_ADR4 = null, 
			string m3_TOWN = null, 
			string m3_ECAR = null, 
			string m3_PONO = null, 
			string m3_CSCD = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			string m3_FRCO = null, 
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

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3_MSGN.Trim())
				.WithQueryParameter("POAD", m3_POAD.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PUNO))
				request.WithQueryParameter("PUNO", m3_PUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HREF))
				request.WithQueryParameter("HREF", m3_HREF.Trim());
			if (m3_PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3_PNLI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LREF))
				request.WithQueryParameter("LREF", m3_LREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3_TOWN))
				request.WithQueryParameter("TOWN", m3_TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECAR))
				request.WithQueryParameter("ECAR", m3_ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PONO))
				request.WithQueryParameter("PONO", m3_PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSCD))
				request.WithQueryParameter("CSCD", m3_CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRCO))
				request.WithQueryParameter("FRCO", m3_FRCO.Trim());

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
		/// Name AddCharge
		/// Description Add charge
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="m3_SUCE">Supplier costing element (Required)</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_PUNO">Purchase order number</param>
		/// <param name="m3_HREF">Purchase order head reference</param>
		/// <param name="m3_PNLI">Purchase order line</param>
		/// <param name="m3_LREF">Purchase order line reference</param>
		/// <param name="m3_CDSE">Sequence number - costing element</param>
		/// <param name="m3_CEVA">Costing element amount</param>
		/// <param name="m3_OVHE">Costing markup</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCharge(
			string m3_MSGN, 
			string m3_SUCE, 
			string m3_SUNO = null, 
			string m3_PUNO = null, 
			string m3_HREF = null, 
			int? m3_PNLI = null, 
			string m3_LREF = null, 
			int? m3_CDSE = null, 
			decimal? m3_CEVA = null, 
			decimal? m3_OVHE = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddCharge",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");
			if (string.IsNullOrWhiteSpace(m3_SUCE))
				throw new ArgumentNullException("m3_SUCE");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3_MSGN.Trim())
				.WithQueryParameter("SUCE", m3_SUCE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PUNO))
				request.WithQueryParameter("PUNO", m3_PUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HREF))
				request.WithQueryParameter("HREF", m3_HREF.Trim());
			if (m3_PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3_PNLI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LREF))
				request.WithQueryParameter("LREF", m3_LREF.Trim());
			if (m3_CDSE.HasValue)
				request.WithQueryParameter("CDSE", m3_CDSE.Value.ToString());
			if (m3_CEVA.HasValue)
				request.WithQueryParameter("CEVA", m3_CEVA.Value.ToString());
			if (m3_OVHE.HasValue)
				request.WithQueryParameter("OVHE", m3_OVHE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());

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
		/// Name AddHead
		/// Description Add order head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_SUNO">Supplier number (Required)</param>
		/// <param name="m3_DWDT">Requested delivery date (Required)</param>
		/// <param name="m3_HREF">Purchase order head reference</param>
		/// <param name="m3_ORTY">Order type</param>
		/// <param name="m3_CMCO">Communication code</param>
		/// <param name="m3_PUDT">Order date</param>
		/// <param name="m3_LNCD">Language</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_PYME">Payment method - accounts payable</param>
		/// <param name="m3_MODL">Delivery method</param>
		/// <param name="m3_TEDL">Delivery terms</param>
		/// <param name="m3_TEAF">Freight terms</param>
		/// <param name="m3_TEPA">Packaging terms</param>
		/// <param name="m3_YRE1">Your reference</param>
		/// <param name="m3_PRSU">Payee</param>
		/// <param name="m3_OURR">Our reference number</param>
		/// <param name="m3_OURT">Reference type</param>
		/// <param name="m3_AGNT">Recipient agreement type 1 - commission</param>
		/// <param name="m3_PURC">Requisition by</param>
		/// <param name="m3_BUYE">Buyer</param>
		/// <param name="m3_FUSC">Monitoring activity list</param>
		/// <param name="m3_TFNO">Facsimile transmission number</param>
		/// <param name="m3_LRED">Last reply date</param>
		/// <param name="m3_TEL1">Terms text</param>
		/// <param name="m3_DUDT">Due date</param>
		/// <param name="m3_CUTE">Currency terms</param>
		/// <param name="m3_AGRA">Agreed rate</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_HAFE">Harbor or airport</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_RASN">Rail station</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddHeadResponse></returns>
		/// <exception cref="M3Exception<AddHeadResponse>"></exception>
		public async Task<M3Response<AddHeadResponse>> AddHead(
			string m3_MSGN, 
			string m3_FACI, 
			string m3_WHLO, 
			string m3_SUNO, 
			DateTime m3_DWDT, 
			string m3_HREF = null, 
			string m3_ORTY = null, 
			string m3_CMCO = null, 
			DateTime? m3_PUDT = null, 
			string m3_LNCD = null, 
			string m3_CUCD = null, 
			string m3_TEPY = null, 
			string m3_PYME = null, 
			string m3_MODL = null, 
			string m3_TEDL = null, 
			string m3_TEAF = null, 
			string m3_TEPA = null, 
			string m3_YRE1 = null, 
			string m3_PRSU = null, 
			string m3_OURR = null, 
			string m3_OURT = null, 
			string m3_AGNT = null, 
			string m3_PURC = null, 
			string m3_BUYE = null, 
			string m3_FUSC = null, 
			string m3_TFNO = null, 
			DateTime? m3_LRED = null, 
			string m3_TEL1 = null, 
			DateTime? m3_DUDT = null, 
			int? m3_CUTE = null, 
			decimal? m3_AGRA = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_HAFE = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			string m3_RASN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_SUNO))
				throw new ArgumentNullException("m3_SUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3_MSGN.Trim())
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("SUNO", m3_SUNO.Trim())
				.WithQueryParameter("DWDT", m3_DWDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_HREF))
				request.WithQueryParameter("HREF", m3_HREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORTY))
				request.WithQueryParameter("ORTY", m3_ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CMCO))
				request.WithQueryParameter("CMCO", m3_CMCO.Trim());
			if (m3_PUDT.HasValue)
				request.WithQueryParameter("PUDT", m3_PUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_LNCD))
				request.WithQueryParameter("LNCD", m3_LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYME))
				request.WithQueryParameter("PYME", m3_PYME.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MODL))
				request.WithQueryParameter("MODL", m3_MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEDL))
				request.WithQueryParameter("TEDL", m3_TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEAF))
				request.WithQueryParameter("TEAF", m3_TEAF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPA))
				request.WithQueryParameter("TEPA", m3_TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_YRE1))
				request.WithQueryParameter("YRE1", m3_YRE1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRSU))
				request.WithQueryParameter("PRSU", m3_PRSU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OURR))
				request.WithQueryParameter("OURR", m3_OURR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OURT))
				request.WithQueryParameter("OURT", m3_OURT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGNT))
				request.WithQueryParameter("AGNT", m3_AGNT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PURC))
				request.WithQueryParameter("PURC", m3_PURC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BUYE))
				request.WithQueryParameter("BUYE", m3_BUYE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FUSC))
				request.WithQueryParameter("FUSC", m3_FUSC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFNO))
				request.WithQueryParameter("TFNO", m3_TFNO.Trim());
			if (m3_LRED.HasValue)
				request.WithQueryParameter("LRED", m3_LRED.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_TEL1))
				request.WithQueryParameter("TEL1", m3_TEL1.Trim());
			if (m3_DUDT.HasValue)
				request.WithQueryParameter("DUDT", m3_DUDT.Value.ToM3String());
			if (m3_CUTE.HasValue)
				request.WithQueryParameter("CUTE", m3_CUTE.Value.ToString());
			if (m3_AGRA.HasValue)
				request.WithQueryParameter("AGRA", m3_AGRA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HAFE))
				request.WithQueryParameter("HAFE", m3_HAFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RASN))
				request.WithQueryParameter("RASN", m3_RASN.Trim());

			// Execute the request
			var result = await Execute<AddHeadResponse>(
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
		/// Name AddLine
		/// Description Add order line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_ORQA">Ordered quantity - alternate U/M (Required)</param>
		/// <param name="m3_PUNO">Purchase order number</param>
		/// <param name="m3_HREF">Purchase order head reference</param>
		/// <param name="m3_PNLI">Purchase order line</param>
		/// <param name="m3_LREF">Purchase order line reference</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_DWDT">Requested delivery date</param>
		/// <param name="m3_SITE">Supplier item number</param>
		/// <param name="m3_PITD">Purchase order item name</param>
		/// <param name="m3_PITT">Purchase order item description</param>
		/// <param name="m3_PROD">Manufacturer</param>
		/// <param name="m3_ECVE">Revision number</param>
		/// <param name="m3_REVN">Revision number</param>
		/// <param name="m3_ETRF">External instruction</param>
		/// <param name="m3_PUPR">Purchase price</param>
		/// <param name="m3_ODI1">Discount 1</param>
		/// <param name="m3_ODI2">Discount 2</param>
		/// <param name="m3_ODI3">Discount 3</param>
		/// <param name="m3_PUUN">Purchase order U/M</param>
		/// <param name="m3_PPUN">Purchase price U/M</param>
		/// <param name="m3_PUCD">Purchase price quantity</param>
		/// <param name="m3_PTCD">Purchase price text</param>
		/// <param name="m3_RORC">Reference order category</param>
		/// <param name="m3_RORN">Reference order number</param>
		/// <param name="m3_RORL">Reference order line</param>
		/// <param name="m3_RORX">Line suffix</param>
		/// <param name="m3_OURR">Our reference number</param>
		/// <param name="m3_OURT">Reference type</param>
		/// <param name="m3_PRIP">Priority</param>
		/// <param name="m3_FUSC">Monitoring activity list</param>
		/// <param name="m3_PURC">Requisition by</param>
		/// <param name="m3_BUYE">Buyer</param>
		/// <param name="m3_TERE">Technical supervisor</param>
		/// <param name="m3_GRMT">Goods receiving method</param>
		/// <param name="m3_IRCV">Recipient</param>
		/// <param name="m3_PACT">Packaging</param>
		/// <param name="m3_VTCD">VAT code</param>
		/// <param name="m3_ACRF">User-defined accounting control object</param>
		/// <param name="m3_COCE">Cost center</param>
		/// <param name="m3_CSNO">Customs statistical number</param>
		/// <param name="m3_ECLC">Labor code - trade statistics (TST)</param>
		/// <param name="m3_VRCD">Business type - trade statistics (TST)</param>
		/// <param name="m3_PROJ">Project number</param>
		/// <param name="m3_ELNO">Project element</param>
		/// <param name="m3_CPRI">Customs procedure - import</param>
		/// <param name="m3_HAFE">Harbor or airport</param>
		/// <param name="m3_TAXC">Tax code customer/address</param>
		/// <param name="m3_TIHM">Time hours & minutes</param>
		/// <param name="m3_MSTN">Milestone chain</param>
		/// <param name="m3_UPCK">Unpack</param>
		/// <param name="m3_USD1">User-defined field</param>
		/// <param name="m3_USD2">User-defined field</param>
		/// <param name="m3_USD3">User-defined field</param>
		/// <param name="m3_USD4">User-defined field</param>
		/// <param name="m3_USD5">User-defined field</param>
		/// <param name="m3_ORCO">Country of origin</param>
		/// <param name="m3_GEOC">Geographical code</param>
		/// <param name="m3_TRRC">Order relation category</param>
		/// <param name="m3_TRRN">Order relation number</param>
		/// <param name="m3_TRRL">Reference order line</param>
		/// <param name="m3_TRRX">Line suffix trade-in</param>
		/// <param name="m3_RASN">Rail station</param>
		/// <param name="m3_PIAD">Pickup address number</param>
		/// <param name="m3_ORAD">Origin Address</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddLineResponse></returns>
		/// <exception cref="M3Exception<AddLineResponse>"></exception>
		public async Task<M3Response<AddLineResponse>> AddLine(
			string m3_MSGN, 
			string m3_ITNO, 
			decimal m3_ORQA, 
			string m3_PUNO = null, 
			string m3_HREF = null, 
			int? m3_PNLI = null, 
			string m3_LREF = null, 
			string m3_FACI = null, 
			string m3_WHLO = null, 
			string m3_SUNO = null, 
			DateTime? m3_DWDT = null, 
			string m3_SITE = null, 
			string m3_PITD = null, 
			string m3_PITT = null, 
			string m3_PROD = null, 
			string m3_ECVE = null, 
			string m3_REVN = null, 
			string m3_ETRF = null, 
			decimal? m3_PUPR = null, 
			int? m3_ODI1 = null, 
			int? m3_ODI2 = null, 
			int? m3_ODI3 = null, 
			string m3_PUUN = null, 
			string m3_PPUN = null, 
			int? m3_PUCD = null, 
			int? m3_PTCD = null, 
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			int? m3_RORX = null, 
			string m3_OURR = null, 
			string m3_OURT = null, 
			string m3_PRIP = null, 
			string m3_FUSC = null, 
			string m3_PURC = null, 
			string m3_BUYE = null, 
			string m3_TERE = null, 
			string m3_GRMT = null, 
			string m3_IRCV = null, 
			string m3_PACT = null, 
			int? m3_VTCD = null, 
			string m3_ACRF = null, 
			string m3_COCE = null, 
			string m3_CSNO = null, 
			string m3_ECLC = null, 
			string m3_VRCD = null, 
			string m3_PROJ = null, 
			string m3_ELNO = null, 
			string m3_CPRI = null, 
			string m3_HAFE = null, 
			string m3_TAXC = null, 
			int? m3_TIHM = null, 
			long? m3_MSTN = null, 
			int? m3_UPCK = null, 
			string m3_USD1 = null, 
			string m3_USD2 = null, 
			string m3_USD3 = null, 
			string m3_USD4 = null, 
			string m3_USD5 = null, 
			string m3_ORCO = null, 
			int? m3_GEOC = null, 
			int? m3_TRRC = null, 
			string m3_TRRN = null, 
			int? m3_TRRL = null, 
			int? m3_TRRX = null, 
			string m3_RASN = null, 
			string m3_PIAD = null, 
			string m3_ORAD = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3_MSGN.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("ORQA", m3_ORQA.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PUNO))
				request.WithQueryParameter("PUNO", m3_PUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HREF))
				request.WithQueryParameter("HREF", m3_HREF.Trim());
			if (m3_PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3_PNLI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LREF))
				request.WithQueryParameter("LREF", m3_LREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (m3_DWDT.HasValue)
				request.WithQueryParameter("DWDT", m3_DWDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_SITE))
				request.WithQueryParameter("SITE", m3_SITE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PITD))
				request.WithQueryParameter("PITD", m3_PITD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PITT))
				request.WithQueryParameter("PITT", m3_PITT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROD))
				request.WithQueryParameter("PROD", m3_PROD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECVE))
				request.WithQueryParameter("ECVE", m3_ECVE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_REVN))
				request.WithQueryParameter("REVN", m3_REVN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ETRF))
				request.WithQueryParameter("ETRF", m3_ETRF.Trim());
			if (m3_PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3_PUPR.Value.ToString());
			if (m3_ODI1.HasValue)
				request.WithQueryParameter("ODI1", m3_ODI1.Value.ToString());
			if (m3_ODI2.HasValue)
				request.WithQueryParameter("ODI2", m3_ODI2.Value.ToString());
			if (m3_ODI3.HasValue)
				request.WithQueryParameter("ODI3", m3_ODI3.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_PUUN))
				request.WithQueryParameter("PUUN", m3_PUUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PPUN))
				request.WithQueryParameter("PPUN", m3_PPUN.Trim());
			if (m3_PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3_PUCD.Value.ToString());
			if (m3_PTCD.HasValue)
				request.WithQueryParameter("PTCD", m3_PTCD.Value.ToString());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OURR))
				request.WithQueryParameter("OURR", m3_OURR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OURT))
				request.WithQueryParameter("OURT", m3_OURT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PRIP))
				request.WithQueryParameter("PRIP", m3_PRIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FUSC))
				request.WithQueryParameter("FUSC", m3_FUSC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PURC))
				request.WithQueryParameter("PURC", m3_PURC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BUYE))
				request.WithQueryParameter("BUYE", m3_BUYE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TERE))
				request.WithQueryParameter("TERE", m3_TERE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_GRMT))
				request.WithQueryParameter("GRMT", m3_GRMT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IRCV))
				request.WithQueryParameter("IRCV", m3_IRCV.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PACT))
				request.WithQueryParameter("PACT", m3_PACT.Trim());
			if (m3_VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3_VTCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ACRF))
				request.WithQueryParameter("ACRF", m3_ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_COCE))
				request.WithQueryParameter("COCE", m3_COCE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CSNO))
				request.WithQueryParameter("CSNO", m3_CSNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECLC))
				request.WithQueryParameter("ECLC", m3_ECLC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_VRCD))
				request.WithQueryParameter("VRCD", m3_VRCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROJ))
				request.WithQueryParameter("PROJ", m3_PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ELNO))
				request.WithQueryParameter("ELNO", m3_ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CPRI))
				request.WithQueryParameter("CPRI", m3_CPRI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HAFE))
				request.WithQueryParameter("HAFE", m3_HAFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAXC))
				request.WithQueryParameter("TAXC", m3_TAXC.Trim());
			if (m3_TIHM.HasValue)
				request.WithQueryParameter("TIHM", m3_TIHM.Value.ToString());
			if (m3_MSTN.HasValue)
				request.WithQueryParameter("MSTN", m3_MSTN.Value.ToString());
			if (m3_UPCK.HasValue)
				request.WithQueryParameter("UPCK", m3_UPCK.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_USD1))
				request.WithQueryParameter("USD1", m3_USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD2))
				request.WithQueryParameter("USD2", m3_USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD3))
				request.WithQueryParameter("USD3", m3_USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD4))
				request.WithQueryParameter("USD4", m3_USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USD5))
				request.WithQueryParameter("USD5", m3_USD5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORCO))
				request.WithQueryParameter("ORCO", m3_ORCO.Trim());
			if (m3_GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3_GEOC.Value.ToString());
			if (m3_TRRC.HasValue)
				request.WithQueryParameter("TRRC", m3_TRRC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TRRN))
				request.WithQueryParameter("TRRN", m3_TRRN.Trim());
			if (m3_TRRL.HasValue)
				request.WithQueryParameter("TRRL", m3_TRRL.Value.ToString());
			if (m3_TRRX.HasValue)
				request.WithQueryParameter("TRRX", m3_TRRX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RASN))
				request.WithQueryParameter("RASN", m3_RASN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PIAD))
				request.WithQueryParameter("PIAD", m3_PIAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORAD))
				request.WithQueryParameter("ORAD", m3_ORAD.Trim());

			// Execute the request
			var result = await Execute<AddLineResponse>(
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
		/// Name AddText
		/// Description Add text
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="m3_PUNO">Purchase order number</param>
		/// <param name="m3_HREF">Purchase order head reference</param>
		/// <param name="m3_PNLI">Purchase order line</param>
		/// <param name="m3_LREF">Purchase order line reference</param>
		/// <param name="m3_SUNO">Supplier number</param>
		/// <param name="m3_TXVR">Text block</param>
		/// <param name="m3_SQNR">Sequence number</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TXT1">Text</param>
		/// <param name="m3_TXT2">Text</param>
		/// <param name="m3_TXT3">Text</param>
		/// <param name="m3_TXT4">Text</param>
		/// <param name="m3_TXT5">Text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddText(
			string m3_MSGN, 
			string m3_PUNO = null, 
			string m3_HREF = null, 
			int? m3_PNLI = null, 
			string m3_LREF = null, 
			string m3_SUNO = null, 
			string m3_TXVR = null, 
			int? m3_SQNR = null, 
			string m3_TX40 = null, 
			string m3_TXT1 = null, 
			string m3_TXT2 = null, 
			string m3_TXT3 = null, 
			string m3_TXT4 = null, 
			string m3_TXT5 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3_MSGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PUNO))
				request.WithQueryParameter("PUNO", m3_PUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_HREF))
				request.WithQueryParameter("HREF", m3_HREF.Trim());
			if (m3_PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3_PNLI.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_LREF))
				request.WithQueryParameter("LREF", m3_LREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXVR))
				request.WithQueryParameter("TXVR", m3_TXVR.Trim());
			if (m3_SQNR.HasValue)
				request.WithQueryParameter("SQNR", m3_SQNR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXT1))
				request.WithQueryParameter("TXT1", m3_TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXT2))
				request.WithQueryParameter("TXT2", m3_TXT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXT3))
				request.WithQueryParameter("TXT3", m3_TXT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXT4))
				request.WithQueryParameter("TXT4", m3_TXT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXT5))
				request.WithQueryParameter("TXT5", m3_TXT5.Trim());

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
		/// Name DeleteEntry
		/// Description Delete entry
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeleteEntry(
			string m3_MSGN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DeleteEntry",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3_MSGN.Trim());

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
		/// Name FinishEntry
		/// Description Finish entry
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MSGN">Message number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> FinishEntry(
			string m3_MSGN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/FinishEntry",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MSGN))
				throw new ArgumentNullException("m3_MSGN");

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3_MSGN.Trim());

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
		/// Name StartEntry
		/// Description Start entry
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_BAOR">Batch origin (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<StartEntryResponse></returns>
		/// <exception cref="M3Exception<StartEntryResponse>"></exception>
		public async Task<M3Response<StartEntryResponse>> StartEntry(
			string m3_BAOR, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/StartEntry",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BAOR))
				throw new ArgumentNullException("m3_BAOR");

			// Set mandatory parameters
			request
				.WithQueryParameter("BAOR", m3_BAOR.Trim());

			// Execute the request
			var result = await Execute<StartEntryResponse>(
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
