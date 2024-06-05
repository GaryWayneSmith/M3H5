/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.LTS100MI;
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
	/// Name: LTS100MI
	/// Component Name: Cust Sales and Serv
	/// Description: Api: LTR Agreement Head
	/// Version Release: 14.x
	///</summary>
	public partial class LTS100MIResource : M3BaseResourceEndpoint
	{
		public LTS100MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "LTS100MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddLTRHead
		/// Description This transaction adds LTR agreement header
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility (Required)</param>
		/// <param name="m3_AOTP">Agreement order type (Required)</param>
		/// <param name="m3_AGCN">Agreement customer (Required)</param>
		/// <param name="m3_NOPR">Number of periods (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_AGTP">Agreement type (Required)</param>
		/// <param name="m3_IXCD">Price index (Required)</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="m3_CUPL">Customer site</param>
		/// <param name="m3_SAID">Address number</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_USID">Our reference</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_SMCD">Sales person</param>
		/// <param name="m3_AGRE">LTR agreement responsible</param>
		/// <param name="m3_SRES">Service manager</param>
		/// <param name="m3_ARCC">Reason code - created agreement</param>
		/// <param name="m3_ARCT">Reason code - terminated agreement</param>
		/// <param name="m3_AGRC">LTR agreement conditions</param>
		/// <param name="m3_PKIT">Kit price printout</param>
		/// <param name="m3_IIYR">Invoicing interval - years</param>
		/// <param name="m3_IIMO">Invoicing interval - months</param>
		/// <param name="m3_IIWE">Invoicing interval - weeks</param>
		/// <param name="m3_IXYR">Index interval years</param>
		/// <param name="m3_IXMO">Index interval months</param>
		/// <param name="m3_IXWE">Index interval weeks</param>
		/// <param name="m3_ANOS">Number of shifts</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddLTRHeadResponse></returns>
		/// <exception cref="M3Exception<AddLTRHeadResponse>"></exception>
		public async Task<M3Response<AddLTRHeadResponse>> AddLTRHead(
			string m3_FACI, 
			string m3_AOTP, 
			string m3_AGCN, 
			int m3_NOPR, 
			string m3_CUCD, 
			string m3_AGTP, 
			string m3_IXCD, 
			string m3_AGNB = null, 
			string m3_CUPL = null, 
			string m3_SAID = null, 
			string m3_PYNO = null, 
			DateTime? m3_FVDT = null, 
			string m3_CUOR = null, 
			string m3_USID = null, 
			string m3_TEPY = null, 
			string m3_SMCD = null, 
			string m3_AGRE = null, 
			string m3_SRES = null, 
			string m3_ARCC = null, 
			string m3_ARCT = null, 
			string m3_AGRC = null, 
			int? m3_PKIT = null, 
			int? m3_IIYR = null, 
			int? m3_IIMO = null, 
			int? m3_IIWE = null, 
			int? m3_IXYR = null, 
			int? m3_IXMO = null, 
			int? m3_IXWE = null, 
			int? m3_ANOS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddLTRHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FACI))
				throw new ArgumentNullException("m3_FACI");
			if (string.IsNullOrWhiteSpace(m3_AOTP))
				throw new ArgumentNullException("m3_AOTP");
			if (string.IsNullOrWhiteSpace(m3_AGCN))
				throw new ArgumentNullException("m3_AGCN");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");
			if (string.IsNullOrWhiteSpace(m3_AGTP))
				throw new ArgumentNullException("m3_AGTP");
			if (string.IsNullOrWhiteSpace(m3_IXCD))
				throw new ArgumentNullException("m3_IXCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3_FACI.Trim())
				.WithQueryParameter("AOTP", m3_AOTP.Trim())
				.WithQueryParameter("AGCN", m3_AGCN.Trim())
				.WithQueryParameter("NOPR", m3_NOPR.ToString())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("AGTP", m3_AGTP.Trim())
				.WithQueryParameter("IXCD", m3_IXCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUPL))
				request.WithQueryParameter("CUPL", m3_CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SAID))
				request.WithQueryParameter("SAID", m3_SAID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMCD))
				request.WithQueryParameter("SMCD", m3_SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGRE))
				request.WithQueryParameter("AGRE", m3_AGRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SRES))
				request.WithQueryParameter("SRES", m3_SRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ARCC))
				request.WithQueryParameter("ARCC", m3_ARCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ARCT))
				request.WithQueryParameter("ARCT", m3_ARCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGRC))
				request.WithQueryParameter("AGRC", m3_AGRC.Trim());
			if (m3_PKIT.HasValue)
				request.WithQueryParameter("PKIT", m3_PKIT.Value.ToString());
			if (m3_IIYR.HasValue)
				request.WithQueryParameter("IIYR", m3_IIYR.Value.ToString());
			if (m3_IIMO.HasValue)
				request.WithQueryParameter("IIMO", m3_IIMO.Value.ToString());
			if (m3_IIWE.HasValue)
				request.WithQueryParameter("IIWE", m3_IIWE.Value.ToString());
			if (m3_IXYR.HasValue)
				request.WithQueryParameter("IXYR", m3_IXYR.Value.ToString());
			if (m3_IXMO.HasValue)
				request.WithQueryParameter("IXMO", m3_IXMO.Value.ToString());
			if (m3_IXWE.HasValue)
				request.WithQueryParameter("IXWE", m3_IXWE.Value.ToString());
			if (m3_ANOS.HasValue)
				request.WithQueryParameter("ANOS", m3_ANOS.Value.ToString());

			// Execute the request
			var result = await Execute<AddLTRHeadResponse>(
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
		/// Name DltLTRAgree
		/// Description This transaction deletes the LTR agreement header
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltLTRAgree(
			string m3_AGNB, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DltLTRAgree",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3_AGNB.Trim());

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
		/// Name GetLTRAgree
		/// Description This transaction displays LTR agreement header by Customer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLTRAgreeResponse></returns>
		/// <exception cref="M3Exception<GetLTRAgreeResponse>"></exception>
		public async Task<M3Response<GetLTRAgreeResponse>> GetLTRAgree(
			string m3_AGNB, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetLTRAgree",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3_AGNB.Trim());

			// Execute the request
			var result = await Execute<GetLTRAgreeResponse>(
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
		/// Name LstLTRByAgree
		/// Description This transaction lists LTR agreement header by agreement num
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLTRByAgreeResponse></returns>
		/// <exception cref="M3Exception<LstLTRByAgreeResponse>"></exception>
		public async Task<M3Response<LstLTRByAgreeResponse>> LstLTRByAgree(
			string m3_FACI = null, 
			string m3_AGNB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLTRByAgree",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());

			// Execute the request
			var result = await Execute<LstLTRByAgreeResponse>(
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
		/// Name LstLTRByCO
		/// Description This transaction lists LTR agreement header by CO number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_ORNO">Customer order number</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLTRByCOResponse></returns>
		/// <exception cref="M3Exception<LstLTRByCOResponse>"></exception>
		public async Task<M3Response<LstLTRByCOResponse>> LstLTRByCO(
			string m3_FACI = null, 
			string m3_ORNO = null, 
			string m3_AGNB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLTRByCO",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ORNO))
				request.WithQueryParameter("ORNO", m3_ORNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());

			// Execute the request
			var result = await Execute<LstLTRByCOResponse>(
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
		/// Name LstLTRByCust
		/// Description This transaction lists LTR agreement header by Customer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_AGCN">Agreement customer</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLTRByCustResponse></returns>
		/// <exception cref="M3Exception<LstLTRByCustResponse>"></exception>
		public async Task<M3Response<LstLTRByCustResponse>> LstLTRByCust(
			string m3_FACI = null, 
			string m3_AGCN = null, 
			string m3_AGNB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLTRByCust",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGCN))
				request.WithQueryParameter("AGCN", m3_AGCN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());

			// Execute the request
			var result = await Execute<LstLTRByCustResponse>(
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
		/// Name LstLTRByItem
		/// Description This transaction lists LTR agreement header by Payer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLTRByItemResponse></returns>
		/// <exception cref="M3Exception<LstLTRByItemResponse>"></exception>
		public async Task<M3Response<LstLTRByItemResponse>> LstLTRByItem(
			string m3_FACI = null, 
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_AGNB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLTRByItem",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());

			// Execute the request
			var result = await Execute<LstLTRByItemResponse>(
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
		/// Name LstLTRByName
		/// Description This transaction lists LTR agreement header by Customer name
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_CUNM">Customer name</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLTRByNameResponse></returns>
		/// <exception cref="M3Exception<LstLTRByNameResponse>"></exception>
		public async Task<M3Response<LstLTRByNameResponse>> LstLTRByName(
			string m3_FACI = null, 
			string m3_CUNM = null, 
			string m3_AGNB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLTRByName",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNM))
				request.WithQueryParameter("CUNM", m3_CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());

			// Execute the request
			var result = await Execute<LstLTRByNameResponse>(
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
		/// Name LstLTRByPayer
		/// Description This transaction lists LTR agreement header by Payer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_PYNO">Payer</param>
		/// <param name="m3_AGNB">Agreement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLTRByPayerResponse></returns>
		/// <exception cref="M3Exception<LstLTRByPayerResponse>"></exception>
		public async Task<M3Response<LstLTRByPayerResponse>> LstLTRByPayer(
			string m3_FACI = null, 
			string m3_PYNO = null, 
			string m3_AGNB = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLTRByPayer",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PYNO))
				request.WithQueryParameter("PYNO", m3_PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGNB))
				request.WithQueryParameter("AGNB", m3_AGNB.Trim());

			// Execute the request
			var result = await Execute<LstLTRByPayerResponse>(
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
		/// Name UpdLTRHead
		/// Description This transaction updates LTR agreement header
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_AGNB">Agreement number (Required)</param>
		/// <param name="m3_AGCN">Agreement customer</param>
		/// <param name="m3_CUOR">Customers order number</param>
		/// <param name="m3_USID">Our reference</param>
		/// <param name="m3_TEPY">Payment terms</param>
		/// <param name="m3_SMCD">Salesperson</param>
		/// <param name="m3_AGRE">LTR agreement responsible</param>
		/// <param name="m3_SRES">Service manager</param>
		/// <param name="m3_ARCC">Reason code - created agreement</param>
		/// <param name="m3_ARCT">Reason code - terminated agreement</param>
		/// <param name="m3_AGRC">LTR agreement conditions</param>
		/// <param name="m3_PKIT">Kit price printout</param>
		/// <param name="m3_AGTP">Agreement type</param>
		/// <param name="m3_IIYR">Invoicing interval - years</param>
		/// <param name="m3_IIMO">Invoicing interval - months</param>
		/// <param name="m3_IIWE">Invoicing interval - weeks</param>
		/// <param name="m3_IXCD">Price index</param>
		/// <param name="m3_IXYR">Index interval years</param>
		/// <param name="m3_IXMO">Index interval months</param>
		/// <param name="m3_IXWE">Index interval weeks</param>
		/// <param name="m3_ANOS">Number of shifts</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdLTRHead(
			string m3_AGNB, 
			string m3_AGCN = null, 
			string m3_CUOR = null, 
			string m3_USID = null, 
			string m3_TEPY = null, 
			string m3_SMCD = null, 
			string m3_AGRE = null, 
			string m3_SRES = null, 
			string m3_ARCC = null, 
			string m3_ARCT = null, 
			string m3_AGRC = null, 
			int? m3_PKIT = null, 
			string m3_AGTP = null, 
			int? m3_IIYR = null, 
			int? m3_IIMO = null, 
			int? m3_IIWE = null, 
			string m3_IXCD = null, 
			int? m3_IXYR = null, 
			int? m3_IXMO = null, 
			int? m3_IXWE = null, 
			int? m3_ANOS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdLTRHead",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_AGNB))
				throw new ArgumentNullException("m3_AGNB");

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3_AGNB.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_AGCN))
				request.WithQueryParameter("AGCN", m3_AGCN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUOR))
				request.WithQueryParameter("CUOR", m3_CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_USID))
				request.WithQueryParameter("USID", m3_USID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TEPY))
				request.WithQueryParameter("TEPY", m3_TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SMCD))
				request.WithQueryParameter("SMCD", m3_SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGRE))
				request.WithQueryParameter("AGRE", m3_AGRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SRES))
				request.WithQueryParameter("SRES", m3_SRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ARCC))
				request.WithQueryParameter("ARCC", m3_ARCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ARCT))
				request.WithQueryParameter("ARCT", m3_ARCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGRC))
				request.WithQueryParameter("AGRC", m3_AGRC.Trim());
			if (m3_PKIT.HasValue)
				request.WithQueryParameter("PKIT", m3_PKIT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_AGTP))
				request.WithQueryParameter("AGTP", m3_AGTP.Trim());
			if (m3_IIYR.HasValue)
				request.WithQueryParameter("IIYR", m3_IIYR.Value.ToString());
			if (m3_IIMO.HasValue)
				request.WithQueryParameter("IIMO", m3_IIMO.Value.ToString());
			if (m3_IIWE.HasValue)
				request.WithQueryParameter("IIWE", m3_IIWE.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_IXCD))
				request.WithQueryParameter("IXCD", m3_IXCD.Trim());
			if (m3_IXYR.HasValue)
				request.WithQueryParameter("IXYR", m3_IXYR.Value.ToString());
			if (m3_IXMO.HasValue)
				request.WithQueryParameter("IXMO", m3_IXMO.Value.ToString());
			if (m3_IXWE.HasValue)
				request.WithQueryParameter("IXWE", m3_IXWE.Value.ToString());
			if (m3_ANOS.HasValue)
				request.WithQueryParameter("ANOS", m3_ANOS.Value.ToString());

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
