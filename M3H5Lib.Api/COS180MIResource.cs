/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
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
	/// Name: COS180MI
	/// Component Name: MAI
	/// Description: Service Error report
	/// Version Release: 5ea0
	///</summary>
	public partial class COS180MIResource : M3BaseResourceEndpoint
	{
		public COS180MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "COS180MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name CreateInvoice
		/// Description CreateInvoice
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3IDAT">Invoice date (Required)</param>
		/// <param name="m3ACDT">Accounting date (Required)</param>
		/// <param name="m3PICD">Advance invoicing code (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3ADI2">Reconciliation invoice</param>
		/// <param name="m3AZIN">Close meter based lines</param>
		/// <param name="m3PAIC">Summary invoicing code</param>
		/// <param name="m3INVR">Invoice round</param>
		/// <param name="m3CPPL">Copy</param>
		/// <param name="m3FFACI">Facility from</param>
		/// <param name="m3TFACI">Facility to</param>
		/// <param name="m3FRESP">Responsible from</param>
		/// <param name="m3TRESP">Responsible to</param>
		/// <param name="m3FPYNO">Payer from</param>
		/// <param name="m3TPYNO">Payer to</param>
		/// <param name="m3FORNO">Customer order number from</param>
		/// <param name="m3FPONR">Order line number from</param>
		/// <param name="m3TORNO">Customer order number to</param>
		/// <param name="m3TPONR">Order line number to</param>
		/// <param name="m3FAAGN">Agreement from</param>
		/// <param name="m3TAAGN">Agreement to</param>
		/// <param name="m3FAPRS">Project from</param>
		/// <param name="m3TAPRS">Project to</param>
		/// <param name="m3FCSCD">Country from</param>
		/// <param name="m3TCSCD">Country to</param>
		/// <param name="m3FOPRI">Priority from</param>
		/// <param name="m3TOPRI">Priority to</param>
		/// <param name="m3FSRVP">Service price method from</param>
		/// <param name="m3TSRVP">Service price method to</param>
		/// <param name="m3FCYP6">Period from</param>
		/// <param name="m3TCYP6">Period to</param>
		/// <param name="m3FAOST">Highest status from</param>
		/// <param name="m3TAOST">Highest status to</param>
		/// <param name="m3CNPE">Contact person</param>
		/// <param name="m3EMAL">Electronic mail address</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CreateInvoice(
			DateTime m3IDAT, 
			DateTime m3ACDT, 
			int m3PICD, 
			string m3DIVI = null, 
			int? m3ADI2 = null, 
			int? m3AZIN = null, 
			int? m3PAIC = null, 
			decimal? m3INVR = null, 
			int? m3CPPL = null, 
			string m3FFACI = null, 
			string m3TFACI = null, 
			string m3FRESP = null, 
			string m3TRESP = null, 
			string m3FPYNO = null, 
			string m3TPYNO = null, 
			string m3FORNO = null, 
			int? m3FPONR = null, 
			string m3TORNO = null, 
			int? m3TPONR = null, 
			string m3FAAGN = null, 
			string m3TAAGN = null, 
			string m3FAPRS = null, 
			string m3TAPRS = null, 
			string m3FCSCD = null, 
			string m3TCSCD = null, 
			int? m3FOPRI = null, 
			int? m3TOPRI = null, 
			int? m3FSRVP = null, 
			int? m3TSRVP = null, 
			int? m3FCYP6 = null, 
			int? m3TCYP6 = null, 
			string m3FAOST = null, 
			string m3TAOST = null, 
			string m3CNPE = null, 
			string m3EMAL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/CreateInvoice",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("IDAT", m3IDAT.ToM3String())
				.WithQueryParameter("ACDT", m3ACDT.ToM3String())
				.WithQueryParameter("PICD", m3PICD.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3ADI2.HasValue)
				request.WithQueryParameter("ADI2", m3ADI2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AZIN.HasValue)
				request.WithQueryParameter("AZIN", m3AZIN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PAIC.HasValue)
				request.WithQueryParameter("PAIC", m3PAIC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INVR.HasValue)
				request.WithQueryParameter("INVR", m3INVR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CPPL.HasValue)
				request.WithQueryParameter("CPPL", m3CPPL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FFACI))
				request.WithQueryParameter("FFACI", m3FFACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFACI))
				request.WithQueryParameter("TFACI", m3TFACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRESP))
				request.WithQueryParameter("FRESP", m3FRESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRESP))
				request.WithQueryParameter("TRESP", m3TRESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3FPYNO))
				request.WithQueryParameter("FPYNO", m3FPYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TPYNO))
				request.WithQueryParameter("TPYNO", m3TPYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FORNO))
				request.WithQueryParameter("FORNO", m3FORNO.Trim());
			if (m3FPONR.HasValue)
				request.WithQueryParameter("FPONR", m3FPONR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TORNO))
				request.WithQueryParameter("TORNO", m3TORNO.Trim());
			if (m3TPONR.HasValue)
				request.WithQueryParameter("TPONR", m3TPONR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FAAGN))
				request.WithQueryParameter("FAAGN", m3FAAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAAGN))
				request.WithQueryParameter("TAAGN", m3TAAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3FAPRS))
				request.WithQueryParameter("FAPRS", m3FAPRS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAPRS))
				request.WithQueryParameter("TAPRS", m3TAPRS.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCSCD))
				request.WithQueryParameter("FCSCD", m3FCSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3TCSCD))
				request.WithQueryParameter("TCSCD", m3TCSCD.Trim());
			if (m3FOPRI.HasValue)
				request.WithQueryParameter("FOPRI", m3FOPRI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TOPRI.HasValue)
				request.WithQueryParameter("TOPRI", m3TOPRI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FSRVP.HasValue)
				request.WithQueryParameter("FSRVP", m3FSRVP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TSRVP.HasValue)
				request.WithQueryParameter("TSRVP", m3TSRVP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FCYP6.HasValue)
				request.WithQueryParameter("FCYP6", m3FCYP6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TCYP6.HasValue)
				request.WithQueryParameter("TCYP6", m3TCYP6.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FAOST))
				request.WithQueryParameter("FAOST", m3FAOST.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAOST))
				request.WithQueryParameter("TAOST", m3TAOST.Trim());
			if (!string.IsNullOrWhiteSpace(m3CNPE))
				request.WithQueryParameter("CNPE", m3CNPE.Trim());
			if (!string.IsNullOrWhiteSpace(m3EMAL))
				request.WithQueryParameter("EMAL", m3EMAL.Trim());

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
		/// Name InvoiceProp
		/// Description InvoiceProp
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3IDAT">Invoice date (Required)</param>
		/// <param name="m3ACDT">Accounting date (Required)</param>
		/// <param name="m3PICD">Advance invoicing code (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3ADI2">Reconciliation invoice</param>
		/// <param name="m3AZIN">Close meter based lines</param>
		/// <param name="m3PAIC">Summary invoicing code</param>
		/// <param name="m3INVR">Invoice round</param>
		/// <param name="m3FFACI">Facility from</param>
		/// <param name="m3TFACI">Facility to</param>
		/// <param name="m3FRESP">Responsible from</param>
		/// <param name="m3TRESP">Responsible to</param>
		/// <param name="m3FPYNO">Payer from</param>
		/// <param name="m3TPYNO">Payer to</param>
		/// <param name="m3FORNO">Customer order number from</param>
		/// <param name="m3FPONR">Order line number from</param>
		/// <param name="m3TORNO">Customer order number to</param>
		/// <param name="m3TPONR">Order line number to</param>
		/// <param name="m3FAAGN">Agreement from</param>
		/// <param name="m3TAAGN">Agreement to</param>
		/// <param name="m3FAPRS">Project from</param>
		/// <param name="m3TAPRS">Project to</param>
		/// <param name="m3FCSCD">Country from</param>
		/// <param name="m3TCSCD">Country to</param>
		/// <param name="m3FOPRI">Priority from</param>
		/// <param name="m3TOPRI">Priority to</param>
		/// <param name="m3FSRVP">Service price method from</param>
		/// <param name="m3TSRVP">Service price method to</param>
		/// <param name="m3FCYP6">Period from</param>
		/// <param name="m3TCYP6">Period to</param>
		/// <param name="m3FAOST">Highest status from</param>
		/// <param name="m3TAOST">Highest status to</param>
		/// <param name="m3CNPE">Contact person</param>
		/// <param name="m3EMAL">Electronic mail address</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> InvoiceProp(
			DateTime m3IDAT, 
			DateTime m3ACDT, 
			int m3PICD, 
			string m3DIVI = null, 
			int? m3ADI2 = null, 
			int? m3AZIN = null, 
			int? m3PAIC = null, 
			decimal? m3INVR = null, 
			string m3FFACI = null, 
			string m3TFACI = null, 
			string m3FRESP = null, 
			string m3TRESP = null, 
			string m3FPYNO = null, 
			string m3TPYNO = null, 
			string m3FORNO = null, 
			int? m3FPONR = null, 
			string m3TORNO = null, 
			int? m3TPONR = null, 
			string m3FAAGN = null, 
			string m3TAAGN = null, 
			string m3FAPRS = null, 
			string m3TAPRS = null, 
			string m3FCSCD = null, 
			string m3TCSCD = null, 
			int? m3FOPRI = null, 
			int? m3TOPRI = null, 
			int? m3FSRVP = null, 
			int? m3TSRVP = null, 
			int? m3FCYP6 = null, 
			int? m3TCYP6 = null, 
			string m3FAOST = null, 
			string m3TAOST = null, 
			string m3CNPE = null, 
			string m3EMAL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/InvoiceProp",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("IDAT", m3IDAT.ToM3String())
				.WithQueryParameter("ACDT", m3ACDT.ToM3String())
				.WithQueryParameter("PICD", m3PICD.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3ADI2.HasValue)
				request.WithQueryParameter("ADI2", m3ADI2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AZIN.HasValue)
				request.WithQueryParameter("AZIN", m3AZIN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PAIC.HasValue)
				request.WithQueryParameter("PAIC", m3PAIC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INVR.HasValue)
				request.WithQueryParameter("INVR", m3INVR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FFACI))
				request.WithQueryParameter("FFACI", m3FFACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFACI))
				request.WithQueryParameter("TFACI", m3TFACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRESP))
				request.WithQueryParameter("FRESP", m3FRESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRESP))
				request.WithQueryParameter("TRESP", m3TRESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3FPYNO))
				request.WithQueryParameter("FPYNO", m3FPYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TPYNO))
				request.WithQueryParameter("TPYNO", m3TPYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FORNO))
				request.WithQueryParameter("FORNO", m3FORNO.Trim());
			if (m3FPONR.HasValue)
				request.WithQueryParameter("FPONR", m3FPONR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TORNO))
				request.WithQueryParameter("TORNO", m3TORNO.Trim());
			if (m3TPONR.HasValue)
				request.WithQueryParameter("TPONR", m3TPONR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FAAGN))
				request.WithQueryParameter("FAAGN", m3FAAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAAGN))
				request.WithQueryParameter("TAAGN", m3TAAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3FAPRS))
				request.WithQueryParameter("FAPRS", m3FAPRS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAPRS))
				request.WithQueryParameter("TAPRS", m3TAPRS.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCSCD))
				request.WithQueryParameter("FCSCD", m3FCSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3TCSCD))
				request.WithQueryParameter("TCSCD", m3TCSCD.Trim());
			if (m3FOPRI.HasValue)
				request.WithQueryParameter("FOPRI", m3FOPRI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TOPRI.HasValue)
				request.WithQueryParameter("TOPRI", m3TOPRI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FSRVP.HasValue)
				request.WithQueryParameter("FSRVP", m3FSRVP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TSRVP.HasValue)
				request.WithQueryParameter("TSRVP", m3TSRVP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FCYP6.HasValue)
				request.WithQueryParameter("FCYP6", m3FCYP6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TCYP6.HasValue)
				request.WithQueryParameter("TCYP6", m3TCYP6.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FAOST))
				request.WithQueryParameter("FAOST", m3FAOST.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAOST))
				request.WithQueryParameter("TAOST", m3TAOST.Trim());
			if (!string.IsNullOrWhiteSpace(m3CNPE))
				request.WithQueryParameter("CNPE", m3CNPE.Trim());
			if (!string.IsNullOrWhiteSpace(m3EMAL))
				request.WithQueryParameter("EMAL", m3EMAL.Trim());

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
		/// Name PrintQuotation
		/// Description InvoiceProp
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3IDAT">Invoice date (Required)</param>
		/// <param name="m3ACDT">Accounting date (Required)</param>
		/// <param name="m3PICD">Advance invoicing code (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3ADI2">Reconciliation invoice</param>
		/// <param name="m3AZIN">Close meter based lines</param>
		/// <param name="m3PAIC">Summary invoicing code</param>
		/// <param name="m3INVR">Invoice round</param>
		/// <param name="m3AQUO">Quotation</param>
		/// <param name="m3FFACI">Facility from</param>
		/// <param name="m3TFACI">Facility to</param>
		/// <param name="m3FRESP">Responsible from</param>
		/// <param name="m3TRESP">Responsible to</param>
		/// <param name="m3FPYNO">Payer from</param>
		/// <param name="m3TPYNO">Payer to</param>
		/// <param name="m3FORNO">Customer order number from</param>
		/// <param name="m3FPONR">Order line number from</param>
		/// <param name="m3TORNO">Customer order number to</param>
		/// <param name="m3TPONR">Order line number to</param>
		/// <param name="m3FAAGN">Agreement from</param>
		/// <param name="m3TAAGN">Agreement to</param>
		/// <param name="m3FAPRS">Project from</param>
		/// <param name="m3TAPRS">Project to</param>
		/// <param name="m3FCSCD">Country from</param>
		/// <param name="m3TCSCD">Country to</param>
		/// <param name="m3FOPRI">Priority from</param>
		/// <param name="m3TOPRI">Priority to</param>
		/// <param name="m3FSRVP">Service price method from</param>
		/// <param name="m3TSRVP">Service price method to</param>
		/// <param name="m3FCYP6">Period from</param>
		/// <param name="m3TCYP6">Period to</param>
		/// <param name="m3FAOST">Highest status from</param>
		/// <param name="m3TAOST">Highest status to</param>
		/// <param name="m3CNPE">Contact person</param>
		/// <param name="m3EMAL">Electronic mail address</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrintQuotation(
			DateTime m3IDAT, 
			DateTime m3ACDT, 
			int m3PICD, 
			string m3DIVI = null, 
			int? m3ADI2 = null, 
			int? m3AZIN = null, 
			int? m3PAIC = null, 
			decimal? m3INVR = null, 
			int? m3AQUO = null, 
			string m3FFACI = null, 
			string m3TFACI = null, 
			string m3FRESP = null, 
			string m3TRESP = null, 
			string m3FPYNO = null, 
			string m3TPYNO = null, 
			string m3FORNO = null, 
			int? m3FPONR = null, 
			string m3TORNO = null, 
			int? m3TPONR = null, 
			string m3FAAGN = null, 
			string m3TAAGN = null, 
			string m3FAPRS = null, 
			string m3TAPRS = null, 
			string m3FCSCD = null, 
			string m3TCSCD = null, 
			int? m3FOPRI = null, 
			int? m3TOPRI = null, 
			int? m3FSRVP = null, 
			int? m3TSRVP = null, 
			int? m3FCYP6 = null, 
			int? m3TCYP6 = null, 
			string m3FAOST = null, 
			string m3TAOST = null, 
			string m3CNPE = null, 
			string m3EMAL = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/PrintQuotation",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("IDAT", m3IDAT.ToM3String())
				.WithQueryParameter("ACDT", m3ACDT.ToM3String())
				.WithQueryParameter("PICD", m3PICD.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3ADI2.HasValue)
				request.WithQueryParameter("ADI2", m3ADI2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AZIN.HasValue)
				request.WithQueryParameter("AZIN", m3AZIN.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PAIC.HasValue)
				request.WithQueryParameter("PAIC", m3PAIC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3INVR.HasValue)
				request.WithQueryParameter("INVR", m3INVR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AQUO.HasValue)
				request.WithQueryParameter("AQUO", m3AQUO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FFACI))
				request.WithQueryParameter("FFACI", m3FFACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3TFACI))
				request.WithQueryParameter("TFACI", m3TFACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3FRESP))
				request.WithQueryParameter("FRESP", m3FRESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3TRESP))
				request.WithQueryParameter("TRESP", m3TRESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3FPYNO))
				request.WithQueryParameter("FPYNO", m3FPYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3TPYNO))
				request.WithQueryParameter("TPYNO", m3TPYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3FORNO))
				request.WithQueryParameter("FORNO", m3FORNO.Trim());
			if (m3FPONR.HasValue)
				request.WithQueryParameter("FPONR", m3FPONR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TORNO))
				request.WithQueryParameter("TORNO", m3TORNO.Trim());
			if (m3TPONR.HasValue)
				request.WithQueryParameter("TPONR", m3TPONR.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FAAGN))
				request.WithQueryParameter("FAAGN", m3FAAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAAGN))
				request.WithQueryParameter("TAAGN", m3TAAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3FAPRS))
				request.WithQueryParameter("FAPRS", m3FAPRS.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAPRS))
				request.WithQueryParameter("TAPRS", m3TAPRS.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCSCD))
				request.WithQueryParameter("FCSCD", m3FCSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3TCSCD))
				request.WithQueryParameter("TCSCD", m3TCSCD.Trim());
			if (m3FOPRI.HasValue)
				request.WithQueryParameter("FOPRI", m3FOPRI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TOPRI.HasValue)
				request.WithQueryParameter("TOPRI", m3TOPRI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FSRVP.HasValue)
				request.WithQueryParameter("FSRVP", m3FSRVP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TSRVP.HasValue)
				request.WithQueryParameter("TSRVP", m3TSRVP.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FCYP6.HasValue)
				request.WithQueryParameter("FCYP6", m3FCYP6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TCYP6.HasValue)
				request.WithQueryParameter("TCYP6", m3TCYP6.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FAOST))
				request.WithQueryParameter("FAOST", m3FAOST.Trim());
			if (!string.IsNullOrWhiteSpace(m3TAOST))
				request.WithQueryParameter("TAOST", m3TAOST.Trim());
			if (!string.IsNullOrWhiteSpace(m3CNPE))
				request.WithQueryParameter("CNPE", m3CNPE.Trim());
			if (!string.IsNullOrWhiteSpace(m3EMAL))
				request.WithQueryParameter("EMAL", m3EMAL.Trim());

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
