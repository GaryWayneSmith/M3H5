/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddBasePrice
		/// Description AddBasePrice
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PRRF">Pricelist (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3FVDT">Validfrom (Required)</param>
		/// <param name="m3ITNO">Itemnumber (Required)</param>
		/// <param name="m3SAPR">Salesprice (Required)</param>
		/// <param name="m3CUNO">Customernumber</param>
		/// <param name="m3SACD">Salespricequantity</param>
		/// <param name="m3SPUN">Salespriceunitofmeasure</param>
		/// <param name="m3NTCD">Netpriceused</param>
		/// <param name="m3CMNO">Salescampaign</param>
		/// <param name="m3FMID">Formula</param>
		/// <param name="m3RESI">Resultidentity</param>
		/// <param name="m3MXID">Scale</param>
		/// <param name="m3SGGU">Scaleunitofmeasure</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddBasePrice(
			string m3PRRF, 
			string m3CUCD, 
			DateTime m3FVDT, 
			string m3ITNO, 
			decimal m3SAPR, 
			string m3CUNO = null, 
			int? m3SACD = null, 
			string m3SPUN = null, 
			int? m3NTCD = null, 
			string m3CMNO = null, 
			string m3FMID = null, 
			string m3RESI = null, 
			string m3MXID = null, 
			string m3SGGU = null, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddBasePrice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRRF))
				throw new ArgumentNullException(nameof(m3PRRF));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3PRRF.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("SAPR", m3SAPR.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (m3SACD.HasValue)
				request.WithQueryParameter("SACD", m3SACD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SPUN))
				request.WithQueryParameter("SPUN", m3SPUN.Trim());
			if (m3NTCD.HasValue)
				request.WithQueryParameter("NTCD", m3NTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CMNO))
				request.WithQueryParameter("CMNO", m3CMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FMID))
				request.WithQueryParameter("FMID", m3FMID.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESI))
				request.WithQueryParameter("RESI", m3RESI.Trim());
			if (!string.IsNullOrWhiteSpace(m3MXID))
				request.WithQueryParameter("MXID", m3MXID.Trim());
			if (!string.IsNullOrWhiteSpace(m3SGGU))
				request.WithQueryParameter("SGGU", m3SGGU.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());

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
		/// Name AddGradSlsPrc
		/// Description Add Grad Sls Prc
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PRRF">Pricelist (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3FVDT">Validfrom (Required)</param>
		/// <param name="m3ITNO">Itemnumber (Required)</param>
		/// <param name="m3QTYL">Lowestquantitylimit (Required)</param>
		/// <param name="m3CUNO">Customernumber</param>
		/// <param name="m3PCOF">Priceadjustmentfactor</param>
		/// <param name="m3SAPR">Salesprice</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddGradSlsPrc(
			string m3PRRF, 
			string m3CUCD, 
			DateTime m3FVDT, 
			string m3ITNO, 
			decimal m3QTYL, 
			string m3CUNO = null, 
			decimal? m3PCOF = null, 
			decimal? m3SAPR = null, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddGradSlsPrc",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRRF))
				throw new ArgumentNullException(nameof(m3PRRF));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3PRRF.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("QTYL", m3QTYL.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (m3PCOF.HasValue)
				request.WithQueryParameter("PCOF", m3PCOF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());

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
		/// Name AddPriceList
		/// Description CreatePriceList
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PRRF">Pricelist (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3FVDT">Validfrom (Required)</param>
		/// <param name="m3LVDT">Validto (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3CRTP">Exchangeratetype (Required)</param>
		/// <param name="m3CUNO">Customernumber</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3CMNO">Salescampaign</param>
		/// <param name="m3ACGR">Objectaccessgroup</param>
		/// <param name="m3SCMU">Manualupdate-salesprices</param>
		/// <param name="m3SCSC">Manualupdaterule</param>
		/// <param name="m3NTCD">Netpriceused</param>
		/// <param name="m3ROPP">Rounding-offcategory</param>
		/// <param name="m3BNCD">Bonusgenerating</param>
		/// <param name="m3PRAC">Commissiongenerating</param>
		/// <param name="m3OBJ1">Field</param>
		/// <param name="m3OBJ2">Field</param>
		/// <param name="m3OBJ3">Field</param>
		/// <param name="m3SCMO">Costingmodel-salesprice</param>
		/// <param name="m3SCAC">Automaticsalespricecalculation</param>
		/// <param name="m3SCBR">Costingbaseroundedoff-salesprice</param>
		/// <param name="m3WSCA">Costingmodel-purchasing</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3BAPL">Basicpricelist</param>
		/// <param name="m3E0CB">Currency</param>
		/// <param name="m3CUN2">Customer</param>
		/// <param name="m3FVD2">Validfrom</param>
		/// <param name="m3PCTP">Costing type</param>
		/// <param name="m31OBJ">Field</param>
		/// <param name="m32OBJ">Field</param>
		/// <param name="m33OBJ">Field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddPriceList(
			string m3PRRF, 
			string m3CUCD, 
			DateTime m3FVDT, 
			DateTime m3LVDT, 
			string m3TX40, 
			int m3CRTP, 
			string m3CUNO = null, 
			string m3TX15 = null, 
			string m3CMNO = null, 
			string m3ACGR = null, 
			int? m3SCMU = null, 
			int? m3SCSC = null, 
			int? m3NTCD = null, 
			int? m3ROPP = null, 
			int? m3BNCD = null, 
			int? m3PRAC = null, 
			string m3OBJ1 = null, 
			string m3OBJ2 = null, 
			string m3OBJ3 = null, 
			string m3SCMO = null, 
			int? m3SCAC = null, 
			int? m3SCBR = null, 
			string m3WSCA = null, 
			string m3WHLO = null, 
			string m3BAPL = null, 
			string m3E0CB = null, 
			string m3CUN2 = null, 
			DateTime? m3FVD2 = null, 
			string m3PCTP = null, 
			string m31OBJ = null, 
			string m32OBJ = null, 
			string m33OBJ = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddPriceList",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRRF))
				throw new ArgumentNullException(nameof(m3PRRF));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3PRRF.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String())
				.WithQueryParameter("LVDT", m3LVDT.ToM3String())
				.WithQueryParameter("TX40", m3TX40.Trim())
				.WithQueryParameter("CRTP", m3CRTP.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3CMNO))
				request.WithQueryParameter("CMNO", m3CMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACGR))
				request.WithQueryParameter("ACGR", m3ACGR.Trim());
			if (m3SCMU.HasValue)
				request.WithQueryParameter("SCMU", m3SCMU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCSC.HasValue)
				request.WithQueryParameter("SCSC", m3SCSC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NTCD.HasValue)
				request.WithQueryParameter("NTCD", m3NTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ROPP.HasValue)
				request.WithQueryParameter("ROPP", m3ROPP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BNCD.HasValue)
				request.WithQueryParameter("BNCD", m3BNCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRAC.HasValue)
				request.WithQueryParameter("PRAC", m3PRAC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OBJ1))
				request.WithQueryParameter("OBJ1", m3OBJ1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBJ2))
				request.WithQueryParameter("OBJ2", m3OBJ2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBJ3))
				request.WithQueryParameter("OBJ3", m3OBJ3.Trim());
			if (!string.IsNullOrWhiteSpace(m3SCMO))
				request.WithQueryParameter("SCMO", m3SCMO.Trim());
			if (m3SCAC.HasValue)
				request.WithQueryParameter("SCAC", m3SCAC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCBR.HasValue)
				request.WithQueryParameter("SCBR", m3SCBR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WSCA))
				request.WithQueryParameter("WSCA", m3WSCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAPL))
				request.WithQueryParameter("BAPL", m3BAPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3E0CB))
				request.WithQueryParameter("E0CB", m3E0CB.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUN2))
				request.WithQueryParameter("CUN2", m3CUN2.Trim());
			if (m3FVD2.HasValue)
				request.WithQueryParameter("FVD2", m3FVD2.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PCTP))
				request.WithQueryParameter("PCTP", m3PCTP.Trim());
			if (!string.IsNullOrWhiteSpace(m31OBJ))
				request.WithQueryParameter("1OBJ", m31OBJ.Trim());
			if (!string.IsNullOrWhiteSpace(m32OBJ))
				request.WithQueryParameter("2OBJ", m32OBJ.Trim());
			if (!string.IsNullOrWhiteSpace(m33OBJ))
				request.WithQueryParameter("3OBJ", m33OBJ.Trim());

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
		/// Name AddScaleKey
		/// Description Add Scale Key
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PRRF">Pricelist (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3FVDT">Validfrom (Required)</param>
		/// <param name="m3MXID">Scale (Required)</param>
		/// <param name="m3CUNO">Customernumber</param>
		/// <param name="m3OBV1">Startvalue1</param>
		/// <param name="m3OBV2">Startvalue2</param>
		/// <param name="m3OBV3">Startvalue3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddScaleKey(
			string m3PRRF, 
			string m3CUCD, 
			DateTime m3FVDT, 
			string m3MXID, 
			string m3CUNO = null, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddScaleKey",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRRF))
				throw new ArgumentNullException(nameof(m3PRRF));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));
			if (string.IsNullOrWhiteSpace(m3MXID))
				throw new ArgumentNullException(nameof(m3MXID));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3PRRF.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String())
				.WithQueryParameter("MXID", m3MXID.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());

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
		/// Name ChgPriceList
		/// Description Update Price List
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PRRF">Pricelist (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3FVDT">Validfrom (Required)</param>
		/// <param name="m3CUNO">Customernumber</param>
		/// <param name="m3LVDT">Validto</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="m3CMNO">Salescampaign</param>
		/// <param name="m3ACGR">Objectaccessgroup</param>
		/// <param name="m3SCMU">Manualupdate-salesprices</param>
		/// <param name="m3SCSC">Manualupdaterule</param>
		/// <param name="m3NTCD">Netpriceused</param>
		/// <param name="m3ROPP">Rounding-offcategory</param>
		/// <param name="m3BNCD">Bonusgenerating</param>
		/// <param name="m3PRAC">Commissiongenerating</param>
		/// <param name="m3SCMO">Costingmodel-salesprice</param>
		/// <param name="m3SCAC">Automaticsalespricecalculation</param>
		/// <param name="m3SCBR">Costingbaseroundedoff-salesprice</param>
		/// <param name="m3CRTP">Exchangeratetype</param>
		/// <param name="m3WSCA">Costingmodel-purchasing</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3BAPL">Basicpricelist</param>
		/// <param name="m3E0CB">Currency</param>
		/// <param name="m3CUN2">Customer</param>
		/// <param name="m3FVD2">Validfrom</param>
		/// <param name="m3PCTP">Costingtype</param>
		/// <param name="m3OBJ1">Field</param>
		/// <param name="m3OBJ2">Field</param>
		/// <param name="m3OBJ3">Field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChgPriceList(
			string m3PRRF, 
			string m3CUCD, 
			DateTime m3FVDT, 
			string m3CUNO = null, 
			DateTime? m3LVDT = null, 
			string m3TX40 = null, 
			string m3TX15 = null, 
			string m3CMNO = null, 
			string m3ACGR = null, 
			int? m3SCMU = null, 
			int? m3SCSC = null, 
			int? m3NTCD = null, 
			int? m3ROPP = null, 
			int? m3BNCD = null, 
			int? m3PRAC = null, 
			string m3SCMO = null, 
			int? m3SCAC = null, 
			int? m3SCBR = null, 
			int? m3CRTP = null, 
			string m3WSCA = null, 
			string m3WHLO = null, 
			string m3BAPL = null, 
			string m3E0CB = null, 
			string m3CUN2 = null, 
			DateTime? m3FVD2 = null, 
			string m3PCTP = null, 
			string m3OBJ1 = null, 
			string m3OBJ2 = null, 
			string m3OBJ3 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChgPriceList",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRRF))
				throw new ArgumentNullException(nameof(m3PRRF));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3PRRF.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (m3LVDT.HasValue)
				request.WithQueryParameter("LVDT", m3LVDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());
			if (!string.IsNullOrWhiteSpace(m3CMNO))
				request.WithQueryParameter("CMNO", m3CMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3ACGR))
				request.WithQueryParameter("ACGR", m3ACGR.Trim());
			if (m3SCMU.HasValue)
				request.WithQueryParameter("SCMU", m3SCMU.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCSC.HasValue)
				request.WithQueryParameter("SCSC", m3SCSC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NTCD.HasValue)
				request.WithQueryParameter("NTCD", m3NTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ROPP.HasValue)
				request.WithQueryParameter("ROPP", m3ROPP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3BNCD.HasValue)
				request.WithQueryParameter("BNCD", m3BNCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PRAC.HasValue)
				request.WithQueryParameter("PRAC", m3PRAC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SCMO))
				request.WithQueryParameter("SCMO", m3SCMO.Trim());
			if (m3SCAC.HasValue)
				request.WithQueryParameter("SCAC", m3SCAC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCBR.HasValue)
				request.WithQueryParameter("SCBR", m3SCBR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CRTP.HasValue)
				request.WithQueryParameter("CRTP", m3CRTP.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3WSCA))
				request.WithQueryParameter("WSCA", m3WSCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAPL))
				request.WithQueryParameter("BAPL", m3BAPL.Trim());
			if (!string.IsNullOrWhiteSpace(m3E0CB))
				request.WithQueryParameter("E0CB", m3E0CB.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUN2))
				request.WithQueryParameter("CUN2", m3CUN2.Trim());
			if (m3FVD2.HasValue)
				request.WithQueryParameter("FVD2", m3FVD2.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3PCTP))
				request.WithQueryParameter("PCTP", m3PCTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBJ1))
				request.WithQueryParameter("OBJ1", m3OBJ1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBJ2))
				request.WithQueryParameter("OBJ2", m3OBJ2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBJ3))
				request.WithQueryParameter("OBJ3", m3OBJ3.Trim());

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
		/// Name DelBasePrice
		/// Description Del Base Price
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PRRF">Pricelist (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3FVDT">Validfrom (Required)</param>
		/// <param name="m3ITNO">Itemnumber (Required)</param>
		/// <param name="m3CUNO">Customernumber</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelBasePrice(
			string m3PRRF, 
			string m3CUCD, 
			DateTime m3FVDT, 
			string m3ITNO, 
			string m3CUNO = null, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelBasePrice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRRF))
				throw new ArgumentNullException(nameof(m3PRRF));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3PRRF.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());

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
		/// Name DelGradSlsPrc
		/// Description Del Grad Sls Prc
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PRRF">Pricelist (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3FVDT">Validfrom (Required)</param>
		/// <param name="m3ITNO">Itemnumber (Required)</param>
		/// <param name="m3QTYL">Lowestquantitylimit (Required)</param>
		/// <param name="m3CUNO">Customernumber</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelGradSlsPrc(
			string m3PRRF, 
			string m3CUCD, 
			DateTime m3FVDT, 
			string m3ITNO, 
			decimal m3QTYL, 
			string m3CUNO = null, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelGradSlsPrc",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRRF))
				throw new ArgumentNullException(nameof(m3PRRF));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3PRRF.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("QTYL", m3QTYL.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());

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
		/// Name DelPriceList
		/// Description Delete Price List
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PRRF">Pricelist (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3FVDT">Validfrom (Required)</param>
		/// <param name="m3CUNO">Customernumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelPriceList(
			string m3PRRF, 
			string m3CUCD, 
			DateTime m3FVDT, 
			string m3CUNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelPriceList",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRRF))
				throw new ArgumentNullException(nameof(m3PRRF));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3PRRF.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());

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
		/// Name DelScaleKey
		/// Description Delete Scale Key
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PRRF">Pricelist (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3FVDT">Validfrom (Required)</param>
		/// <param name="m3CUNO">Customernumber</param>
		/// <param name="m3OBV1">Startvalue1</param>
		/// <param name="m3OBV2">Startvalue2</param>
		/// <param name="m3OBV3">Startvalue3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelScaleKey(
			string m3PRRF, 
			string m3CUCD, 
			DateTime m3FVDT, 
			string m3CUNO = null, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelScaleKey",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRRF))
				throw new ArgumentNullException(nameof(m3PRRF));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3PRRF.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());

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
		/// Name GetBasePrice
		/// Description Get Base Price
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PRRF">Pricelist (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3FVDT">Validfrom (Required)</param>
		/// <param name="m3ITNO">Itemnumber (Required)</param>
		/// <param name="m3CUNO">Customernumber</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetBasePriceResponse></returns>
		/// <exception cref="M3Exception<GetBasePriceResponse>"></exception>
		public async Task<M3Response<GetBasePriceResponse>> GetBasePrice(
			string m3PRRF, 
			string m3CUCD, 
			DateTime m3FVDT, 
			string m3ITNO, 
			string m3CUNO = null, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetBasePrice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRRF))
				throw new ArgumentNullException(nameof(m3PRRF));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3PRRF.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());

			// Execute the request
			var result = await Execute<GetBasePriceResponse>(
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
		/// Name GetPriceList
		/// Description Get Price List
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PRRF">Pricelist (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3FVDT">Validfrom (Required)</param>
		/// <param name="m3CUNO">Customernumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPriceListResponse></returns>
		/// <exception cref="M3Exception<GetPriceListResponse>"></exception>
		public async Task<M3Response<GetPriceListResponse>> GetPriceList(
			string m3PRRF, 
			string m3CUCD, 
			DateTime m3FVDT, 
			string m3CUNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetPriceList",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRRF))
				throw new ArgumentNullException(nameof(m3PRRF));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3PRRF.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Execute the request
			var result = await Execute<GetPriceListResponse>(
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
		/// Name GetScaleKey
		/// Description Get Scale Key
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PRRF">Pricelist (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3FVDT">Validfrom (Required)</param>
		/// <param name="m3CUNO">Customernumber</param>
		/// <param name="m3OBV1">Startvalue1</param>
		/// <param name="m3OBV2">Startvalue2</param>
		/// <param name="m3OBV3">Startvalue3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetScaleKeyResponse></returns>
		/// <exception cref="M3Exception<GetScaleKeyResponse>"></exception>
		public async Task<M3Response<GetScaleKeyResponse>> GetScaleKey(
			string m3PRRF, 
			string m3CUCD, 
			DateTime m3FVDT, 
			string m3CUNO = null, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetScaleKey",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRRF))
				throw new ArgumentNullException(nameof(m3PRRF));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3PRRF.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());

			// Execute the request
			var result = await Execute<GetScaleKeyResponse>(
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
		/// Name LstBasePrice
		/// Description Lst Base Price
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PRRF">Pricelist (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3FVDT">Validfrom (Required)</param>
		/// <param name="m3CUNO">Customernumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstBasePriceResponse></returns>
		/// <exception cref="M3Exception<LstBasePriceResponse>"></exception>
		public async Task<M3Response<LstBasePriceResponse>> LstBasePrice(
			string m3PRRF, 
			string m3CUCD, 
			DateTime m3FVDT, 
			string m3CUNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstBasePrice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRRF))
				throw new ArgumentNullException(nameof(m3PRRF));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3PRRF.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Execute the request
			var result = await Execute<LstBasePriceResponse>(
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
		/// Name LstGradSlsPrc
		/// Description Lst Grad Sls Prc
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PRRF">Pricelist (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3FVDT">Validfrom (Required)</param>
		/// <param name="m3ITNO">Itemnumber (Required)</param>
		/// <param name="m3CUNO">Customernumber</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstGradSlsPrcResponse></returns>
		/// <exception cref="M3Exception<LstGradSlsPrcResponse>"></exception>
		public async Task<M3Response<LstGradSlsPrcResponse>> LstGradSlsPrc(
			string m3PRRF, 
			string m3CUCD, 
			DateTime m3FVDT, 
			string m3ITNO, 
			string m3CUNO = null, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstGradSlsPrc",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRRF))
				throw new ArgumentNullException(nameof(m3PRRF));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3PRRF.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());

			// Execute the request
			var result = await Execute<LstGradSlsPrcResponse>(
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
		/// Name LstPriceList
		/// Description List Price List
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PRRF">Pricelist</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3CUNO">Customer</param>
		/// <param name="m3FVDT">Valid from</param>
		/// <param name="m3NFTR">Number of filters</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPriceListResponse></returns>
		/// <exception cref="M3Exception<LstPriceListResponse>"></exception>
		public async Task<M3Response<LstPriceListResponse>> LstPriceList(
			string m3PRRF = null, 
			string m3CUCD = null, 
			string m3CUNO = null, 
			DateTime? m3FVDT = null, 
			int? m3NFTR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstPriceList",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PRRF))
				request.WithQueryParameter("PRRF", m3PRRF.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (m3FVDT.HasValue)
				request.WithQueryParameter("FVDT", m3FVDT.Value.ToM3String());
			if (m3NFTR.HasValue)
				request.WithQueryParameter("NFTR", m3NFTR.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstPriceListResponse>(
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
		/// Name LstScaleKey
		/// Description List Scale Key
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PRRF">Pricelist (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3FVDT">Validfrom (Required)</param>
		/// <param name="m3CUNO">Customernumber</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstScaleKeyResponse></returns>
		/// <exception cref="M3Exception<LstScaleKeyResponse>"></exception>
		public async Task<M3Response<LstScaleKeyResponse>> LstScaleKey(
			string m3PRRF, 
			string m3CUCD, 
			DateTime m3FVDT, 
			string m3CUNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstScaleKey",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRRF))
				throw new ArgumentNullException(nameof(m3PRRF));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3PRRF.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Execute the request
			var result = await Execute<LstScaleKeyResponse>(
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
		/// Name UpdBasePrice
		/// Description Chg Base Price
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PRRF">Pricelist (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3FVDT">Validfrom (Required)</param>
		/// <param name="m3ITNO">Itemnumber (Required)</param>
		/// <param name="m3CUNO">Customernumber</param>
		/// <param name="m3SAPR">Salesprice</param>
		/// <param name="m3SACD">Salespricequantity</param>
		/// <param name="m3SPUN">Salespriceunitofmeasure</param>
		/// <param name="m3NTCD">Netpriceused</param>
		/// <param name="m3CMNO">Salescampaign</param>
		/// <param name="m3FMID">Formula</param>
		/// <param name="m3RESI">Resultidentity</param>
		/// <param name="m3MXID">Scale</param>
		/// <param name="m3SGGU">Scaleunitofmeasure</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdBasePrice(
			string m3PRRF, 
			string m3CUCD, 
			DateTime m3FVDT, 
			string m3ITNO, 
			string m3CUNO = null, 
			decimal? m3SAPR = null, 
			int? m3SACD = null, 
			string m3SPUN = null, 
			int? m3NTCD = null, 
			string m3CMNO = null, 
			string m3FMID = null, 
			string m3RESI = null, 
			string m3MXID = null, 
			string m3SGGU = null, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdBasePrice",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRRF))
				throw new ArgumentNullException(nameof(m3PRRF));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3PRRF.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String())
				.WithQueryParameter("ITNO", m3ITNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SACD.HasValue)
				request.WithQueryParameter("SACD", m3SACD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SPUN))
				request.WithQueryParameter("SPUN", m3SPUN.Trim());
			if (m3NTCD.HasValue)
				request.WithQueryParameter("NTCD", m3NTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3CMNO))
				request.WithQueryParameter("CMNO", m3CMNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FMID))
				request.WithQueryParameter("FMID", m3FMID.Trim());
			if (!string.IsNullOrWhiteSpace(m3RESI))
				request.WithQueryParameter("RESI", m3RESI.Trim());
			if (!string.IsNullOrWhiteSpace(m3MXID))
				request.WithQueryParameter("MXID", m3MXID.Trim());
			if (!string.IsNullOrWhiteSpace(m3SGGU))
				request.WithQueryParameter("SGGU", m3SGGU.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());

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
		/// Name UpdGradSlsPrc
		/// Description Upd Grad Sls Prc
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PRRF">Pricelist (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3FVDT">Validfrom (Required)</param>
		/// <param name="m3ITNO">Itemnumber (Required)</param>
		/// <param name="m3QTYL">Lowestquantitylimit (Required)</param>
		/// <param name="m3CUNO">Customernumber</param>
		/// <param name="m3PCOF">Priceadjustmentfactor</param>
		/// <param name="m3SAPR">Salesprice</param>
		/// <param name="m3OBV1">Start value 1</param>
		/// <param name="m3OBV2">Start value 2</param>
		/// <param name="m3OBV3">Start value 3</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdGradSlsPrc(
			string m3PRRF, 
			string m3CUCD, 
			DateTime m3FVDT, 
			string m3ITNO, 
			decimal m3QTYL, 
			string m3CUNO = null, 
			decimal? m3PCOF = null, 
			decimal? m3SAPR = null, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdGradSlsPrc",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRRF))
				throw new ArgumentNullException(nameof(m3PRRF));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));
			if (string.IsNullOrWhiteSpace(m3ITNO))
				throw new ArgumentNullException(nameof(m3ITNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3PRRF.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String())
				.WithQueryParameter("ITNO", m3ITNO.Trim())
				.WithQueryParameter("QTYL", m3QTYL.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (m3PCOF.HasValue)
				request.WithQueryParameter("PCOF", m3PCOF.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());

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
		/// Name UpdPriceList
		/// Description Upd Price List
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PRRF">Pricelist (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3FVDT">Validfrom (Required)</param>
		/// <param name="m3PCDT">Costingdate (Required)</param>
		/// <param name="m3FNCH">Functionselection (Required)</param>
		/// <param name="m3CUNO">Customernumber</param>
		/// <param name="m3PROC">Changepct</param>
		/// <param name="m3AMTA">Changeamount</param>
		/// <param name="m3UPIT">Updateitem</param>
		/// <param name="m3FITN">Fromitemnumber</param>
		/// <param name="m3TITN">Toitemnumber</param>
		/// <param name="m3FITG">Fromitemgroup</param>
		/// <param name="m3TITG">Toitemgroup</param>
		/// <param name="m3FITC">Fromproductgroup</param>
		/// <param name="m3TITC">Toproductgroup</param>
		/// <param name="m3FITT">Fromitemtype</param>
		/// <param name="m3TITT">Toitemtype</param>
		/// <param name="m3FRSP">Fromitemresponsible</param>
		/// <param name="m3TRSP">Toitemresponsible</param>
		/// <param name="m3SLFR">Fromstatus</param>
		/// <param name="m3SLTO">Tostatus</param>
		/// <param name="m3FMAB">Frommake/buycode</param>
		/// <param name="m3TMAB">Tomake/buycode</param>
		/// <param name="m3FCHC">Fromconfigurationcode</param>
		/// <param name="m3TCHC">Toconfigurationcode</param>
		/// <param name="m3FSUN">Frommainsupplier</param>
		/// <param name="m3TSUN">Tomainsupplier</param>
		/// <param name="m3FCUN">Fromcustomernumber</param>
		/// <param name="m3TCUN">Tocustomernumber</param>
		/// <param name="m3FBGR">Frombonusgroup</param>
		/// <param name="m3TBGR">Tobonusgroup</param>
		/// <param name="m3FPRC">Fromcommissiongroup</param>
		/// <param name="m3TPRC">Tocommissiongroup</param>
		/// <param name="m3FASS">Fromassortment</param>
		/// <param name="m3TASS">Toassortment</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdPriceList(
			string m3PRRF, 
			string m3CUCD, 
			DateTime m3FVDT, 
			DateTime m3PCDT, 
			int m3FNCH, 
			string m3CUNO = null, 
			int? m3PROC = null, 
			decimal? m3AMTA = null, 
			int? m3UPIT = null, 
			string m3FITN = null, 
			string m3TITN = null, 
			string m3FITG = null, 
			string m3TITG = null, 
			string m3FITC = null, 
			string m3TITC = null, 
			string m3FITT = null, 
			string m3TITT = null, 
			string m3FRSP = null, 
			string m3TRSP = null, 
			string m3SLFR = null, 
			string m3SLTO = null, 
			int? m3FMAB = null, 
			int? m3TMAB = null, 
			int? m3FCHC = null, 
			int? m3TCHC = null, 
			string m3FSUN = null, 
			string m3TSUN = null, 
			string m3FCUN = null, 
			string m3TCUN = null, 
			string m3FBGR = null, 
			string m3TBGR = null, 
			string m3FPRC = null, 
			string m3TPRC = null, 
			string m3FASS = null, 
			string m3TASS = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdPriceList",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRRF))
				throw new ArgumentNullException(nameof(m3PRRF));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3PRRF.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String())
				.WithQueryParameter("PCDT", m3PCDT.ToM3String())
				.WithQueryParameter("FNCH", m3FNCH.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (m3PROC.HasValue)
				request.WithQueryParameter("PROC", m3PROC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AMTA.HasValue)
				request.WithQueryParameter("AMTA", m3AMTA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3UPIT.HasValue)
				request.WithQueryParameter("UPIT", m3UPIT.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FITN))
				request.WithQueryParameter("FITN", m3FITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TITN))
				request.WithQueryParameter("TITN", m3TITN.Trim());
			if (!string.IsNullOrWhiteSpace(m3FITG))
				request.WithQueryParameter("FITG", m3FITG.Trim());
			if (!string.IsNullOrWhiteSpace(m3TITG))
				request.WithQueryParameter("TITG", m3TITG.Trim());
			if (!string.IsNullOrWhiteSpace(m3FITC))
				request.WithQueryParameter("FITC", m3FITC.Trim());
			if (!string.IsNullOrWhiteSpace(m3TITC))
				request.WithQueryParameter("TITC", m3TITC.Trim());
			if (!string.IsNullOrWhiteSpace(m3FITT))
				request.WithQueryParameter("FITT", m3FITT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TITT))
				request.WithQueryParameter("TITT", m3TITT.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRSP))
				request.WithQueryParameter("FRSP", m3FRSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRSP))
				request.WithQueryParameter("TRSP", m3TRSP.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLFR))
				request.WithQueryParameter("SLFR", m3SLFR.Trim());
			if (!string.IsNullOrWhiteSpace(m3SLTO))
				request.WithQueryParameter("SLTO", m3SLTO.Trim());
			if (m3FMAB.HasValue)
				request.WithQueryParameter("FMAB", m3FMAB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TMAB.HasValue)
				request.WithQueryParameter("TMAB", m3TMAB.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FCHC.HasValue)
				request.WithQueryParameter("FCHC", m3FCHC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TCHC.HasValue)
				request.WithQueryParameter("TCHC", m3TCHC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FSUN))
				request.WithQueryParameter("FSUN", m3FSUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TSUN))
				request.WithQueryParameter("TSUN", m3TSUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCUN))
				request.WithQueryParameter("FCUN", m3FCUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TCUN))
				request.WithQueryParameter("TCUN", m3TCUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3FBGR))
				request.WithQueryParameter("FBGR", m3FBGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3TBGR))
				request.WithQueryParameter("TBGR", m3TBGR.Trim());
			if (!string.IsNullOrWhiteSpace(m3FPRC))
				request.WithQueryParameter("FPRC", m3FPRC.Trim());
			if (!string.IsNullOrWhiteSpace(m3TPRC))
				request.WithQueryParameter("TPRC", m3TPRC.Trim());
			if (!string.IsNullOrWhiteSpace(m3FASS))
				request.WithQueryParameter("FASS", m3FASS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TASS))
				request.WithQueryParameter("TASS", m3TASS.Trim());

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
		/// Name UpdScaleKey
		/// Description Update Scale Key
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PRRF">Pricelist (Required)</param>
		/// <param name="m3CUCD">Currency (Required)</param>
		/// <param name="m3FVDT">Validfrom (Required)</param>
		/// <param name="m3CUNO">Customernumber</param>
		/// <param name="m3OBV1">Startvalue1</param>
		/// <param name="m3OBV2">Startvalue2</param>
		/// <param name="m3OBV3">Startvalue3</param>
		/// <param name="m3MXID">Scale</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdScaleKey(
			string m3PRRF, 
			string m3CUCD, 
			DateTime m3FVDT, 
			string m3CUNO = null, 
			string m3OBV1 = null, 
			string m3OBV2 = null, 
			string m3OBV3 = null, 
			string m3MXID = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdScaleKey",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PRRF))
				throw new ArgumentNullException(nameof(m3PRRF));
			if (string.IsNullOrWhiteSpace(m3CUCD))
				throw new ArgumentNullException(nameof(m3CUCD));

			// Set mandatory parameters
			request
				.WithQueryParameter("PRRF", m3PRRF.Trim())
				.WithQueryParameter("CUCD", m3CUCD.Trim())
				.WithQueryParameter("FVDT", m3FVDT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3CUNO))
				request.WithQueryParameter("CUNO", m3CUNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV1))
				request.WithQueryParameter("OBV1", m3OBV1.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV2))
				request.WithQueryParameter("OBV2", m3OBV2.Trim());
			if (!string.IsNullOrWhiteSpace(m3OBV3))
				request.WithQueryParameter("OBV3", m3OBV3.Trim());
			if (!string.IsNullOrWhiteSpace(m3MXID))
				request.WithQueryParameter("MXID", m3MXID.Trim());

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
