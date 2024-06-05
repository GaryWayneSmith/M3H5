/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
		/// <param name="m3FACI">Facility (Required)</param>
		/// <param name="m3AOTP">Agreement order type (Required)</param>
		/// <param name="m3AGCN">Agreement customer (Required)</param>
		/// <param name="m3NOPR">Number of periods (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3AGTP">Agreement type (Required)</param>
		/// <param name="m3IXCD">Price index (Required)</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="m3CUPL">Customer site</param>
		/// <param name="m3SAID">Address number</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3USID">Our reference</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="m3SMCD">Sales person</param>
		/// <param name="m3AGRE">LTR agreement responsible</param>
		/// <param name="m3SRES">Service manager</param>
		/// <param name="m3ARCC">Reason code - created agreement</param>
		/// <param name="m3ARCT">Reason code - terminated agreement</param>
		/// <param name="m3AGRC">LTR agreement conditions</param>
		/// <param name="m3PKIT">Kit price printout</param>
		/// <param name="m3IIYR">Invoicing interval - years</param>
		/// <param name="m3IIMO">Invoicing interval - months</param>
		/// <param name="m3IIWE">Invoicing interval - weeks</param>
		/// <param name="m3IXYR">Index interval years</param>
		/// <param name="m3IXMO">Index interval months</param>
		/// <param name="m3IXWE">Index interval weeks</param>
		/// <param name="m3ANOS">Number of shifts</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddLTRHeadResponse></returns>
		/// <exception cref="M3Exception<AddLTRHeadResponse>"></exception>
		public async Task<M3Response<AddLTRHeadResponse>> AddLTRHead(
			string m3FACI, 
			string m3AOTP, 
			string m3AGCN, 
			int m3NOPR, 
			string m3CUCD, 
			string m3AGTP, 
			string m3IXCD, 
			string m3AGNB = null, 
			string m3CUPL = null, 
			string m3SAID = null, 
			string m3PYNO = null, 
			DateTime? m3FVDT = null, 
			string m3CUOR = null, 
			string m3USID = null, 
			string m3TEPY = null, 
			string m3SMCD = null, 
			string m3AGRE = null, 
			string m3SRES = null, 
			string m3ARCC = null, 
			string m3ARCT = null, 
			string m3AGRC = null, 
			int? m3PKIT = null, 
			int? m3IIYR = null, 
			int? m3IIMO = null, 
			int? m3IIWE = null, 
			int? m3IXYR = null, 
			int? m3IXMO = null, 
			int? m3IXWE = null, 
			int? m3ANOS = null, 
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
			if (string.IsNullOrWhiteSpace(m3FACI))
				throw new ArgumentNullException(nameof(m3FACI));
			if (string.IsNullOrWhiteSpace(m3AOTP))
				throw new ArgumentNullException(nameof(m3AOTP));
			if (string.IsNullOrWhiteSpace(m3AGCN))
				throw new ArgumentNullException(nameof(m3AGCN));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));
			if (string.IsNullOrWhiteSpace(m3AGTP))
				throw new ArgumentNullException(nameof(m3AGTP));
			if (string.IsNullOrWhiteSpace(m3IXCD))
				throw new ArgumentNullException(nameof(m3IXCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("FACI", m3FACI.Trim())
				.WithQueryParameter("AOTP", m3AOTP.Trim())
				.WithQueryParameter("AGCN", m3AGCN.Trim())
				.WithQueryParameter("NOPR", m3NOPR.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("AGTP", m3AGTP.Trim())
				.WithQueryParameter("IXCD", m3IXCD.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUPL))
				request.WithQueryParameter("CUPL", m3CUPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3SAID))
				request.WithQueryParameter("SAID", m3SAID.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3USID))
				request.WithQueryParameter("USID", m3USID.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMCD))
				request.WithQueryParameter("SMCD", m3SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGRE))
				request.WithQueryParameter("AGRE", m3AGRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3SRES))
				request.WithQueryParameter("SRES", m3SRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3ARCC))
				request.WithQueryParameter("ARCC", m3ARCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ARCT))
				request.WithQueryParameter("ARCT", m3ARCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGRC))
				request.WithQueryParameter("AGRC", m3AGRC.Trim());
			if (m3PKIT.HasValue)
				request.WithQueryParameter("PKIT", m3PKIT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IIYR.HasValue)
				request.WithQueryParameter("IIYR", m3IIYR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IIMO.HasValue)
				request.WithQueryParameter("IIMO", m3IIMO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IIWE.HasValue)
				request.WithQueryParameter("IIWE", m3IIWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IXYR.HasValue)
				request.WithQueryParameter("IXYR", m3IXYR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IXMO.HasValue)
				request.WithQueryParameter("IXMO", m3IXMO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IXWE.HasValue)
				request.WithQueryParameter("IXWE", m3IXWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ANOS.HasValue)
				request.WithQueryParameter("ANOS", m3ANOS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddLTRHeadResponse>(
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
		/// Name DltLTRAgree
		/// Description This transaction deletes the LTR agreement header
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltLTRAgree(
			string m3AGNB, 
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
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3AGNB.Trim());

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
		/// Name GetLTRAgree
		/// Description This transaction displays LTR agreement header by Customer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLTRAgreeResponse></returns>
		/// <exception cref="M3Exception<GetLTRAgreeResponse>"></exception>
		public async Task<M3Response<GetLTRAgreeResponse>> GetLTRAgree(
			string m3AGNB, 
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
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3AGNB.Trim());

			// Execute the request
			var result = await Execute<GetLTRAgreeResponse>(
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
		/// Name LstLTRByAgree
		/// Description This transaction lists LTR agreement header by agreement num
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLTRByAgreeResponse></returns>
		/// <exception cref="M3Exception<LstLTRByAgreeResponse>"></exception>
		public async Task<M3Response<LstLTRByAgreeResponse>> LstLTRByAgree(
			string m3FACI = null, 
			string m3AGNB = null, 
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
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());

			// Execute the request
			var result = await Execute<LstLTRByAgreeResponse>(
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
		/// Name LstLTRByCO
		/// Description This transaction lists LTR agreement header by CO number
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3ORNO">Customer order number</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLTRByCOResponse></returns>
		/// <exception cref="M3Exception<LstLTRByCOResponse>"></exception>
		public async Task<M3Response<LstLTRByCOResponse>> LstLTRByCO(
			string m3FACI = null, 
			string m3ORNO = null, 
			string m3AGNB = null, 
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
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORNO))
				request.WithQueryParameter("ORNO", m3ORNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());

			// Execute the request
			var result = await Execute<LstLTRByCOResponse>(
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
		/// Name LstLTRByCust
		/// Description This transaction lists LTR agreement header by Customer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3AGCN">Agreement customer</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLTRByCustResponse></returns>
		/// <exception cref="M3Exception<LstLTRByCustResponse>"></exception>
		public async Task<M3Response<LstLTRByCustResponse>> LstLTRByCust(
			string m3FACI = null, 
			string m3AGCN = null, 
			string m3AGNB = null, 
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
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGCN))
				request.WithQueryParameter("AGCN", m3AGCN.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());

			// Execute the request
			var result = await Execute<LstLTRByCustResponse>(
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
		/// Name LstLTRByItem
		/// Description This transaction lists LTR agreement header by Payer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLTRByItemResponse></returns>
		/// <exception cref="M3Exception<LstLTRByItemResponse>"></exception>
		public async Task<M3Response<LstLTRByItemResponse>> LstLTRByItem(
			string m3FACI = null, 
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3AGNB = null, 
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
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());

			// Execute the request
			var result = await Execute<LstLTRByItemResponse>(
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
		/// Name LstLTRByName
		/// Description This transaction lists LTR agreement header by Customer name
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3CUNM">Customer name</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLTRByNameResponse></returns>
		/// <exception cref="M3Exception<LstLTRByNameResponse>"></exception>
		public async Task<M3Response<LstLTRByNameResponse>> LstLTRByName(
			string m3FACI = null, 
			string m3CUNM = null, 
			string m3AGNB = null, 
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
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNM))
				request.WithQueryParameter("CUNM", m3CUNM.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());

			// Execute the request
			var result = await Execute<LstLTRByNameResponse>(
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
		/// Name LstLTRByPayer
		/// Description This transaction lists LTR agreement header by Payer
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3PYNO">Payer</param>
		/// <param name="m3AGNB">Agreement number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLTRByPayerResponse></returns>
		/// <exception cref="M3Exception<LstLTRByPayerResponse>"></exception>
		public async Task<M3Response<LstLTRByPayerResponse>> LstLTRByPayer(
			string m3FACI = null, 
			string m3PYNO = null, 
			string m3AGNB = null, 
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
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3PYNO))
				request.WithQueryParameter("PYNO", m3PYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNB))
				request.WithQueryParameter("AGNB", m3AGNB.Trim());

			// Execute the request
			var result = await Execute<LstLTRByPayerResponse>(
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
		/// Name UpdLTRHead
		/// Description This transaction updates LTR agreement header
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3AGNB">Agreement number (Required)</param>
		/// <param name="m3AGCN">Agreement customer</param>
		/// <param name="m3CUOR">Customers order number</param>
		/// <param name="m3USID">Our reference</param>
		/// <param name="m3TEPY">Payment terms</param>
		/// <param name="m3SMCD">Salesperson</param>
		/// <param name="m3AGRE">LTR agreement responsible</param>
		/// <param name="m3SRES">Service manager</param>
		/// <param name="m3ARCC">Reason code - created agreement</param>
		/// <param name="m3ARCT">Reason code - terminated agreement</param>
		/// <param name="m3AGRC">LTR agreement conditions</param>
		/// <param name="m3PKIT">Kit price printout</param>
		/// <param name="m3AGTP">Agreement type</param>
		/// <param name="m3IIYR">Invoicing interval - years</param>
		/// <param name="m3IIMO">Invoicing interval - months</param>
		/// <param name="m3IIWE">Invoicing interval - weeks</param>
		/// <param name="m3IXCD">Price index</param>
		/// <param name="m3IXYR">Index interval years</param>
		/// <param name="m3IXMO">Index interval months</param>
		/// <param name="m3IXWE">Index interval weeks</param>
		/// <param name="m3ANOS">Number of shifts</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdLTRHead(
			string m3AGNB, 
			string m3AGCN = null, 
			string m3CUOR = null, 
			string m3USID = null, 
			string m3TEPY = null, 
			string m3SMCD = null, 
			string m3AGRE = null, 
			string m3SRES = null, 
			string m3ARCC = null, 
			string m3ARCT = null, 
			string m3AGRC = null, 
			int? m3PKIT = null, 
			string m3AGTP = null, 
			int? m3IIYR = null, 
			int? m3IIMO = null, 
			int? m3IIWE = null, 
			string m3IXCD = null, 
			int? m3IXYR = null, 
			int? m3IXMO = null, 
			int? m3IXWE = null, 
			int? m3ANOS = null, 
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
			if (string.IsNullOrWhiteSpace(m3AGNB))
				throw new ArgumentNullException(nameof(m3AGNB));

			// Set mandatory parameters
			request
				.WithQueryParameter("AGNB", m3AGNB.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3AGCN))
				request.WithQueryParameter("AGCN", m3AGCN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUOR))
				request.WithQueryParameter("CUOR", m3CUOR.Trim());
			if (!string.IsNullOrWhiteSpace(m3USID))
				request.WithQueryParameter("USID", m3USID.Trim());
			if (!string.IsNullOrWhiteSpace(m3TEPY))
				request.WithQueryParameter("TEPY", m3TEPY.Trim());
			if (!string.IsNullOrWhiteSpace(m3SMCD))
				request.WithQueryParameter("SMCD", m3SMCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGRE))
				request.WithQueryParameter("AGRE", m3AGRE.Trim());
			if (!string.IsNullOrWhiteSpace(m3SRES))
				request.WithQueryParameter("SRES", m3SRES.Trim());
			if (!string.IsNullOrWhiteSpace(m3ARCC))
				request.WithQueryParameter("ARCC", m3ARCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3ARCT))
				request.WithQueryParameter("ARCT", m3ARCT.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGRC))
				request.WithQueryParameter("AGRC", m3AGRC.Trim());
			if (m3PKIT.HasValue)
				request.WithQueryParameter("PKIT", m3PKIT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3AGTP))
				request.WithQueryParameter("AGTP", m3AGTP.Trim());
			if (m3IIYR.HasValue)
				request.WithQueryParameter("IIYR", m3IIYR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IIMO.HasValue)
				request.WithQueryParameter("IIMO", m3IIMO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IIWE.HasValue)
				request.WithQueryParameter("IIWE", m3IIWE.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3IXCD))
				request.WithQueryParameter("IXCD", m3IXCD.Trim());
			if (m3IXYR.HasValue)
				request.WithQueryParameter("IXYR", m3IXYR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IXMO.HasValue)
				request.WithQueryParameter("IXMO", m3IXMO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3IXWE.HasValue)
				request.WithQueryParameter("IXWE", m3IXWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ANOS.HasValue)
				request.WithQueryParameter("ANOS", m3ANOS.Value.ToString(CultureInfo.CurrentCulture));

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
