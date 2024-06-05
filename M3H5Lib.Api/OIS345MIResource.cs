/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.OIS345MI;
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
	/// Name: OIS345MI
	/// Component Name: OIS860
	/// Description: Price Margin. Simulate CO Line
	/// Version Release: 5e90
	///</summary>
	public partial class OIS345MIResource : M3BaseResourceEndpoint
	{
		public OIS345MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "OIS345MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name GetSelSimFields
		/// Description GetSelSimFields
		/// Version Release: 5e90
		/// </summary>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSelSimFieldsResponse></returns>
		/// <exception cref="M3Exception<GetSelSimFieldsResponse>"></exception>
		public async Task<M3Response<GetSelSimFieldsResponse>> GetSelSimFields(
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/GetSelSimFields",
			};

			// Execute the request
			var result = await Execute<GetSelSimFieldsResponse>(
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
		/// Name LstPriceMargin
		/// Description LstPriceMargin
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3_CUNO">Customer (Required)</param>
		/// <param name="m3_ORTP">Customer order type</param>
		/// <param name="m3_FACI">Facility</param>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_POPN">Alias number</param>
		/// <param name="m3_ITNO">Item number</param>
		/// <param name="m3_ORQA">Ordered quantity - alternate U/M</param>
		/// <param name="m3_ALUN">Alternate U/M</param>
		/// <param name="m3_CUCD">Currency</param>
		/// <param name="m3_SPS1">Selected price simulation field 1</param>
		/// <param name="m3_FIE1">Margin simulation field 1</param>
		/// <param name="m3_SPS2">Selected price simulation field 2</param>
		/// <param name="m3_FIE2">Margin simulation field 2</param>
		/// <param name="m3_SPS3">Selected price simulation field 3</param>
		/// <param name="m3_FIE3">Margin simulation field 3</param>
		/// <param name="m3_SPS4">Selected price simulation field 4</param>
		/// <param name="m3_FIE4">Margin simulation field 4</param>
		/// <param name="m3_SPS5">Selected price simulation field 5</param>
		/// <param name="m3_FIE5">Margin simulation field 5</param>
		/// <param name="m3_SPS6">Selected price simulation field 6</param>
		/// <param name="m3_FIE6">Margin simulation field 6</param>
		/// <param name="m3_PRDT">Price date</param>
		/// <param name="m3_CUC1">Extra currency</param>
		/// <param name="m3_PIDE">Promotion</param>
		/// <param name="m3_AGNO">Blanket agreement number</param>
		/// <param name="m3_BAGC">Customer - blanket agreement</param>
		/// <param name="m3_BAGD">Start date - blanket agreement</param>
		/// <param name="m3_CHCT">Superior business chain</param>
		/// <param name="m3_CFIN">Configuration number</param>
		/// <param name="m3_ATNR">Attribute number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPriceMarginResponse></returns>
		/// <exception cref="M3Exception<LstPriceMarginResponse>"></exception>
		public async Task<M3Response<LstPriceMarginResponse>> LstPriceMargin(
			string m3_CUNO, 
			string m3_ORTP = null, 
			string m3_FACI = null, 
			string m3_WHLO = null, 
			string m3_POPN = null, 
			string m3_ITNO = null, 
			decimal? m3_ORQA = null, 
			string m3_ALUN = null, 
			string m3_CUCD = null, 
			string m3_SPS1 = null, 
			string m3_FIE1 = null, 
			string m3_SPS2 = null, 
			string m3_FIE2 = null, 
			string m3_SPS3 = null, 
			string m3_FIE3 = null, 
			string m3_SPS4 = null, 
			string m3_FIE4 = null, 
			string m3_SPS5 = null, 
			string m3_FIE5 = null, 
			string m3_SPS6 = null, 
			string m3_FIE6 = null, 
			DateTime? m3_PRDT = null, 
			string m3_CUC1 = null, 
			string m3_PIDE = null, 
			string m3_AGNO = null, 
			string m3_BAGC = null, 
			DateTime? m3_BAGD = null, 
			string m3_CHCT = null, 
			long? m3_CFIN = null, 
			decimal? m3_ATNR = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPriceMargin",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_CUNO))
				throw new ArgumentNullException("m3_CUNO");

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3_CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_ORTP))
				request.WithQueryParameter("ORTP", m3_ORTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FACI))
				request.WithQueryParameter("FACI", m3_FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_POPN))
				request.WithQueryParameter("POPN", m3_POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_ITNO))
				request.WithQueryParameter("ITNO", m3_ITNO.Trim());
			if (m3_ORQA.HasValue)
				request.WithQueryParameter("ORQA", m3_ORQA.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_ALUN))
				request.WithQueryParameter("ALUN", m3_ALUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CUCD))
				request.WithQueryParameter("CUCD", m3_CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPS1))
				request.WithQueryParameter("SPS1", m3_SPS1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FIE1))
				request.WithQueryParameter("FIE1", m3_FIE1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPS2))
				request.WithQueryParameter("SPS2", m3_SPS2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FIE2))
				request.WithQueryParameter("FIE2", m3_FIE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPS3))
				request.WithQueryParameter("SPS3", m3_SPS3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FIE3))
				request.WithQueryParameter("FIE3", m3_FIE3.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPS4))
				request.WithQueryParameter("SPS4", m3_SPS4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FIE4))
				request.WithQueryParameter("FIE4", m3_FIE4.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPS5))
				request.WithQueryParameter("SPS5", m3_SPS5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FIE5))
				request.WithQueryParameter("FIE5", m3_FIE5.Trim());
			if (!string.IsNullOrWhiteSpace(m3_SPS6))
				request.WithQueryParameter("SPS6", m3_SPS6.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FIE6))
				request.WithQueryParameter("FIE6", m3_FIE6.Trim());
			if (m3_PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3_PRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CUC1))
				request.WithQueryParameter("CUC1", m3_CUC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3_PIDE))
				request.WithQueryParameter("PIDE", m3_PIDE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_AGNO))
				request.WithQueryParameter("AGNO", m3_AGNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_BAGC))
				request.WithQueryParameter("BAGC", m3_BAGC.Trim());
			if (m3_BAGD.HasValue)
				request.WithQueryParameter("BAGD", m3_BAGD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3_CHCT))
				request.WithQueryParameter("CHCT", m3_CHCT.Trim());
			if (m3_CFIN.HasValue)
				request.WithQueryParameter("CFIN", m3_CFIN.Value.ToString());
			if (m3_ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3_ATNR.Value.ToString());

			// Execute the request
			var result = await Execute<LstPriceMarginResponse>(
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
