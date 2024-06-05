/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddAccString
		/// Description Add accounting string
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="m3PUNO">Purchase order number</param>
		/// <param name="m3HREF">Purchase order head reference</param>
		/// <param name="m3PNLI">Purchase order line</param>
		/// <param name="m3LREF">Purchase order line reference</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3AIT1">Accounting dimension 1</param>
		/// <param name="m3AIT2">Accounting dimension 2</param>
		/// <param name="m3AIT3">Accounting dimension 3</param>
		/// <param name="m3AIT4">Accounting dimension 4</param>
		/// <param name="m3AIT5">Accounting dimension 5</param>
		/// <param name="m3AIT6">Accounting dimension 6</param>
		/// <param name="m3AIT7">Accounting dimension 7</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAccString(
			string m3MSGN, 
			string m3PUNO = null, 
			string m3HREF = null, 
			int? m3PNLI = null, 
			string m3LREF = null, 
			string m3SUNO = null, 
			string m3AIT1 = null, 
			string m3AIT2 = null, 
			string m3AIT3 = null, 
			string m3AIT4 = null, 
			string m3AIT5 = null, 
			string m3AIT6 = null, 
			string m3AIT7 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddAccString",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3MSGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PUNO))
				request.WithQueryParameter("PUNO", m3PUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3HREF))
				request.WithQueryParameter("HREF", m3HREF.Trim());
			if (m3PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3PNLI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LREF))
				request.WithQueryParameter("LREF", m3LREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT1))
				request.WithQueryParameter("AIT1", m3AIT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT2))
				request.WithQueryParameter("AIT2", m3AIT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT3))
				request.WithQueryParameter("AIT3", m3AIT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT4))
				request.WithQueryParameter("AIT4", m3AIT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT5))
				request.WithQueryParameter("AIT5", m3AIT5.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT6))
				request.WithQueryParameter("AIT6", m3AIT6.Trim());
			if (!string.IsNullOrWhiteSpace(m3AIT7))
				request.WithQueryParameter("AIT7", m3AIT7.Trim());

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
		/// Name AddAddress
		/// Description Add address
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="m3POAD">PO address type (Required)</param>
		/// <param name="m3PUNO">Purchase order number</param>
		/// <param name="m3HREF">Purchase order head reference</param>
		/// <param name="m3PNLI">Purchase order line</param>
		/// <param name="m3LREF">Purchase order line reference</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3CONM">Company name</param>
		/// <param name="m3ADR1">Address line 1</param>
		/// <param name="m3ADR2">Address line 2</param>
		/// <param name="m3ADR3">Address line 3</param>
		/// <param name="m3ADR4">Address line 4</param>
		/// <param name="m3TOWN">City</param>
		/// <param name="m3ECAR">State</param>
		/// <param name="m3PONO">Postal code</param>
		/// <param name="m3CSCD">Country</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3FRCO">County ID</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddAddress(
			string m3MSGN, 
			int m3POAD, 
			string m3PUNO = null, 
			string m3HREF = null, 
			int? m3PNLI = null, 
			string m3LREF = null, 
			string m3SUNO = null, 
			string m3CONM = null, 
			string m3ADR1 = null, 
			string m3ADR2 = null, 
			string m3ADR3 = null, 
			string m3ADR4 = null, 
			string m3TOWN = null, 
			string m3ECAR = null, 
			string m3PONO = null, 
			string m3CSCD = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			string m3FRCO = null, 
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

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3MSGN.Trim())
				.WithQueryParameter("POAD", m3POAD.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PUNO))
				request.WithQueryParameter("PUNO", m3PUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3HREF))
				request.WithQueryParameter("HREF", m3HREF.Trim());
			if (m3PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3PNLI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LREF))
				request.WithQueryParameter("LREF", m3LREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
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
			if (!string.IsNullOrWhiteSpace(m3TOWN))
				request.WithQueryParameter("TOWN", m3TOWN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECAR))
				request.WithQueryParameter("ECAR", m3ECAR.Trim());
			if (!string.IsNullOrWhiteSpace(m3PONO))
				request.WithQueryParameter("PONO", m3PONO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSCD))
				request.WithQueryParameter("CSCD", m3CSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRCO))
				request.WithQueryParameter("FRCO", m3FRCO.Trim());

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
		/// Name AddCharge
		/// Description Add charge
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="m3SUCE">Supplier costing element (Required)</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3PUNO">Purchase order number</param>
		/// <param name="m3HREF">Purchase order head reference</param>
		/// <param name="m3PNLI">Purchase order line</param>
		/// <param name="m3LREF">Purchase order line reference</param>
		/// <param name="m3CDSE">Sequence number - costing element</param>
		/// <param name="m3CEVA">Costing element amount</param>
		/// <param name="m3OVHE">Costing markup</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddCharge(
			string m3MSGN, 
			string m3SUCE, 
			string m3SUNO = null, 
			string m3PUNO = null, 
			string m3HREF = null, 
			int? m3PNLI = null, 
			string m3LREF = null, 
			int? m3CDSE = null, 
			decimal? m3CEVA = null, 
			decimal? m3OVHE = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddCharge",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));
			if (string.IsNullOrWhiteSpace(m3SUCE))
				throw new ArgumentNullException(nameof(m3SUCE));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3MSGN.Trim())
				.WithQueryParameter("SUCE", m3SUCE.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PUNO))
				request.WithQueryParameter("PUNO", m3PUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3HREF))
				request.WithQueryParameter("HREF", m3HREF.Trim());
			if (m3PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3PNLI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LREF))
				request.WithQueryParameter("LREF", m3LREF.Trim());
			if (m3CDSE.HasValue)
				request.WithQueryParameter("CDSE", m3CDSE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CEVA.HasValue)
				request.WithQueryParameter("CEVA", m3CEVA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OVHE.HasValue)
				request.WithQueryParameter("OVHE", m3OVHE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());

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
		/// Name AddHead
		/// Description Add order head
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3SUNO">Supplier number (Required)</param>
		/// <param name="m3DWDT">Requested delivery date (Required)</param>
		/// <param name="m3HREF">Purchase order head reference</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3CMCO">Communication code</param>
		/// <param name="m3PUDT">Order date</param>
		/// <param name="m3LNCD">Language</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="m3PYME">Payment method - accounts payable</param>
		/// <param name="m3MODL">Delivery method</param>
		/// <param name="m3TEDL">Delivery terms</param>
		/// <param name="m3TEAF">Freight terms</param>
		/// <param name="m3TEPA">Packaging terms</param>
		/// <param name="m3YRE1">Your reference</param>
		/// <param name="m3PRSU">Payee</param>
		/// <param name="m3OURR">Our reference number</param>
		/// <param name="m3OURT">Reference type</param>
		/// <param name="m3AGNT">Recipient agreement type 1 - commission</param>
		/// <param name="m3PURC">Requisition by</param>
		/// <param name="m3BUYE">Buyer</param>
		/// <param name="m3FUSC">Monitoring activity list</param>
		/// <param name="m3TFNO">Facsimile transmission number</param>
		/// <param name="m3LRED">Last reply date</param>
		/// <param name="m3TEL1">Terms text</param>
		/// <param name="m3DUDT">Due date</param>
		/// <param name="m3CUTE">Currency terms</param>
		/// <param name="m3AGRA">Agreed rate</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3HAFE">Harbor or airport</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3RASN">Rail station</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddHeadResponse></returns>
		/// <exception cref="M3Exception<AddHeadResponse>"></exception>
		public async Task<M3Response<AddHeadResponse>> AddHead(
			string m3MSGN, 
			string m3FACI, 
			string m3WHLO, 
			string m3SUNO, 
			DateTime m3DWDT, 
			string m3HREF = null, 
			string m3ORTY = null, 
			string m3CMCO = null, 
			DateTime? m3PUDT = null, 
			string m3LNCD = null, 
			string m3CUCD = null, 
			string m3TEPY = null, 
			string m3PYME = null, 
			string m3MODL = null, 
			string m3TEDL = null, 
			string m3TEAF = null, 
			string m3TEPA = null, 
			string m3YRE1 = null, 
			string m3PRSU = null, 
			string m3OURR = null, 
			string m3OURT = null, 
			string m3AGNT = null, 
			string m3PURC = null, 
			string m3BUYE = null, 
			string m3FUSC = null, 
			string m3TFNO = null, 
			DateTime? m3LRED = null, 
			string m3TEL1 = null, 
			DateTime? m3DUDT = null, 
			int? m3CUTE = null, 
			decimal? m3AGRA = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3HAFE = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			string m3RASN = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3SUNO))
				throw new ArgumentNullException(nameof(m3SUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3MSGN.Trim())
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("SUNO", m3SUNO.Trim())
				.WithQueryParameter("DWDT", m3DWDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3HREF))
				request.WithQueryParameter("HREF", m3HREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3CMCO))
				request.WithQueryParameter("CMCO", m3CMCO.Trim());
			if (m3PUDT.HasValue)
				request.WithQueryParameter("PUDT", m3PUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3LNCD))
				request.WithQueryParameter("LNCD", m3LNCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYME))
				request.WithQueryParameter("PYME", m3PYME.Trim());
			if (!string.IsNullOrWhiteSpace(m3MODL))
				request.WithQueryParameter("MODL", m3MODL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEDL))
				request.WithQueryParameter("TEDL", m3TEDL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEAF))
				request.WithQueryParameter("TEAF", m3TEAF.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPA))
				request.WithQueryParameter("TEPA", m3TEPA.Trim());
			if (!string.IsNullOrWhiteSpace(m3YRE1))
				request.WithQueryParameter("YRE1", m3YRE1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRSU))
				request.WithQueryParameter("PRSU", m3PRSU.Trim());
			if (!string.IsNullOrWhiteSpace(m3OURR))
				request.WithQueryParameter("OURR", m3OURR.Trim());
			if (!string.IsNullOrWhiteSpace(m3OURT))
				request.WithQueryParameter("OURT", m3OURT.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNT))
				request.WithQueryParameter("AGNT", m3AGNT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PURC))
				request.WithQueryParameter("PURC", m3PURC.Trim());
			if (!string.IsNullOrWhiteSpace(m3BUYE))
				request.WithQueryParameter("BUYE", m3BUYE.Trim());
			if (!string.IsNullOrWhiteSpace(m3FUSC))
				request.WithQueryParameter("FUSC", m3FUSC.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFNO))
				request.WithQueryParameter("TFNO", m3TFNO.Trim());
			if (m3LRED.HasValue)
				request.WithQueryParameter("LRED", m3LRED.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3TEL1))
				request.WithQueryParameter("TEL1", m3TEL1.Trim());
			if (m3DUDT.HasValue)
				request.WithQueryParameter("DUDT", m3DUDT.Value.ToM3String());
			if (m3CUTE.HasValue)
				request.WithQueryParameter("CUTE", m3CUTE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AGRA.HasValue)
				request.WithQueryParameter("AGRA", m3AGRA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3HAFE))
				request.WithQueryParameter("HAFE", m3HAFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (!string.IsNullOrWhiteSpace(m3RASN))
				request.WithQueryParameter("RASN", m3RASN.Trim());

			// Execute the request
			var result = await Execute<AddHeadResponse>(
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
		/// Name AddLine
		/// Description Add order line
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3ORQA">Ordered quantity - alternate U/M (Required)</param>
		/// <param name="m3PUNO">Purchase order number</param>
		/// <param name="m3HREF">Purchase order head reference</param>
		/// <param name="m3PNLI">Purchase order line</param>
		/// <param name="m3LREF">Purchase order line reference</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3DWDT">Requested delivery date</param>
		/// <param name="m3SITE">Supplier item number</param>
		/// <param name="m3PITD">Purchase order item name</param>
		/// <param name="m3PITT">Purchase order item description</param>
		/// <param name="m3PROD">Manufacturer</param>
		/// <param name="m3ECVE">Revision number</param>
		/// <param name="m3REVN">Revision number</param>
		/// <param name="m3ETRF">External instruction</param>
		/// <param name="m3PUPR">Purchase price</param>
		/// <param name="m3ODI1">Discount 1</param>
		/// <param name="m3ODI2">Discount 2</param>
		/// <param name="m3ODI3">Discount 3</param>
		/// <param name="m3PUUN">Purchase order U/M</param>
		/// <param name="m3PPUN">Purchase price U/M</param>
		/// <param name="m3PUCD">Purchase price quantity</param>
		/// <param name="m3PTCD">Purchase price text</param>
		/// <param name="m3RORC">Reference order category</param>
		/// <param name="m3RORN">Reference order number</param>
		/// <param name="m3RORL">Reference order line</param>
		/// <param name="m3RORX">Line suffix</param>
		/// <param name="m3OURR">Our reference number</param>
		/// <param name="m3OURT">Reference type</param>
		/// <param name="m3PRIP">Priority</param>
		/// <param name="m3FUSC">Monitoring activity list</param>
		/// <param name="m3PURC">Requisition by</param>
		/// <param name="m3BUYE">Buyer</param>
		/// <param name="m3TERE">Technical supervisor</param>
		/// <param name="m3GRMT">Goods receiving method</param>
		/// <param name="m3IRCV">Recipient</param>
		/// <param name="m3PACT">Packaging</param>
		/// <param name="m3VTCD">VAT code</param>
		/// <param name="m3ACRF">User-defined accounting control object</param>
		/// <param name="m3COCE">Cost center</param>
		/// <param name="m3CSNO">Customs statistical number</param>
		/// <param name="m3ECLC">Labor code - trade statistics (TST)</param>
		/// <param name="m3VRCD">Business type - trade statistics (TST)</param>
		/// <param name="m3PROJ">Project number</param>
		/// <param name="m3ELNO">Project element</param>
		/// <param name="m3CPRI">Customs procedure - import</param>
		/// <param name="m3HAFE">Harbor or airport</param>
		/// <param name="m3TAXC">Tax code customer/address</param>
		/// <param name="m3TIHM">Time hours & minutes</param>
		/// <param name="m3MSTN">Milestone chain</param>
		/// <param name="m3UPCK">Unpack</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="m3ORCO">Country of origin</param>
		/// <param name="m3GEOC">Geographical code</param>
		/// <param name="m3TRRC">Order relation category</param>
		/// <param name="m3TRRN">Order relation number</param>
		/// <param name="m3TRRL">Reference order line</param>
		/// <param name="m3TRRX">Line suffix trade-in</param>
		/// <param name="m3RASN">Rail station</param>
		/// <param name="m3PIAD">Pickup address number</param>
		/// <param name="m3ORAD">Origin Address</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddLineResponse></returns>
		/// <exception cref="M3Exception<AddLineResponse>"></exception>
		public async Task<M3Response<AddLineResponse>> AddLine(
			string m3MSGN, 
			string m3ITNO, 
			decimal m3ORQA, 
			string m3PUNO = null, 
			string m3HREF = null, 
			int? m3PNLI = null, 
			string m3LREF = null, 
			string m3FACI = null, 
			string m3WHLO = null, 
			string m3SUNO = null, 
			DateTime? m3DWDT = null, 
			string m3SITE = null, 
			string m3PITD = null, 
			string m3PITT = null, 
			string m3PROD = null, 
			string m3ECVE = null, 
			string m3REVN = null, 
			string m3ETRF = null, 
			decimal? m3PUPR = null, 
			int? m3ODI1 = null, 
			int? m3ODI2 = null, 
			int? m3ODI3 = null, 
			string m3PUUN = null, 
			string m3PPUN = null, 
			int? m3PUCD = null, 
			int? m3PTCD = null, 
			int? m3RORC = null, 
			string m3RORN = null, 
			int? m3RORL = null, 
			int? m3RORX = null, 
			string m3OURR = null, 
			string m3OURT = null, 
			string m3PRIP = null, 
			string m3FUSC = null, 
			string m3PURC = null, 
			string m3BUYE = null, 
			string m3TERE = null, 
			string m3GRMT = null, 
			string m3IRCV = null, 
			string m3PACT = null, 
			int? m3VTCD = null, 
			string m3ACRF = null, 
			string m3COCE = null, 
			string m3CSNO = null, 
			string m3ECLC = null, 
			string m3VRCD = null, 
			string m3PROJ = null, 
			string m3ELNO = null, 
			string m3CPRI = null, 
			string m3HAFE = null, 
			string m3TAXC = null, 
			int? m3TIHM = null, 
			long? m3MSTN = null, 
			int? m3UPCK = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
			string m3ORCO = null, 
			int? m3GEOC = null, 
			int? m3TRRC = null, 
			string m3TRRN = null, 
			int? m3TRRL = null, 
			int? m3TRRX = null, 
			string m3RASN = null, 
			string m3PIAD = null, 
			string m3ORAD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddLine",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3MSGN.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("ORQA", m3ORQA.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PUNO))
				request.WithQueryParameter("PUNO", m3PUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3HREF))
				request.WithQueryParameter("HREF", m3HREF.Trim());
			if (m3PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3PNLI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LREF))
				request.WithQueryParameter("LREF", m3LREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (m3DWDT.HasValue)
				request.WithQueryParameter("DWDT", m3DWDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3SITE))
				request.WithQueryParameter("SITE", m3SITE.Trim());
			if (!string.IsNullOrWhiteSpace(m3PITD))
				request.WithQueryParameter("PITD", m3PITD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PITT))
				request.WithQueryParameter("PITT", m3PITT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROD))
				request.WithQueryParameter("PROD", m3PROD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECVE))
				request.WithQueryParameter("ECVE", m3ECVE.Trim());
			if (!string.IsNullOrWhiteSpace(m3REVN))
				request.WithQueryParameter("REVN", m3REVN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ETRF))
				request.WithQueryParameter("ETRF", m3ETRF.Trim());
			if (m3PUPR.HasValue)
				request.WithQueryParameter("PUPR", m3PUPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ODI1.HasValue)
				request.WithQueryParameter("ODI1", m3ODI1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ODI2.HasValue)
				request.WithQueryParameter("ODI2", m3ODI2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ODI3.HasValue)
				request.WithQueryParameter("ODI3", m3ODI3.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PUUN))
				request.WithQueryParameter("PUUN", m3PUUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PPUN))
				request.WithQueryParameter("PPUN", m3PPUN.Trim());
			if (m3PUCD.HasValue)
				request.WithQueryParameter("PUCD", m3PUCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PTCD.HasValue)
				request.WithQueryParameter("PTCD", m3PTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OURR))
				request.WithQueryParameter("OURR", m3OURR.Trim());
			if (!string.IsNullOrWhiteSpace(m3OURT))
				request.WithQueryParameter("OURT", m3OURT.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRIP))
				request.WithQueryParameter("PRIP", m3PRIP.Trim());
			if (!string.IsNullOrWhiteSpace(m3FUSC))
				request.WithQueryParameter("FUSC", m3FUSC.Trim());
			if (!string.IsNullOrWhiteSpace(m3PURC))
				request.WithQueryParameter("PURC", m3PURC.Trim());
			if (!string.IsNullOrWhiteSpace(m3BUYE))
				request.WithQueryParameter("BUYE", m3BUYE.Trim());
			if (!string.IsNullOrWhiteSpace(m3TERE))
				request.WithQueryParameter("TERE", m3TERE.Trim());
			if (!string.IsNullOrWhiteSpace(m3GRMT))
				request.WithQueryParameter("GRMT", m3GRMT.Trim());
			if (!string.IsNullOrWhiteSpace(m3IRCV))
				request.WithQueryParameter("IRCV", m3IRCV.Trim());
			if (!string.IsNullOrWhiteSpace(m3PACT))
				request.WithQueryParameter("PACT", m3PACT.Trim());
			if (m3VTCD.HasValue)
				request.WithQueryParameter("VTCD", m3VTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ACRF))
				request.WithQueryParameter("ACRF", m3ACRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3COCE))
				request.WithQueryParameter("COCE", m3COCE.Trim());
			if (!string.IsNullOrWhiteSpace(m3CSNO))
				request.WithQueryParameter("CSNO", m3CSNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECLC))
				request.WithQueryParameter("ECLC", m3ECLC.Trim());
			if (!string.IsNullOrWhiteSpace(m3VRCD))
				request.WithQueryParameter("VRCD", m3VRCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROJ))
				request.WithQueryParameter("PROJ", m3PROJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3ELNO))
				request.WithQueryParameter("ELNO", m3ELNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3CPRI))
				request.WithQueryParameter("CPRI", m3CPRI.Trim());
			if (!string.IsNullOrWhiteSpace(m3HAFE))
				request.WithQueryParameter("HAFE", m3HAFE.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAXC))
				request.WithQueryParameter("TAXC", m3TAXC.Trim());
			if (m3TIHM.HasValue)
				request.WithQueryParameter("TIHM", m3TIHM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MSTN.HasValue)
				request.WithQueryParameter("MSTN", m3MSTN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UPCK.HasValue)
				request.WithQueryParameter("UPCK", m3UPCK.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORCO))
				request.WithQueryParameter("ORCO", m3ORCO.Trim());
			if (m3GEOC.HasValue)
				request.WithQueryParameter("GEOC", m3GEOC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRRC.HasValue)
				request.WithQueryParameter("TRRC", m3TRRC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TRRN))
				request.WithQueryParameter("TRRN", m3TRRN.Trim());
			if (m3TRRL.HasValue)
				request.WithQueryParameter("TRRL", m3TRRL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TRRX.HasValue)
				request.WithQueryParameter("TRRX", m3TRRX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RASN))
				request.WithQueryParameter("RASN", m3RASN.Trim());
			if (!string.IsNullOrWhiteSpace(m3PIAD))
				request.WithQueryParameter("PIAD", m3PIAD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORAD))
				request.WithQueryParameter("ORAD", m3ORAD.Trim());

			// Execute the request
			var result = await Execute<AddLineResponse>(
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
		/// Name AddText
		/// Description Add text
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="m3PUNO">Purchase order number</param>
		/// <param name="m3HREF">Purchase order head reference</param>
		/// <param name="m3PNLI">Purchase order line</param>
		/// <param name="m3LREF">Purchase order line reference</param>
		/// <param name="m3SUNO">Supplier number</param>
		/// <param name="m3TXVR">Text block</param>
		/// <param name="m3SQNR">Sequence number</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TXT1">Text</param>
		/// <param name="m3TXT2">Text</param>
		/// <param name="m3TXT3">Text</param>
		/// <param name="m3TXT4">Text</param>
		/// <param name="m3TXT5">Text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddText(
			string m3MSGN, 
			string m3PUNO = null, 
			string m3HREF = null, 
			int? m3PNLI = null, 
			string m3LREF = null, 
			string m3SUNO = null, 
			string m3TXVR = null, 
			int? m3SQNR = null, 
			string m3TX40 = null, 
			string m3TXT1 = null, 
			string m3TXT2 = null, 
			string m3TXT3 = null, 
			string m3TXT4 = null, 
			string m3TXT5 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddText",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3MSGN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PUNO))
				request.WithQueryParameter("PUNO", m3PUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3HREF))
				request.WithQueryParameter("HREF", m3HREF.Trim());
			if (m3PNLI.HasValue)
				request.WithQueryParameter("PNLI", m3PNLI.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LREF))
				request.WithQueryParameter("LREF", m3LREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXVR))
				request.WithQueryParameter("TXVR", m3TXVR.Trim());
			if (m3SQNR.HasValue)
				request.WithQueryParameter("SQNR", m3SQNR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT1))
				request.WithQueryParameter("TXT1", m3TXT1.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT2))
				request.WithQueryParameter("TXT2", m3TXT2.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT3))
				request.WithQueryParameter("TXT3", m3TXT3.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT4))
				request.WithQueryParameter("TXT4", m3TXT4.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXT5))
				request.WithQueryParameter("TXT5", m3TXT5.Trim());

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
		/// Name DeleteEntry
		/// Description Delete entry
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeleteEntry(
			string m3MSGN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DeleteEntry",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3MSGN.Trim());

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
		/// Name FinishEntry
		/// Description Finish entry
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MSGN">Message number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> FinishEntry(
			string m3MSGN, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/FinishEntry",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MSGN))
				throw new ArgumentNullException(nameof(m3MSGN));

			// Set mandatory parameters
			request
				.WithQueryParameter("MSGN", m3MSGN.Trim());

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
		/// Name StartEntry
		/// Description Start entry
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3BAOR">Batch origin (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<StartEntryResponse></returns>
		/// <exception cref="M3Exception<StartEntryResponse>"></exception>
		public async Task<M3Response<StartEntryResponse>> StartEntry(
			string m3BAOR, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/StartEntry",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3BAOR))
				throw new ArgumentNullException(nameof(m3BAOR));

			// Set mandatory parameters
			request
				.WithQueryParameter("BAOR", m3BAOR.Trim());

			// Execute the request
			var result = await Execute<StartEntryResponse>(
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
