/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.OIS017MI;
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
	/// Name: OIS017MI
	/// Component Name: Cust Sales and Service
	/// Description: Sales Price List interface
	/// Version Release: 5e90
	///</summary>
	public partial class OIS017MIResource : M3BaseResourceEndpoint
	{
		public OIS017MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OIS017MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddBasePrice
		/// Description AddBasePrice
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRRF">Pricelist (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_FVDT">Validfrom (Required)</param>
		/// <param name="m3_ITNO">Itemnumber (Required)</param>
		/// <param name="m3_SAPR">Salesprice (Required)</param>
		/// <param name="m3_CUNO">Customernumber</param>
		/// <param name="m3_SACD">Salespricequantity</param>
		/// <param name="m3_SPUN">Salespriceunitofmeasure</param>
		/// <param name="m3_NTCD">Netpriceused</param>
		/// <param name="m3_CMNO">Salescampaign</param>
		/// <param name="m3_FMID">Formula</param>
		/// <param name="m3_RESI">Resultidentity</param>
		/// <param name="m3_MXID">Scale</param>
		/// <param name="m3_SGGU">Scaleunitofmeasure</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBasePrice(
			string m3_PRRF, 
			string m3_CUCD, 
			DateTime m3_FVDT, 
			string m3_ITNO, 
			decimal m3_SAPR, 
			string m3_CUNO = null, 
			int? m3_SACD = null, 
			string m3_SPUN = null, 
			int? m3_NTCD = null, 
			string m3_CMNO = null, 
			string m3_FMID = null, 
			string m3_RESI = null, 
			string m3_MXID = null, 
			string m3_SGGU = null, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddBasePrice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRRF))
				throw new ArgumentNullException("m3_PRRF");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3_PRRF.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("SAPR", m3_SAPR.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (m3_SACD.HasValue)
				request.WithQueryParameter("SACD", m3_SACD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SPUN))
				request.WithQueryParameter("SPUN", m3_SPUN.Trim());
			if (m3_NTCD.HasValue)
				request.WithQueryParameter("NTCD", m3_NTCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CMNO))
				request.WithQueryParameter("CMNO", m3_CMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FMID))
				request.WithQueryParameter("FMID", m3_FMID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESI))
				request.WithQueryParameter("RESI", m3_RESI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MXID))
				request.WithQueryParameter("MXID", m3_MXID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SGGU))
				request.WithQueryParameter("SGGU", m3_SGGU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());

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
		/// Name AddGradSlsPrc
		/// Description Add Grad Sls Prc
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRRF">Pricelist (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_FVDT">Validfrom (Required)</param>
		/// <param name="m3_ITNO">Itemnumber (Required)</param>
		/// <param name="m3_QTYL">Lowestquantitylimit (Required)</param>
		/// <param name="m3_CUNO">Customernumber</param>
		/// <param name="m3_PCOF">Priceadjustmentfactor</param>
		/// <param name="m3_SAPR">Salesprice</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddGradSlsPrc(
			string m3_PRRF, 
			string m3_CUCD, 
			DateTime m3_FVDT, 
			string m3_ITNO, 
			decimal m3_QTYL, 
			string m3_CUNO = null, 
			decimal? m3_PCOF = null, 
			decimal? m3_SAPR = null, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddGradSlsPrc",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRRF))
				throw new ArgumentNullException("m3_PRRF");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3_PRRF.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("QTYL", m3_QTYL.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (m3_PCOF.HasValue)
				request.WithQueryParameter("PCOF", m3_PCOF.Value.ToString());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());

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
		/// Name AddPriceList
		/// Description CreatePriceList
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRRF">Pricelist (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_FVDT">Validfrom (Required)</param>
		/// <param name="m3_LVDT">Validto (Required)</param>
		/// <param name="m3_TX40">Description (Required)</param>
		/// <param name="m3_CRTP">Exchangeratetype (Required)</param>
		/// <param name="m3_CUNO">Customernumber</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_CMNO">Salescampaign</param>
		/// <param name="m3_ACGR">Objectaccessgroup</param>
		/// <param name="m3_SCMU">Manualupdate-salesprices</param>
		/// <param name="m3_SCSC">Manualupdaterule</param>
		/// <param name="m3_NTCD">Netpriceused</param>
		/// <param name="m3_ROPP">Rounding-offcategory</param>
		/// <param name="m3_BNCD">Bonusgenerating</param>
		/// <param name="m3_PRAC">Commissiongenerating</param>
		/// <param name="m3_OBJ1">Field</param>
		/// <param name="m3_OBJ2">Field</param>
		/// <param name="m3_OBJ3">Field</param>
		/// <param name="m3_SCMO">Costingmodel-salesprice</param>
		/// <param name="m3_SCAC">Automaticsalespricecalculation</param>
		/// <param name="m3_SCBR">Costingbaseroundedoff-salesprice</param>
		/// <param name="m3_WSCA">Costingmodel-purchasing</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_BAPL">Basicpricelist</param>
		/// <param name="m3_E0CB">Currency</param>
		/// <param name="m3_CUN2">Customer</param>
		/// <param name="m3_FVD2">Validfrom</param>
		/// <param name="m3_PCTP">Costing type</param>
		/// <param name="m3_1OBJ">Field</param>
		/// <param name="m3_2OBJ">Field</param>
		/// <param name="m3_3OBJ">Field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPriceList(
			string m3_PRRF, 
			string m3_CUCD, 
			DateTime m3_FVDT, 
			DateTime m3_LVDT, 
			string m3_TX40, 
			int m3_CRTP, 
			string m3_CUNO = null, 
			string m3_TX15 = null, 
			string m3_CMNO = null, 
			string m3_ACGR = null, 
			int? m3_SCMU = null, 
			int? m3_SCSC = null, 
			int? m3_NTCD = null, 
			int? m3_ROPP = null, 
			int? m3_BNCD = null, 
			int? m3_PRAC = null, 
			string m3_OBJ1 = null, 
			string m3_OBJ2 = null, 
			string m3_OBJ3 = null, 
			string m3_SCMO = null, 
			int? m3_SCAC = null, 
			int? m3_SCBR = null, 
			string m3_WSCA = null, 
			string m3_WHLO = null, 
			string m3_BAPL = null, 
			string m3_E0CB = null, 
			string m3_CUN2 = null, 
			DateTime? m3_FVD2 = null, 
			string m3_PCTP = null, 
			string m3_1OBJ = null, 
			string m3_2OBJ = null, 
			string m3_3OBJ = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddPriceList",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRRF))
				throw new ArgumentNullException("m3_PRRF");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");
			if (string.IsNullOrWhiteSpace(m3_TX40))
				throw new ArgumentNullException("m3_TX40");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3_PRRF.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String())
				.WithQueryParameter("LVDT", m3_LVDT.ToM3String())
				.WithQueryParameter("TX40", m3_TX40.Trim())
				.WithQueryParameter("CRTP", m3_CRTP.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CMNO))
				request.WithQueryParameter("CMNO", m3_CMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACGR))
				request.WithQueryParameter("ACGR", m3_ACGR.Trim());
			if (m3_SCMU.HasValue)
				request.WithQueryParameter("SCMU", m3_SCMU.Value.ToString());
			if (m3_SCSC.HasValue)
				request.WithQueryParameter("SCSC", m3_SCSC.Value.ToString());
			if (m3_NTCD.HasValue)
				request.WithQueryParameter("NTCD", m3_NTCD.Value.ToString());
			if (m3_ROPP.HasValue)
				request.WithQueryParameter("ROPP", m3_ROPP.Value.ToString());
			if (m3_BNCD.HasValue)
				request.WithQueryParameter("BNCD", m3_BNCD.Value.ToString());
			if (m3_PRAC.HasValue)
				request.WithQueryParameter("PRAC", m3_PRAC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OBJ1))
				request.WithQueryParameter("OBJ1", m3_OBJ1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBJ2))
				request.WithQueryParameter("OBJ2", m3_OBJ2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBJ3))
				request.WithQueryParameter("OBJ3", m3_OBJ3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SCMO))
				request.WithQueryParameter("SCMO", m3_SCMO.Trim());
			if (m3_SCAC.HasValue)
				request.WithQueryParameter("SCAC", m3_SCAC.Value.ToString());
			if (m3_SCBR.HasValue)
				request.WithQueryParameter("SCBR", m3_SCBR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WSCA))
				request.WithQueryParameter("WSCA", m3_WSCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAPL))
				request.WithQueryParameter("BAPL", m3_BAPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0CB))
				request.WithQueryParameter("E0CB", m3_E0CB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUN2))
				request.WithQueryParameter("CUN2", m3_CUN2.Trim());
			if (m3_FVD2.HasValue)
				request.WithQueryParameter("FVD2", m3_FVD2.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PCTP))
				request.WithQueryParameter("PCTP", m3_PCTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_1OBJ))
				request.WithQueryParameter("1OBJ", m3_1OBJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_2OBJ))
				request.WithQueryParameter("2OBJ", m3_2OBJ.Trim());
			if (!string.IsNullOrWhiteSpace(m3_3OBJ))
				request.WithQueryParameter("3OBJ", m3_3OBJ.Trim());

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
		/// Name AddScaleKey
		/// Description Add Scale Key
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRRF">Pricelist (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_FVDT">Validfrom (Required)</param>
		/// <param name="m3_MXID">Scale (Required)</param>
		/// <param name="m3_CUNO">Customernumber</param>
		/// <param name="m3_OBV1">Startvalue1</param>
		/// <param name="m3_OBV2">Startvalue2</param>
		/// <param name="m3_OBV3">Startvalue3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddScaleKey(
			string m3_PRRF, 
			string m3_CUCD, 
			DateTime m3_FVDT, 
			string m3_MXID, 
			string m3_CUNO = null, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddScaleKey",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRRF))
				throw new ArgumentNullException("m3_PRRF");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");
			if (string.IsNullOrWhiteSpace(m3_MXID))
				throw new ArgumentNullException("m3_MXID");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3_PRRF.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String())
				.WithQueryParameter("MXID", m3_MXID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());

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
		/// Name ChgPriceList
		/// Description Update Price List
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRRF">Pricelist (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_FVDT">Validfrom (Required)</param>
		/// <param name="m3_CUNO">Customernumber</param>
		/// <param name="m3_LVDT">Validto</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="m3_CMNO">Salescampaign</param>
		/// <param name="m3_ACGR">Objectaccessgroup</param>
		/// <param name="m3_SCMU">Manualupdate-salesprices</param>
		/// <param name="m3_SCSC">Manualupdaterule</param>
		/// <param name="m3_NTCD">Netpriceused</param>
		/// <param name="m3_ROPP">Rounding-offcategory</param>
		/// <param name="m3_BNCD">Bonusgenerating</param>
		/// <param name="m3_PRAC">Commissiongenerating</param>
		/// <param name="m3_SCMO">Costingmodel-salesprice</param>
		/// <param name="m3_SCAC">Automaticsalespricecalculation</param>
		/// <param name="m3_SCBR">Costingbaseroundedoff-salesprice</param>
		/// <param name="m3_CRTP">Exchangeratetype</param>
		/// <param name="m3_WSCA">Costingmodel-purchasing</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_BAPL">Basicpricelist</param>
		/// <param name="m3_E0CB">Currency</param>
		/// <param name="m3_CUN2">Customer</param>
		/// <param name="m3_FVD2">Validfrom</param>
		/// <param name="m3_PCTP">Costingtype</param>
		/// <param name="m3_OBJ1">Field</param>
		/// <param name="m3_OBJ2">Field</param>
		/// <param name="m3_OBJ3">Field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgPriceList(
			string m3_PRRF, 
			string m3_CUCD, 
			DateTime m3_FVDT, 
			string m3_CUNO = null, 
			DateTime? m3_LVDT = null, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
			string m3_CMNO = null, 
			string m3_ACGR = null, 
			int? m3_SCMU = null, 
			int? m3_SCSC = null, 
			int? m3_NTCD = null, 
			int? m3_ROPP = null, 
			int? m3_BNCD = null, 
			int? m3_PRAC = null, 
			string m3_SCMO = null, 
			int? m3_SCAC = null, 
			int? m3_SCBR = null, 
			int? m3_CRTP = null, 
			string m3_WSCA = null, 
			string m3_WHLO = null, 
			string m3_BAPL = null, 
			string m3_E0CB = null, 
			string m3_CUN2 = null, 
			DateTime? m3_FVD2 = null, 
			string m3_PCTP = null, 
			string m3_OBJ1 = null, 
			string m3_OBJ2 = null, 
			string m3_OBJ3 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/ChgPriceList",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRRF))
				throw new ArgumentNullException("m3_PRRF");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3_PRRF.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (m3_LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3_LVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CMNO))
				request.WithQueryParameter("CMNO", m3_CMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ACGR))
				request.WithQueryParameter("ACGR", m3_ACGR.Trim());
			if (m3_SCMU.HasValue)
				request.WithQueryParameter("SCMU", m3_SCMU.Value.ToString());
			if (m3_SCSC.HasValue)
				request.WithQueryParameter("SCSC", m3_SCSC.Value.ToString());
			if (m3_NTCD.HasValue)
				request.WithQueryParameter("NTCD", m3_NTCD.Value.ToString());
			if (m3_ROPP.HasValue)
				request.WithQueryParameter("ROPP", m3_ROPP.Value.ToString());
			if (m3_BNCD.HasValue)
				request.WithQueryParameter("BNCD", m3_BNCD.Value.ToString());
			if (m3_PRAC.HasValue)
				request.WithQueryParameter("PRAC", m3_PRAC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SCMO))
				request.WithQueryParameter("SCMO", m3_SCMO.Trim());
			if (m3_SCAC.HasValue)
				request.WithQueryParameter("SCAC", m3_SCAC.Value.ToString());
			if (m3_SCBR.HasValue)
				request.WithQueryParameter("SCBR", m3_SCBR.Value.ToString());
			if (m3_CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3_CRTP.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_WSCA))
				request.WithQueryParameter("WSCA", m3_WSCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAPL))
				request.WithQueryParameter("BAPL", m3_BAPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_E0CB))
				request.WithQueryParameter("E0CB", m3_E0CB.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUN2))
				request.WithQueryParameter("CUN2", m3_CUN2.Trim());
			if (m3_FVD2.HasValue)
				request.WithQueryParameter("FVD2", m3_FVD2.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_PCTP))
				request.WithQueryParameter("PCTP", m3_PCTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBJ1))
				request.WithQueryParameter("OBJ1", m3_OBJ1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBJ2))
				request.WithQueryParameter("OBJ2", m3_OBJ2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBJ3))
				request.WithQueryParameter("OBJ3", m3_OBJ3.Trim());

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
		/// Name DelBasePrice
		/// Description Del Base Price
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRRF">Pricelist (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_FVDT">Validfrom (Required)</param>
		/// <param name="m3_ITNO">Itemnumber (Required)</param>
		/// <param name="m3_CUNO">Customernumber</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelBasePrice(
			string m3_PRRF, 
			string m3_CUCD, 
			DateTime m3_FVDT, 
			string m3_ITNO, 
			string m3_CUNO = null, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelBasePrice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRRF))
				throw new ArgumentNullException("m3_PRRF");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3_PRRF.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());

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
		/// Name DelGradSlsPrc
		/// Description Del Grad Sls Prc
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRRF">Pricelist (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_FVDT">Validfrom (Required)</param>
		/// <param name="m3_ITNO">Itemnumber (Required)</param>
		/// <param name="m3_QTYL">Lowestquantitylimit (Required)</param>
		/// <param name="m3_CUNO">Customernumber</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelGradSlsPrc(
			string m3_PRRF, 
			string m3_CUCD, 
			DateTime m3_FVDT, 
			string m3_ITNO, 
			decimal m3_QTYL, 
			string m3_CUNO = null, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelGradSlsPrc",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRRF))
				throw new ArgumentNullException("m3_PRRF");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3_PRRF.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("QTYL", m3_QTYL.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());

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
		/// Name DelPriceList
		/// Description Delete Price List
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRRF">Pricelist (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_FVDT">Validfrom (Required)</param>
		/// <param name="m3_CUNO">Customernumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelPriceList(
			string m3_PRRF, 
			string m3_CUCD, 
			DateTime m3_FVDT, 
			string m3_CUNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelPriceList",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRRF))
				throw new ArgumentNullException("m3_PRRF");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3_PRRF.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());

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
		/// Name DelScaleKey
		/// Description Delete Scale Key
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRRF">Pricelist (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_FVDT">Validfrom (Required)</param>
		/// <param name="m3_CUNO">Customernumber</param>
		/// <param name="m3_OBV1">Startvalue1</param>
		/// <param name="m3_OBV2">Startvalue2</param>
		/// <param name="m3_OBV3">Startvalue3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelScaleKey(
			string m3_PRRF, 
			string m3_CUCD, 
			DateTime m3_FVDT, 
			string m3_CUNO = null, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelScaleKey",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRRF))
				throw new ArgumentNullException("m3_PRRF");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3_PRRF.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());

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
		/// Name GetBasePrice
		/// Description Get Base Price
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRRF">Pricelist (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_FVDT">Validfrom (Required)</param>
		/// <param name="m3_ITNO">Itemnumber (Required)</param>
		/// <param name="m3_CUNO">Customernumber</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBasePriceResponse></returns>
		/// <exception cref="M3Exception<GetBasePriceResponse>"></exception>
		public async Task<M3Response<GetBasePriceResponse>> GetBasePrice(
			string m3_PRRF, 
			string m3_CUCD, 
			DateTime m3_FVDT, 
			string m3_ITNO, 
			string m3_CUNO = null, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetBasePrice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRRF))
				throw new ArgumentNullException("m3_PRRF");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3_PRRF.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());

			// Execute the request
			var result = await Execute<GetBasePriceResponse>(
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
		/// Name GetPriceList
		/// Description Get Price List
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRRF">Pricelist (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_FVDT">Validfrom (Required)</param>
		/// <param name="m3_CUNO">Customernumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPriceListResponse></returns>
		/// <exception cref="M3Exception<GetPriceListResponse>"></exception>
		public async Task<M3Response<GetPriceListResponse>> GetPriceList(
			string m3_PRRF, 
			string m3_CUCD, 
			DateTime m3_FVDT, 
			string m3_CUNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetPriceList",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRRF))
				throw new ArgumentNullException("m3_PRRF");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3_PRRF.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Execute the request
			var result = await Execute<GetPriceListResponse>(
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
		/// Name GetScaleKey
		/// Description Get Scale Key
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRRF">Pricelist (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_FVDT">Validfrom (Required)</param>
		/// <param name="m3_CUNO">Customernumber</param>
		/// <param name="m3_OBV1">Startvalue1</param>
		/// <param name="m3_OBV2">Startvalue2</param>
		/// <param name="m3_OBV3">Startvalue3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetScaleKeyResponse></returns>
		/// <exception cref="M3Exception<GetScaleKeyResponse>"></exception>
		public async Task<M3Response<GetScaleKeyResponse>> GetScaleKey(
			string m3_PRRF, 
			string m3_CUCD, 
			DateTime m3_FVDT, 
			string m3_CUNO = null, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetScaleKey",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRRF))
				throw new ArgumentNullException("m3_PRRF");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3_PRRF.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());

			// Execute the request
			var result = await Execute<GetScaleKeyResponse>(
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
		/// Name LstBasePrice
		/// Description Lst Base Price
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRRF">Pricelist (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_FVDT">Validfrom (Required)</param>
		/// <param name="m3_CUNO">Customernumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBasePriceResponse></returns>
		/// <exception cref="M3Exception<LstBasePriceResponse>"></exception>
		public async Task<M3Response<LstBasePriceResponse>> LstBasePrice(
			string m3_PRRF, 
			string m3_CUCD, 
			DateTime m3_FVDT, 
			string m3_CUNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstBasePrice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRRF))
				throw new ArgumentNullException("m3_PRRF");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3_PRRF.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Execute the request
			var result = await Execute<LstBasePriceResponse>(
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
		/// Name LstGradSlsPrc
		/// Description Lst Grad Sls Prc
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRRF">Pricelist (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_FVDT">Validfrom (Required)</param>
		/// <param name="m3_ITNO">Itemnumber (Required)</param>
		/// <param name="m3_CUNO">Customernumber</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstGradSlsPrcResponse></returns>
		/// <exception cref="M3Exception<LstGradSlsPrcResponse>"></exception>
		public async Task<M3Response<LstGradSlsPrcResponse>> LstGradSlsPrc(
			string m3_PRRF, 
			string m3_CUCD, 
			DateTime m3_FVDT, 
			string m3_ITNO, 
			string m3_CUNO = null, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstGradSlsPrc",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRRF))
				throw new ArgumentNullException("m3_PRRF");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3_PRRF.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());

			// Execute the request
			var result = await Execute<LstGradSlsPrcResponse>(
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
		/// Name LstPriceList
		/// Description List Price List
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRRF">Pricelist</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_CUNO">Customer</param>
		/// <param name="m3_FVDT">Valid from</param>
		/// <param name="m3_NFTR">Number of filters</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPriceListResponse></returns>
		/// <exception cref="M3Exception<LstPriceListResponse>"></exception>
		public async Task<M3Response<LstPriceListResponse>> LstPriceList(
			string m3_PRRF = null, 
			string m3_CUCD = null, 
			string m3_CUNO = null, 
			DateTime? m3_FVDT = null, 
			int? m3_NFTR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPriceList",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_PRRF))
				request.WithQueryParameter("PRRF", m3_PRRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (m3_FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3_FVDT.Value.ToM3String());
			if (m3_NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3_NFTR.Value.ToString());

			// Execute the request
			var result = await Execute<LstPriceListResponse>(
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
		/// Name LstScaleKey
		/// Description List Scale Key
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRRF">Pricelist (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_FVDT">Validfrom (Required)</param>
		/// <param name="m3_CUNO">Customernumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstScaleKeyResponse></returns>
		/// <exception cref="M3Exception<LstScaleKeyResponse>"></exception>
		public async Task<M3Response<LstScaleKeyResponse>> LstScaleKey(
			string m3_PRRF, 
			string m3_CUCD, 
			DateTime m3_FVDT, 
			string m3_CUNO = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstScaleKey",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRRF))
				throw new ArgumentNullException("m3_PRRF");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3_PRRF.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Execute the request
			var result = await Execute<LstScaleKeyResponse>(
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
		/// Name UpdBasePrice
		/// Description Chg Base Price
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRRF">Pricelist (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_FVDT">Validfrom (Required)</param>
		/// <param name="m3_ITNO">Itemnumber (Required)</param>
		/// <param name="m3_CUNO">Customernumber</param>
		/// <param name="m3_SAPR">Salesprice</param>
		/// <param name="m3_SACD">Salespricequantity</param>
		/// <param name="m3_SPUN">Salespriceunitofmeasure</param>
		/// <param name="m3_NTCD">Netpriceused</param>
		/// <param name="m3_CMNO">Salescampaign</param>
		/// <param name="m3_FMID">Formula</param>
		/// <param name="m3_RESI">Resultidentity</param>
		/// <param name="m3_MXID">Scale</param>
		/// <param name="m3_SGGU">Scaleunitofmeasure</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdBasePrice(
			string m3_PRRF, 
			string m3_CUCD, 
			DateTime m3_FVDT, 
			string m3_ITNO, 
			string m3_CUNO = null, 
			decimal? m3_SAPR = null, 
			int? m3_SACD = null, 
			string m3_SPUN = null, 
			int? m3_NTCD = null, 
			string m3_CMNO = null, 
			string m3_FMID = null, 
			string m3_RESI = null, 
			string m3_MXID = null, 
			string m3_SGGU = null, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdBasePrice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRRF))
				throw new ArgumentNullException("m3_PRRF");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3_PRRF.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String())
				.WithQueryParameter("ITNO", m3_ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (m3_SACD.HasValue)
				request.WithQueryParameter("SACD", m3_SACD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_SPUN))
				request.WithQueryParameter("SPUN", m3_SPUN.Trim());
			if (m3_NTCD.HasValue)
				request.WithQueryParameter("NTCD", m3_NTCD.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_CMNO))
				request.WithQueryParameter("CMNO", m3_CMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FMID))
				request.WithQueryParameter("FMID", m3_FMID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_RESI))
				request.WithQueryParameter("RESI", m3_RESI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MXID))
				request.WithQueryParameter("MXID", m3_MXID.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SGGU))
				request.WithQueryParameter("SGGU", m3_SGGU.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());

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
		/// Name UpdGradSlsPrc
		/// Description Upd Grad Sls Prc
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRRF">Pricelist (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_FVDT">Validfrom (Required)</param>
		/// <param name="m3_ITNO">Itemnumber (Required)</param>
		/// <param name="m3_QTYL">Lowestquantitylimit (Required)</param>
		/// <param name="m3_CUNO">Customernumber</param>
		/// <param name="m3_PCOF">Priceadjustmentfactor</param>
		/// <param name="m3_SAPR">Salesprice</param>
		/// <param name="m3_OBV1">Start value 1</param>
		/// <param name="m3_OBV2">Start value 2</param>
		/// <param name="m3_OBV3">Start value 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdGradSlsPrc(
			string m3_PRRF, 
			string m3_CUCD, 
			DateTime m3_FVDT, 
			string m3_ITNO, 
			decimal m3_QTYL, 
			string m3_CUNO = null, 
			decimal? m3_PCOF = null, 
			decimal? m3_SAPR = null, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdGradSlsPrc",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRRF))
				throw new ArgumentNullException("m3_PRRF");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");
			if (string.IsNullOrWhiteSpace(m3_ITNO))
				throw new ArgumentNullException("m3_ITNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3_PRRF.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String())
				.WithQueryParameter("ITNO", m3_ITNO.Trim())
				.WithQueryParameter("QTYL", m3_QTYL.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (m3_PCOF.HasValue)
				request.WithQueryParameter("PCOF", m3_PCOF.Value.ToString());
			if (m3_SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3_SAPR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());

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
		/// Name UpdPriceList
		/// Description Upd Price List
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRRF">Pricelist (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_FVDT">Validfrom (Required)</param>
		/// <param name="m3_PCDT">Costingdate (Required)</param>
		/// <param name="m3_FNCH">Functionselection (Required)</param>
		/// <param name="m3_CUNO">Customernumber</param>
		/// <param name="m3_PROC">Changepct</param>
		/// <param name="m3_AMTA">Changeamount</param>
		/// <param name="m3_UPIT">Updateitem</param>
		/// <param name="m3_FITN">Fromitemnumber</param>
		/// <param name="m3_TITN">Toitemnumber</param>
		/// <param name="m3_FITG">Fromitemgroup</param>
		/// <param name="m3_TITG">Toitemgroup</param>
		/// <param name="m3_FITC">Fromproductgroup</param>
		/// <param name="m3_TITC">Toproductgroup</param>
		/// <param name="m3_FITT">Fromitemtype</param>
		/// <param name="m3_TITT">Toitemtype</param>
		/// <param name="m3_FRSP">Fromitemresponsible</param>
		/// <param name="m3_TRSP">Toitemresponsible</param>
		/// <param name="m3_SLFR">Fromstatus</param>
		/// <param name="m3_SLTO">Tostatus</param>
		/// <param name="m3_FMAB">Frommake/buycode</param>
		/// <param name="m3_TMAB">Tomake/buycode</param>
		/// <param name="m3_FCHC">Fromconfigurationcode</param>
		/// <param name="m3_TCHC">Toconfigurationcode</param>
		/// <param name="m3_FSUN">Frommainsupplier</param>
		/// <param name="m3_TSUN">Tomainsupplier</param>
		/// <param name="m3_FCUN">Fromcustomernumber</param>
		/// <param name="m3_TCUN">Tocustomernumber</param>
		/// <param name="m3_FBGR">Frombonusgroup</param>
		/// <param name="m3_TBGR">Tobonusgroup</param>
		/// <param name="m3_FPRC">Fromcommissiongroup</param>
		/// <param name="m3_TPRC">Tocommissiongroup</param>
		/// <param name="m3_FASS">Fromassortment</param>
		/// <param name="m3_TASS">Toassortment</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPriceList(
			string m3_PRRF, 
			string m3_CUCD, 
			DateTime m3_FVDT, 
			DateTime m3_PCDT, 
			int m3_FNCH, 
			string m3_CUNO = null, 
			int? m3_PROC = null, 
			decimal? m3_AMTA = null, 
			int? m3_UPIT = null, 
			string m3_FITN = null, 
			string m3_TITN = null, 
			string m3_FITG = null, 
			string m3_TITG = null, 
			string m3_FITC = null, 
			string m3_TITC = null, 
			string m3_FITT = null, 
			string m3_TITT = null, 
			string m3_FRSP = null, 
			string m3_TRSP = null, 
			string m3_SLFR = null, 
			string m3_SLTO = null, 
			int? m3_FMAB = null, 
			int? m3_TMAB = null, 
			int? m3_FCHC = null, 
			int? m3_TCHC = null, 
			string m3_FSUN = null, 
			string m3_TSUN = null, 
			string m3_FCUN = null, 
			string m3_TCUN = null, 
			string m3_FBGR = null, 
			string m3_TBGR = null, 
			string m3_FPRC = null, 
			string m3_TPRC = null, 
			string m3_FASS = null, 
			string m3_TASS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdPriceList",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRRF))
				throw new ArgumentNullException("m3_PRRF");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3_PRRF.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String())
				.WithQueryParameter("PCDT", m3_PCDT.ToM3String())
				.WithQueryParameter("FNCH", m3_FNCH.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (m3_PROC.HasValue)
				request.WithQueryParameter("PROC", m3_PROC.Value.ToString());
			if (m3_AMTA.HasValue)
				request.WithQueryParameter("AMTA", m3_AMTA.Value.ToString());
			if (m3_UPIT.HasValue)
				request.WithQueryParameter("UPIT", m3_UPIT.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FITN))
				request.WithQueryParameter("FITN", m3_FITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TITN))
				request.WithQueryParameter("TITN", m3_TITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FITG))
				request.WithQueryParameter("FITG", m3_FITG.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TITG))
				request.WithQueryParameter("TITG", m3_TITG.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FITC))
				request.WithQueryParameter("FITC", m3_FITC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TITC))
				request.WithQueryParameter("TITC", m3_TITC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FITT))
				request.WithQueryParameter("FITT", m3_FITT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TITT))
				request.WithQueryParameter("TITT", m3_TITT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRSP))
				request.WithQueryParameter("FRSP", m3_FRSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRSP))
				request.WithQueryParameter("TRSP", m3_TRSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLFR))
				request.WithQueryParameter("SLFR", m3_SLFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SLTO))
				request.WithQueryParameter("SLTO", m3_SLTO.Trim());
			if (m3_FMAB.HasValue)
				request.WithQueryParameter("FMAB", m3_FMAB.Value.ToString());
			if (m3_TMAB.HasValue)
				request.WithQueryParameter("TMAB", m3_TMAB.Value.ToString());
			if (m3_FCHC.HasValue)
				request.WithQueryParameter("FCHC", m3_FCHC.Value.ToString());
			if (m3_TCHC.HasValue)
				request.WithQueryParameter("TCHC", m3_TCHC.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FSUN))
				request.WithQueryParameter("FSUN", m3_FSUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TSUN))
				request.WithQueryParameter("TSUN", m3_TSUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCUN))
				request.WithQueryParameter("FCUN", m3_FCUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TCUN))
				request.WithQueryParameter("TCUN", m3_TCUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FBGR))
				request.WithQueryParameter("FBGR", m3_FBGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TBGR))
				request.WithQueryParameter("TBGR", m3_TBGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FPRC))
				request.WithQueryParameter("FPRC", m3_FPRC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TPRC))
				request.WithQueryParameter("TPRC", m3_TPRC.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FASS))
				request.WithQueryParameter("FASS", m3_FASS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TASS))
				request.WithQueryParameter("TASS", m3_TASS.Trim());

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
		/// Name UpdScaleKey
		/// Description Update Scale Key
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3_PRRF">Pricelist (Required)</param>
		/// <param name="m3_CUCD">Currency (Required)</param>
		/// <param name="m3_FVDT">Validfrom (Required)</param>
		/// <param name="m3_CUNO">Customernumber</param>
		/// <param name="m3_OBV1">Startvalue1</param>
		/// <param name="m3_OBV2">Startvalue2</param>
		/// <param name="m3_OBV3">Startvalue3</param>
		/// <param name="m3_MXID">Scale</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdScaleKey(
			string m3_PRRF, 
			string m3_CUCD, 
			DateTime m3_FVDT, 
			string m3_CUNO = null, 
			string m3_OBV1 = null, 
			string m3_OBV2 = null, 
			string m3_OBV3 = null, 
			string m3_MXID = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/UpdScaleKey",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_PRRF))
				throw new ArgumentNullException("m3_PRRF");
			if (string.IsNullOrWhiteSpace(m3_CUCD))
				throw new ArgumentNullException("m3_CUCD");

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3_PRRF.Trim())
				.WithQueryParameter("CUCD", m3_CUCD.Trim())
				.WithQueryParameter("FVDT", m3_FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_CUNO))
				request.WithQueryParameter("CUNO", m3_CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV1))
				request.WithQueryParameter("OBV1", m3_OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV2))
				request.WithQueryParameter("OBV2", m3_OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_OBV3))
				request.WithQueryParameter("OBV3", m3_OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_MXID))
				request.WithQueryParameter("MXID", m3_MXID.Trim());

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
