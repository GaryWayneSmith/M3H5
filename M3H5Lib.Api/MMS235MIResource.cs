/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.MMS235MI;
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
	/// Name: MMS235MI
	/// Component Name: Supplier portal
	/// Description: Lot Master interface
	/// Version Release: 5ea2
	///</summary>
	public partial class MMS235MIResource : M3BaseResourceEndpoint
	{
		public MMS235MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MMS235MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddFreeText
		/// Description Additional text can be entered per item/lot
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_BANO">Lot number</param>
		/// <param name="m3_TXVR">Text block</param>
		/// <param name="m3_TX60">Text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddFreeText(
			string m3_ITNO = null, 
			string m3_BANO = null, 
			string m3_TXVR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddFreeText",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TXVR))
				request.WithQueryParameter("TXVR", m3_TXVR.Trim());
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
		/// Name AddItmLot
		/// Description Adds lot to Item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Itemnumber (Required)</param>
		/// <param name="m3_BANO">Lotnumber</param>
		/// <param name="m3_BREF">Lotreference1</param>
		/// <param name="m3_BRE2">Lotreference2</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_STAS">Status-balanceID</param>
		/// <param name="m3_RORC">Referenceordercategory</param>
		/// <param name="m3_SUNO">Suppliernumber</param>
		/// <param name="m3_PROD">Manufacturer</param>
		/// <param name="m3_MFIT">Supplier/manufactureritemnumber</param>
		/// <param name="m3_MFSN">Manufacturerserialnumber</param>
		/// <param name="m3_ECVE">Revisionnumber</param>
		/// <param name="m3_CNDT">Follow-update</param>
		/// <param name="m3_ORCO">Countryoforigin</param>
		/// <param name="m3_ARLA">Filingaddress</param>
		/// <param name="m3_IDET">Taggingtype</param>
		/// <param name="m3_LPCY">Potency</param>
		/// <param name="m3_MFDT">Manufacturingdate</param>
		/// <param name="m3_REDA">Receiptdate</param>
		/// <param name="m3_LIRR">LI request rule</param>
		/// <param name="m3_HVDT">Harvested date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddItmLotResponse></returns>
		/// <exception cref="M3Exception<AddItmLotResponse>"></exception>
		public async Task<M3Response<AddItmLotResponse>> AddItmLot(
			string m3_ITNO, 
			string m3_BANO = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			string m3_FACI = null, 
			string m3_STAS = null, 
			int? m3_RORC = null, 
			string m3_SUNO = null, 
			string m3_PROD = null, 
			string m3_MFIT = null, 
			string m3_MFSN = null, 
			string m3_ECVE = null, 
			DateTime? m3_CNDT = null, 
			string m3_ORCO = null, 
			string m3_ARLA = null, 
			string m3_IDET = null, 
			int? m3_LPCY = null, 
			DateTime? m3_MFDT = null, 
			DateTime? m3_REDA = null, 
			int? m3_LIRR = null, 
			DateTime? m3_HVDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddItmLot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAS))
				request.WithQueryParameter("STAS", m3_STAS.Trim());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROD))
				request.WithQueryParameter("PROD", m3_PROD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MFIT))
				request.WithQueryParameter("MFIT", m3_MFIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MFSN))
				request.WithQueryParameter("MFSN", m3_MFSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECVE))
				request.WithQueryParameter("ECVE", m3_ECVE.Trim());
			if (m3_CNDT.HasValue)
				request.WithQueryParameter("CNDT", m3_CNDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ORCO))
				request.WithQueryParameter("ORCO", m3_ORCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ARLA))
				request.WithQueryParameter("ARLA", m3_ARLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IDET))
				request.WithQueryParameter("IDET", m3_IDET.Trim());
			if (m3_LPCY.HasValue)
				request.WithQueryParameter("LPCY", m3_LPCY.Value.ToString());
			if (m3_MFDT.HasValue)
				request.WithQueryParameter("MFDT", m3_MFDT.Value.ToM3String());
			if (m3_REDA.HasValue)
				request.WithQueryParameter("REDA", m3_REDA.Value.ToM3String());
			if (m3_LIRR.HasValue)
				request.WithQueryParameter("LIRR", m3_LIRR.Value.ToString());
			if (m3_HVDT.HasValue)
				request.WithQueryParameter("HVDT", m3_HVDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<AddItmLotResponse>(
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
		/// Name DelItmLot
		/// Description Deletes Item Lot
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Itemnumber (Required)</param>
		/// <param name="m3_BANO">Lotnumber (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelItmLot(
			string m3_ITNO, 
			string m3_BANO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelItmLot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_BANO))
				throw new ArgumentNullException("m3_BANO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("BANO", m3_BANO.Trim());

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
		/// Name GetItmLot
		/// Description Display Item Lot
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_ITNO">Itemnumber (Required)</param>
		/// <param name="m3_BANO">Lotnumber (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItmLotResponse></returns>
		/// <exception cref="M3Exception<GetItmLotResponse>"></exception>
		public async Task<M3Response<GetItmLotResponse>> GetItmLot(
			string m3_ITNO, 
			string m3_BANO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetItmLot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_BANO))
				throw new ArgumentNullException("m3_BANO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("BANO", m3_BANO.Trim());

			// Execute the request
			var result = await Execute<GetItmLotResponse>(
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
		/// Name GetLotItm
		/// Description Display Lot Item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_BANO">Lotnumber (Required)</param>
		/// <param name="m3_ITNO">Itemnumber (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLotItmResponse></returns>
		/// <exception cref="M3Exception<GetLotItmResponse>"></exception>
		public async Task<M3Response<GetLotItmResponse>> GetLotItm(
			string m3_BANO, 
			string m3_ITNO, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetLotItm",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_BANO))
				throw new ArgumentNullException("m3_BANO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("BANO", m3_BANO.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Execute the request
			var result = await Execute<GetLotItmResponse>(
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
		/// Name GetManufserItm
		/// Description Display Manufacturer Item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Itemnumber (Required)</param>
		/// <param name="m3_MFSN">Manufacturerserialnumber</param>
		/// <param name="m3_BANO">Lotnumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetManufserItmResponse></returns>
		/// <exception cref="M3Exception<GetManufserItmResponse>"></exception>
		public async Task<M3Response<GetManufserItmResponse>> GetManufserItm(
			string m3_ITNO, 
			string m3_MFSN = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetManufserItm",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MFSN))
				request.WithQueryParameter("MFSN", m3_MFSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());

			// Execute the request
			var result = await Execute<GetManufserItmResponse>(
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
		/// Name GetRocOrdLinItm
		/// Description Display Reference order category Item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_RORC">Referenceordercategory (Required)</param>
		/// <param name="m3_RORN">Referenceordernumber (Required)</param>
		/// <param name="m3_RORL">Referenceorderline</param>
		/// <param name="m3_ITNO">Itemnumber</param>
		/// <param name="m3_RORX">Linesuffix</param>
		/// <param name="m3_BANO">Lotnumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetRocOrdLinItmResponse></returns>
		/// <exception cref="M3Exception<GetRocOrdLinItmResponse>"></exception>
		public async Task<M3Response<GetRocOrdLinItmResponse>> GetRocOrdLinItm(
			int m3_RORC, 
			string m3_RORN, 
			int? m3_RORL = null, 
			string m3_ITNO = null, 
			int? m3_RORX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetRocOrdLinItm",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_RORN))
				throw new ArgumentNullException("m3_RORN");

			// Set mandatory parameters
			request
				.WithQueryParameter("RORC", m3_RORC.ToString())
				.WithQueryParameter("RORN", m3_RORN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_RORX.HasValue)
				request.WithQueryParameter("RORX", m3_RORX.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());

			// Execute the request
			var result = await Execute<GetRocOrdLinItmResponse>(
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
		/// Name LstItmLot
		/// Description List Item Lot
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Itemnumber (Required)</param>
		/// <param name="m3_BANO">Lotnumber</param>
		/// <param name="m3_BREF">Lotreference1</param>
		/// <param name="m3_BRE2">Lotreference2</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmLotResponse></returns>
		/// <exception cref="M3Exception<LstItmLotResponse>"></exception>
		public async Task<M3Response<LstItmLotResponse>> LstItmLot(
			string m3_ITNO, 
			string m3_BANO = null, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstItmLot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());

			// Execute the request
			var result = await Execute<LstItmLotResponse>(
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
		/// Name LstLotItm
		/// Description List Lot Item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_BANO">Lotnumber</param>
		/// <param name="m3_ITNO">Itemnumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLotItmResponse></returns>
		/// <exception cref="M3Exception<LstLotItmResponse>"></exception>
		public async Task<M3Response<LstLotItmResponse>> LstLotItm(
			string m3_BANO = null, 
			string m3_ITNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstLotItm",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_BANO))
				request.WithQueryParameter("BANO", m3_BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Execute the request
			var result = await Execute<LstLotItmResponse>(
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
		/// Name LstManufserItm
		/// Description List Manufacturer Item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_MFSN">Manufacturerserialnumber</param>
		/// <param name="m3_ITNO">Itemnumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstManufserItmResponse></returns>
		/// <exception cref="M3Exception<LstManufserItmResponse>"></exception>
		public async Task<M3Response<LstManufserItmResponse>> LstManufserItm(
			string m3_MFSN = null, 
			string m3_ITNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstManufserItm",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_MFSN))
				request.WithQueryParameter("MFSN", m3_MFSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Execute the request
			var result = await Execute<LstManufserItmResponse>(
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
		/// Name LstRocOrdLinItm
		/// Description List Reference Order category Item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_RORC">Referenceordercategory</param>
		/// <param name="m3_RORN">Referenceordernumber</param>
		/// <param name="m3_RORL">Referenceorderline</param>
		/// <param name="m3_ITNO">Itemnumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRocOrdLinItmResponse></returns>
		/// <exception cref="M3Exception<LstRocOrdLinItmResponse>"></exception>
		public async Task<M3Response<LstRocOrdLinItmResponse>> LstRocOrdLinItm(
			int? m3_RORC = null, 
			string m3_RORN = null, 
			int? m3_RORL = null, 
			string m3_ITNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstRocOrdLinItm",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_RORN))
				request.WithQueryParameter("RORN", m3_RORN.Trim());
			if (m3_RORL.HasValue)
				request.WithQueryParameter("RORL", m3_RORL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Execute the request
			var result = await Execute<LstRocOrdLinItmResponse>(
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
		/// Name RtvNxtLotNo
		/// Description RtvNxtLotNo
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_WHLO">Warehouse (Required)</param>
		/// <param name="m3_ITNO">Item number (Required)</param>
		/// <param name="m3_CONO">Company</param>
		/// <param name="m3_ORCO">Country of origin</param>
		/// <param name="m3_PLGR">Work center</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<RtvNxtLotNoResponse></returns>
		/// <exception cref="M3Exception<RtvNxtLotNoResponse>"></exception>
		public async Task<M3Response<RtvNxtLotNoResponse>> RtvNxtLotNo(
			string m3_WHLO, 
			string m3_ITNO, 
			int? m3_CONO = null, 
			string m3_ORCO = null, 
			string m3_PLGR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/RtvNxtLotNo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_WHLO))
				throw new ArgumentNullException("m3_WHLO");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3_WHLO.Trim())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3_CONO.HasValue)
				request.WithQueryParameter("CONO", m3_CONO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ORCO))
				request.WithQueryParameter("ORCO", m3_ORCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PLGR))
				request.WithQueryParameter("PLGR", m3_PLGR.Trim());

			// Execute the request
			var result = await Execute<RtvNxtLotNoResponse>(
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
		/// Name UpdItmLot
		/// Description Updates Item Lot
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_ITNO">Itemnumber (Required)</param>
		/// <param name="m3_BANO">Lotnumber (Required)</param>
		/// <param name="m3_BREF">Lotreference1</param>
		/// <param name="m3_BRE2">Lotreference2</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_STAS">Status-balanceID</param>
		/// <param name="m3_RORC">Referenceordercategory</param>
		/// <param name="m3_LOTY">Lottype</param>
		/// <param name="m3_SUNO">Suppliernumber</param>
		/// <param name="m3_PROD">Manufacturer</param>
		/// <param name="m3_MFIT">Supplier/manufactureritemnumber</param>
		/// <param name="m3_MFSN">Manufacturerserialnumber</param>
		/// <param name="m3_ECVE">Revisionnumber</param>
		/// <param name="m3_CNDT">Follow-update</param>
		/// <param name="m3_ORCO">Countryoforigin</param>
		/// <param name="m3_ARLA">Filingaddress</param>
		/// <param name="m3_IDET">Taggingtype</param>
		/// <param name="m3_CFI3">User-definedfield3-item</param>
		/// <param name="m3_CFJ0">User-definedfield10-servagreement</param>
		/// <param name="m3_CFI2">User-definedfield2-item</param>
		/// <param name="m3_MFDT">Manufacturingdate</param>
		/// <param name="m3_REDA">Receiptdate</param>
		/// <param name="m3_LIRR">LI request rule</param>
		/// <param name="m3_HVDT">Harvested date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdItmLot(
			string m3_ITNO, 
			string m3_BANO, 
			string m3_BREF = null, 
			string m3_BRE2 = null, 
			string m3_FACI = null, 
			string m3_STAS = null, 
			int? m3_RORC = null, 
			int? m3_LOTY = null, 
			string m3_SUNO = null, 
			string m3_PROD = null, 
			string m3_MFIT = null, 
			string m3_MFSN = null, 
			string m3_ECVE = null, 
			DateTime? m3_CNDT = null, 
			string m3_ORCO = null, 
			string m3_ARLA = null, 
			string m3_IDET = null, 
			string m3_CFI3 = null, 
			string m3_CFJ0 = null, 
			decimal? m3_CFI2 = null, 
			DateTime? m3_MFDT = null, 
			DateTime? m3_REDA = null, 
			int? m3_LIRR = null, 
			DateTime? m3_HVDT = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdItmLot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");
			if (string.IsNullOrWhiteSpace(m3_BANO))
				throw new ArgumentNullException("m3_BANO");

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("BANO", m3_BANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_BREF))
				request.WithQueryParameter("BREF", m3_BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BRE2))
				request.WithQueryParameter("BRE2", m3_BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAS))
				request.WithQueryParameter("STAS", m3_STAS.Trim());
			if (m3_RORC.HasValue)
				request.WithQueryParameter("RORC", m3_RORC.Value.ToString());
			if (m3_LOTY.HasValue)
				request.WithQueryParameter("LOTY", m3_LOTY.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SUNO))
				request.WithQueryParameter("SUNO", m3_SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PROD))
				request.WithQueryParameter("PROD", m3_PROD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MFIT))
				request.WithQueryParameter("MFIT", m3_MFIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MFSN))
				request.WithQueryParameter("MFSN", m3_MFSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ECVE))
				request.WithQueryParameter("ECVE", m3_ECVE.Trim());
			if (m3_CNDT.HasValue)
				request.WithQueryParameter("CNDT", m3_CNDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_ORCO))
				request.WithQueryParameter("ORCO", m3_ORCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ARLA))
				request.WithQueryParameter("ARLA", m3_ARLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_IDET))
				request.WithQueryParameter("IDET", m3_IDET.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFI3))
				request.WithQueryParameter("CFI3", m3_CFI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CFJ0))
				request.WithQueryParameter("CFJ0", m3_CFJ0.Trim());
			if (m3_CFI2.HasValue)
				request.WithQueryParameter("CFI2", m3_CFI2.Value.ToString());
			if (m3_MFDT.HasValue)
				request.WithQueryParameter("MFDT", m3_MFDT.Value.ToM3String());
			if (m3_REDA.HasValue)
				request.WithQueryParameter("REDA", m3_REDA.Value.ToM3String());
			if (m3_LIRR.HasValue)
				request.WithQueryParameter("LIRR", m3_LIRR.Value.ToString());
			if (m3_HVDT.HasValue)
				request.WithQueryParameter("HVDT", m3_HVDT.Value.ToM3String());

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
