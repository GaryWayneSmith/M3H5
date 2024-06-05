/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddFreeText
		/// Description Additional text can be entered per item/lot
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BANO">Lot number</param>
		/// <param name="m3TXVR">Text block</param>
		/// <param name="m3TX60">Text</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddFreeText(
			string m3ITNO = null, 
			string m3BANO = null, 
			string m3TXVR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddFreeText",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TXVR))
				request.WithQueryParameter("TXVR", m3TXVR.Trim());
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
		/// Name AddItmLot
		/// Description Adds lot to Item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Itemnumber (Required)</param>
		/// <param name="m3BANO">Lotnumber</param>
		/// <param name="m3BREF">Lotreference1</param>
		/// <param name="m3BRE2">Lotreference2</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3STAS">Status-balanceID</param>
		/// <param name="m3RORC">Referenceordercategory</param>
		/// <param name="m3SUNO">Suppliernumber</param>
		/// <param name="m3PROD">Manufacturer</param>
		/// <param name="m3MFIT">Supplier/manufactureritemnumber</param>
		/// <param name="m3MFSN">Manufacturerserialnumber</param>
		/// <param name="m3ECVE">Revisionnumber</param>
		/// <param name="m3CNDT">Follow-update</param>
		/// <param name="m3ORCO">Countryoforigin</param>
		/// <param name="m3ARLA">Filingaddress</param>
		/// <param name="m3IDET">Taggingtype</param>
		/// <param name="m3LPCY">Potency</param>
		/// <param name="m3MFDT">Manufacturingdate</param>
		/// <param name="m3REDA">Receiptdate</param>
		/// <param name="m3LIRR">LI request rule</param>
		/// <param name="m3HVDT">Harvested date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddItmLotResponse></returns>
		/// <exception cref="M3Exception<AddItmLotResponse>"></exception>
		public async Task<M3Response<AddItmLotResponse>> AddItmLot(
			string m3ITNO, 
			string m3BANO = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			string m3FACI = null, 
			string m3STAS = null, 
			int? m3RORC = null, 
			string m3SUNO = null, 
			string m3PROD = null, 
			string m3MFIT = null, 
			string m3MFSN = null, 
			string m3ECVE = null, 
			DateTime? m3CNDT = null, 
			string m3ORCO = null, 
			string m3ARLA = null, 
			string m3IDET = null, 
			int? m3LPCY = null, 
			DateTime? m3MFDT = null, 
			DateTime? m3REDA = null, 
			int? m3LIRR = null, 
			DateTime? m3HVDT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddItmLot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAS))
				request.WithQueryParameter("STAS", m3STAS.Trim());
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROD))
				request.WithQueryParameter("PROD", m3PROD.Trim());
			if (!string.IsNullOrWhiteSpace(m3MFIT))
				request.WithQueryParameter("MFIT", m3MFIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3MFSN))
				request.WithQueryParameter("MFSN", m3MFSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECVE))
				request.WithQueryParameter("ECVE", m3ECVE.Trim());
			if (m3CNDT.HasValue)
				request.WithQueryParameter("CNDT", m3CNDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ORCO))
				request.WithQueryParameter("ORCO", m3ORCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ARLA))
				request.WithQueryParameter("ARLA", m3ARLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3IDET))
				request.WithQueryParameter("IDET", m3IDET.Trim());
			if (m3LPCY.HasValue)
				request.WithQueryParameter("LPCY", m3LPCY.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MFDT.HasValue)
				request.WithQueryParameter("MFDT", m3MFDT.Value.ToM3String());
			if (m3REDA.HasValue)
				request.WithQueryParameter("REDA", m3REDA.Value.ToM3String());
			if (m3LIRR.HasValue)
				request.WithQueryParameter("LIRR", m3LIRR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3HVDT.HasValue)
				request.WithQueryParameter("HVDT", m3HVDT.Value.ToM3String());

			// Execute the request
			var result = await Execute<AddItmLotResponse>(
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
		/// Name DelItmLot
		/// Description Deletes Item Lot
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Itemnumber (Required)</param>
		/// <param name="m3BANO">Lotnumber (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelItmLot(
			string m3ITNO, 
			string m3BANO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelItmLot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3BANO))
				throw new ArgumentNullException(nameof(m3BANO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("BANO", m3BANO.Trim());

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
		/// Name GetItmLot
		/// Description Display Item Lot
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3ITNO">Itemnumber (Required)</param>
		/// <param name="m3BANO">Lotnumber (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetItmLotResponse></returns>
		/// <exception cref="M3Exception<GetItmLotResponse>"></exception>
		public async Task<M3Response<GetItmLotResponse>> GetItmLot(
			string m3ITNO, 
			string m3BANO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetItmLot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3BANO))
				throw new ArgumentNullException(nameof(m3BANO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("BANO", m3BANO.Trim());

			// Execute the request
			var result = await Execute<GetItmLotResponse>(
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
		/// Name GetLotItm
		/// Description Display Lot Item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3BANO">Lotnumber (Required)</param>
		/// <param name="m3ITNO">Itemnumber (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetLotItmResponse></returns>
		/// <exception cref="M3Exception<GetLotItmResponse>"></exception>
		public async Task<M3Response<GetLotItmResponse>> GetLotItm(
			string m3BANO, 
			string m3ITNO, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetLotItm",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3BANO))
				throw new ArgumentNullException(nameof(m3BANO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("BANO", m3BANO.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Execute the request
			var result = await Execute<GetLotItmResponse>(
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
		/// Name GetManufserItm
		/// Description Display Manufacturer Item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Itemnumber (Required)</param>
		/// <param name="m3MFSN">Manufacturerserialnumber</param>
		/// <param name="m3BANO">Lotnumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetManufserItmResponse></returns>
		/// <exception cref="M3Exception<GetManufserItmResponse>"></exception>
		public async Task<M3Response<GetManufserItmResponse>> GetManufserItm(
			string m3ITNO, 
			string m3MFSN = null, 
			string m3BANO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetManufserItm",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MFSN))
				request.WithQueryParameter("MFSN", m3MFSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());

			// Execute the request
			var result = await Execute<GetManufserItmResponse>(
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
		/// Name GetRocOrdLinItm
		/// Description Display Reference order category Item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3RORC">Referenceordercategory (Required)</param>
		/// <param name="m3RORN">Referenceordernumber (Required)</param>
		/// <param name="m3RORL">Referenceorderline</param>
		/// <param name="m3ITNO">Itemnumber</param>
		/// <param name="m3RORX">Linesuffix</param>
		/// <param name="m3BANO">Lotnumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetRocOrdLinItmResponse></returns>
		/// <exception cref="M3Exception<GetRocOrdLinItmResponse>"></exception>
		public async Task<M3Response<GetRocOrdLinItmResponse>> GetRocOrdLinItm(
			int m3RORC, 
			string m3RORN, 
			int? m3RORL = null, 
			string m3ITNO = null, 
			int? m3RORX = null, 
			string m3BANO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetRocOrdLinItm",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3RORN))
				throw new ArgumentNullException(nameof(m3RORN));

			// Set mandatory parameters
			request
				.WithQueryParameter("RORC", m3RORC.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("RORN", m3RORN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3RORX.HasValue)
				request.WithQueryParameter("RORX", m3RORX.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());

			// Execute the request
			var result = await Execute<GetRocOrdLinItmResponse>(
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
		/// Name LstItmLot
		/// Description List Item Lot
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Itemnumber (Required)</param>
		/// <param name="m3BANO">Lotnumber</param>
		/// <param name="m3BREF">Lotreference1</param>
		/// <param name="m3BRE2">Lotreference2</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstItmLotResponse></returns>
		/// <exception cref="M3Exception<LstItmLotResponse>"></exception>
		public async Task<M3Response<LstItmLotResponse>> LstItmLot(
			string m3ITNO, 
			string m3BANO = null, 
			string m3BREF = null, 
			string m3BRE2 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstItmLot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());

			// Execute the request
			var result = await Execute<LstItmLotResponse>(
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
		/// Name LstLotItm
		/// Description List Lot Item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3BANO">Lotnumber</param>
		/// <param name="m3ITNO">Itemnumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstLotItmResponse></returns>
		/// <exception cref="M3Exception<LstLotItmResponse>"></exception>
		public async Task<M3Response<LstLotItmResponse>> LstLotItm(
			string m3BANO = null, 
			string m3ITNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstLotItm",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3BANO))
				request.WithQueryParameter("BANO", m3BANO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Execute the request
			var result = await Execute<LstLotItmResponse>(
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
		/// Name LstManufserItm
		/// Description List Manufacturer Item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3MFSN">Manufacturerserialnumber</param>
		/// <param name="m3ITNO">Itemnumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstManufserItmResponse></returns>
		/// <exception cref="M3Exception<LstManufserItmResponse>"></exception>
		public async Task<M3Response<LstManufserItmResponse>> LstManufserItm(
			string m3MFSN = null, 
			string m3ITNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstManufserItm",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3MFSN))
				request.WithQueryParameter("MFSN", m3MFSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Execute the request
			var result = await Execute<LstManufserItmResponse>(
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
		/// Name LstRocOrdLinItm
		/// Description List Reference Order category Item
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3RORC">Referenceordercategory</param>
		/// <param name="m3RORN">Referenceordernumber</param>
		/// <param name="m3RORL">Referenceorderline</param>
		/// <param name="m3ITNO">Itemnumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRocOrdLinItmResponse></returns>
		/// <exception cref="M3Exception<LstRocOrdLinItmResponse>"></exception>
		public async Task<M3Response<LstRocOrdLinItmResponse>> LstRocOrdLinItm(
			int? m3RORC = null, 
			string m3RORN = null, 
			int? m3RORL = null, 
			string m3ITNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstRocOrdLinItm",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3RORN))
				request.WithQueryParameter("RORN", m3RORN.Trim());
			if (m3RORL.HasValue)
				request.WithQueryParameter("RORL", m3RORL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Execute the request
			var result = await Execute<LstRocOrdLinItmResponse>(
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
		/// Name RtvNxtLotNo
		/// Description RtvNxtLotNo
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3WHLO">Warehouse (Required)</param>
		/// <param name="m3ITNO">Item number (Required)</param>
		/// <param name="m3CONO">Company</param>
		/// <param name="m3ORCO">Country of origin</param>
		/// <param name="m3PLGR">Work center</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<RtvNxtLotNoResponse></returns>
		/// <exception cref="M3Exception<RtvNxtLotNoResponse>"></exception>
		public async Task<M3Response<RtvNxtLotNoResponse>> RtvNxtLotNo(
			string m3WHLO, 
			string m3ITNO, 
			int? m3CONO = null, 
			string m3ORCO = null, 
			string m3PLGR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/RtvNxtLotNo",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3WHLO))
				throw new ArgumentNullException(nameof(m3WHLO));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("WHLO", m3WHLO.Trim())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORCO))
				request.WithQueryParameter("ORCO", m3ORCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PLGR))
				request.WithQueryParameter("PLGR", m3PLGR.Trim());

			// Execute the request
			var result = await Execute<RtvNxtLotNoResponse>(
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
		/// Name UpdItmLot
		/// Description Updates Item Lot
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ITNO">Itemnumber (Required)</param>
		/// <param name="m3BANO">Lotnumber (Required)</param>
		/// <param name="m3BREF">Lotreference1</param>
		/// <param name="m3BRE2">Lotreference2</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3STAS">Status-balanceID</param>
		/// <param name="m3RORC">Referenceordercategory</param>
		/// <param name="m3LOTY">Lottype</param>
		/// <param name="m3SUNO">Suppliernumber</param>
		/// <param name="m3PROD">Manufacturer</param>
		/// <param name="m3MFIT">Supplier/manufactureritemnumber</param>
		/// <param name="m3MFSN">Manufacturerserialnumber</param>
		/// <param name="m3ECVE">Revisionnumber</param>
		/// <param name="m3CNDT">Follow-update</param>
		/// <param name="m3ORCO">Countryoforigin</param>
		/// <param name="m3ARLA">Filingaddress</param>
		/// <param name="m3IDET">Taggingtype</param>
		/// <param name="m3CFI3">User-definedfield3-item</param>
		/// <param name="m3CFJ0">User-definedfield10-servagreement</param>
		/// <param name="m3CFI2">User-definedfield2-item</param>
		/// <param name="m3MFDT">Manufacturingdate</param>
		/// <param name="m3REDA">Receiptdate</param>
		/// <param name="m3LIRR">LI request rule</param>
		/// <param name="m3HVDT">Harvested date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdItmLot(
			string m3ITNO, 
			string m3BANO, 
			string m3BREF = null, 
			string m3BRE2 = null, 
			string m3FACI = null, 
			string m3STAS = null, 
			int? m3RORC = null, 
			int? m3LOTY = null, 
			string m3SUNO = null, 
			string m3PROD = null, 
			string m3MFIT = null, 
			string m3MFSN = null, 
			string m3ECVE = null, 
			DateTime? m3CNDT = null, 
			string m3ORCO = null, 
			string m3ARLA = null, 
			string m3IDET = null, 
			string m3CFI3 = null, 
			string m3CFJ0 = null, 
			decimal? m3CFI2 = null, 
			DateTime? m3MFDT = null, 
			DateTime? m3REDA = null, 
			int? m3LIRR = null, 
			DateTime? m3HVDT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdItmLot",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));
			if (string.IsNullOrWhiteSpace(m3BANO))
				throw new ArgumentNullException(nameof(m3BANO));

			// Set mandatory parameters
			request
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("BANO", m3BANO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3BREF))
				request.WithQueryParameter("BREF", m3BREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3BRE2))
				request.WithQueryParameter("BRE2", m3BRE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAS))
				request.WithQueryParameter("STAS", m3STAS.Trim());
			if (m3RORC.HasValue)
				request.WithQueryParameter("RORC", m3RORC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LOTY.HasValue)
				request.WithQueryParameter("LOTY", m3LOTY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SUNO))
				request.WithQueryParameter("SUNO", m3SUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3PROD))
				request.WithQueryParameter("PROD", m3PROD.Trim());
			if (!string.IsNullOrWhiteSpace(m3MFIT))
				request.WithQueryParameter("MFIT", m3MFIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3MFSN))
				request.WithQueryParameter("MFSN", m3MFSN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ECVE))
				request.WithQueryParameter("ECVE", m3ECVE.Trim());
			if (m3CNDT.HasValue)
				request.WithQueryParameter("CNDT", m3CNDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3ORCO))
				request.WithQueryParameter("ORCO", m3ORCO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ARLA))
				request.WithQueryParameter("ARLA", m3ARLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3IDET))
				request.WithQueryParameter("IDET", m3IDET.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFI3))
				request.WithQueryParameter("CFI3", m3CFI3.Trim());
			if (!string.IsNullOrWhiteSpace(m3CFJ0))
				request.WithQueryParameter("CFJ0", m3CFJ0.Trim());
			if (m3CFI2.HasValue)
				request.WithQueryParameter("CFI2", m3CFI2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3MFDT.HasValue)
				request.WithQueryParameter("MFDT", m3MFDT.Value.ToM3String());
			if (m3REDA.HasValue)
				request.WithQueryParameter("REDA", m3REDA.Value.ToM3String());
			if (m3LIRR.HasValue)
				request.WithQueryParameter("LIRR", m3LIRR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3HVDT.HasValue)
				request.WithQueryParameter("HVDT", m3HVDT.Value.ToM3String());

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
