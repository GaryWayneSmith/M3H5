/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
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
using System.Globalization;

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
				cancellationToken: cancellationToken)
				.ConfigureAwait(false);

			// Return the response object in it's entirety
			return result;
		}

		/// <summary>
		/// Name LstPriceMargin
		/// Description LstPriceMargin
		/// Version Release: 5e90
		/// </summary>
		/// <param name="m3CUNO">Customer (Required)</param>
		/// <param name="m3ORTP">Customer order type</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3POPN">Alias number</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3ORQA">Ordered quantity - alternate U/M</param>
		/// <param name="m3ALUN">Alternate U/M</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3SPS1">Selected price simulation field 1</param>
		/// <param name="m3FIE1">Margin simulation field 1</param>
		/// <param name="m3SPS2">Selected price simulation field 2</param>
		/// <param name="m3FIE2">Margin simulation field 2</param>
		/// <param name="m3SPS3">Selected price simulation field 3</param>
		/// <param name="m3FIE3">Margin simulation field 3</param>
		/// <param name="m3SPS4">Selected price simulation field 4</param>
		/// <param name="m3FIE4">Margin simulation field 4</param>
		/// <param name="m3SPS5">Selected price simulation field 5</param>
		/// <param name="m3FIE5">Margin simulation field 5</param>
		/// <param name="m3SPS6">Selected price simulation field 6</param>
		/// <param name="m3FIE6">Margin simulation field 6</param>
		/// <param name="m3PRDT">Price date</param>
		/// <param name="m3CUC1">Extra currency</param>
		/// <param name="m3PIDE">Promotion</param>
		/// <param name="m3AGNO">Blanket agreement number</param>
		/// <param name="m3BAGC">Customer - blanket agreement</param>
		/// <param name="m3BAGD">Start date - blanket agreement</param>
		/// <param name="m3CHCT">Superior business chain</param>
		/// <param name="m3CFIN">Configuration number</param>
		/// <param name="m3ATNR">Attribute number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPriceMarginResponse></returns>
		/// <exception cref="M3Exception<LstPriceMarginResponse>"></exception>
		public async Task<M3Response<LstPriceMarginResponse>> LstPriceMargin(
			string m3CUNO, 
			string m3ORTP = null, 
			string m3FACI = null, 
			string m3WHLO = null, 
			string m3POPN = null, 
			string m3ITNO = null, 
			decimal? m3ORQA = null, 
			string m3ALUN = null, 
			string m3CUCD = null, 
			string m3SPS1 = null, 
			string m3FIE1 = null, 
			string m3SPS2 = null, 
			string m3FIE2 = null, 
			string m3SPS3 = null, 
			string m3FIE3 = null, 
			string m3SPS4 = null, 
			string m3FIE4 = null, 
			string m3SPS5 = null, 
			string m3FIE5 = null, 
			string m3SPS6 = null, 
			string m3FIE6 = null, 
			DateTime? m3PRDT = null, 
			string m3CUC1 = null, 
			string m3PIDE = null, 
			string m3AGNO = null, 
			string m3BAGC = null, 
			DateTime? m3BAGD = null, 
			string m3CHCT = null, 
			long? m3CFIN = null, 
			decimal? m3ATNR = null, 
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
			if (string.IsNullOrWhiteSpace(m3CUNO))
				throw new ArgumentNullException(nameof(m3CUNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("CUNO", m3CUNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ORTP))
				request.WithQueryParameter("ORTP", m3ORTP.Trim());
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3POPN))
				request.WithQueryParameter("POPN", m3POPN.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3ORQA.HasValue)
				request.WithQueryParameter("ORQA", m3ORQA.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ALUN))
				request.WithQueryParameter("ALUN", m3ALUN.Trim());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPS1))
				request.WithQueryParameter("SPS1", m3SPS1.Trim());
			if (!string.IsNullOrWhiteSpace(m3FIE1))
				request.WithQueryParameter("FIE1", m3FIE1.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPS2))
				request.WithQueryParameter("SPS2", m3SPS2.Trim());
			if (!string.IsNullOrWhiteSpace(m3FIE2))
				request.WithQueryParameter("FIE2", m3FIE2.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPS3))
				request.WithQueryParameter("SPS3", m3SPS3.Trim());
			if (!string.IsNullOrWhiteSpace(m3FIE3))
				request.WithQueryParameter("FIE3", m3FIE3.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPS4))
				request.WithQueryParameter("SPS4", m3SPS4.Trim());
			if (!string.IsNullOrWhiteSpace(m3FIE4))
				request.WithQueryParameter("FIE4", m3FIE4.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPS5))
				request.WithQueryParameter("SPS5", m3SPS5.Trim());
			if (!string.IsNullOrWhiteSpace(m3FIE5))
				request.WithQueryParameter("FIE5", m3FIE5.Trim());
			if (!string.IsNullOrWhiteSpace(m3SPS6))
				request.WithQueryParameter("SPS6", m3SPS6.Trim());
			if (!string.IsNullOrWhiteSpace(m3FIE6))
				request.WithQueryParameter("FIE6", m3FIE6.Trim());
			if (m3PRDT.HasValue)
				request.WithQueryParameter("PRDT", m3PRDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CUC1))
				request.WithQueryParameter("CUC1", m3CUC1.Trim());
			if (!string.IsNullOrWhiteSpace(m3PIDE))
				request.WithQueryParameter("PIDE", m3PIDE.Trim());
			if (!string.IsNullOrWhiteSpace(m3AGNO))
				request.WithQueryParameter("AGNO", m3AGNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3BAGC))
				request.WithQueryParameter("BAGC", m3BAGC.Trim());
			if (m3BAGD.HasValue)
				request.WithQueryParameter("BAGD", m3BAGD.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CHCT))
				request.WithQueryParameter("CHCT", m3CHCT.Trim());
			if (m3CFIN.HasValue)
				request.WithQueryParameter("CFIN", m3CFIN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ATNR.HasValue)
				request.WithQueryParameter("ATNR", m3ATNR.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstPriceMarginResponse>(
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
