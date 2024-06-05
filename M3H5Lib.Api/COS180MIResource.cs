/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_IDAT">Invoice date (Required)</param>
		/// <param name="m3_ACDT">Accounting date (Required)</param>
		/// <param name="m3_PICD">Advance invoicing code (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_ADI2">Reconciliation invoice</param>
		/// <param name="m3_AZIN">Close meter based lines</param>
		/// <param name="m3_PAIC">Summary invoicing code</param>
		/// <param name="m3_INVR">Invoice round</param>
		/// <param name="m3_CPPL">Copy</param>
		/// <param name="m3_FFACI">Facility from</param>
		/// <param name="m3_TFACI">Facility to</param>
		/// <param name="m3_FRESP">Responsible from</param>
		/// <param name="m3_TRESP">Responsible to</param>
		/// <param name="m3_FPYNO">Payer from</param>
		/// <param name="m3_TPYNO">Payer to</param>
		/// <param name="m3_FORNO">Customer order number from</param>
		/// <param name="m3_FPONR">Order line number from</param>
		/// <param name="m3_TORNO">Customer order number to</param>
		/// <param name="m3_TPONR">Order line number to</param>
		/// <param name="m3_FAAGN">Agreement from</param>
		/// <param name="m3_TAAGN">Agreement to</param>
		/// <param name="m3_FAPRS">Project from</param>
		/// <param name="m3_TAPRS">Project to</param>
		/// <param name="m3_FCSCD">Country from</param>
		/// <param name="m3_TCSCD">Country to</param>
		/// <param name="m3_FOPRI">Priority from</param>
		/// <param name="m3_TOPRI">Priority to</param>
		/// <param name="m3_FSRVP">Service price method from</param>
		/// <param name="m3_TSRVP">Service price method to</param>
		/// <param name="m3_FCYP6">Period from</param>
		/// <param name="m3_TCYP6">Period to</param>
		/// <param name="m3_FAOST">Highest status from</param>
		/// <param name="m3_TAOST">Highest status to</param>
		/// <param name="m3_CNPE">Contact person</param>
		/// <param name="m3_EMAL">Electronic mail address</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CreateInvoice(
			DateTime m3_IDAT, 
			DateTime m3_ACDT, 
			int m3_PICD, 
			string m3_DIVI = null, 
			int? m3_ADI2 = null, 
			int? m3_AZIN = null, 
			int? m3_PAIC = null, 
			decimal? m3_INVR = null, 
			int? m3_CPPL = null, 
			string m3_FFACI = null, 
			string m3_TFACI = null, 
			string m3_FRESP = null, 
			string m3_TRESP = null, 
			string m3_FPYNO = null, 
			string m3_TPYNO = null, 
			string m3_FORNO = null, 
			int? m3_FPONR = null, 
			string m3_TORNO = null, 
			int? m3_TPONR = null, 
			string m3_FAAGN = null, 
			string m3_TAAGN = null, 
			string m3_FAPRS = null, 
			string m3_TAPRS = null, 
			string m3_FCSCD = null, 
			string m3_TCSCD = null, 
			int? m3_FOPRI = null, 
			int? m3_TOPRI = null, 
			int? m3_FSRVP = null, 
			int? m3_TSRVP = null, 
			int? m3_FCYP6 = null, 
			int? m3_TCYP6 = null, 
			string m3_FAOST = null, 
			string m3_TAOST = null, 
			string m3_CNPE = null, 
			string m3_EMAL = null, 
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
				.WithQueryParameter("IDAT", m3_IDAT.ToM3String())
				.WithQueryParameter("ACDT", m3_ACDT.ToM3String())
				.WithQueryParameter("PICD", m3_PICD.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_ADI2.HasValue)
				request.WithQueryParameter("ADI2", m3_ADI2.Value.ToString());
			if (m3_AZIN.HasValue)
				request.WithQueryParameter("AZIN", m3_AZIN.Value.ToString());
			if (m3_PAIC.HasValue)
				request.WithQueryParameter("PAIC", m3_PAIC.Value.ToString());
			if (m3_INVR.HasValue)
				request.WithQueryParameter("INVR", m3_INVR.Value.ToString());
			if (m3_CPPL.HasValue)
				request.WithQueryParameter("CPPL", m3_CPPL.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FFACI))
				request.WithQueryParameter("FFACI", m3_FFACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFACI))
				request.WithQueryParameter("TFACI", m3_TFACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRESP))
				request.WithQueryParameter("FRESP", m3_FRESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRESP))
				request.WithQueryParameter("TRESP", m3_TRESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FPYNO))
				request.WithQueryParameter("FPYNO", m3_FPYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TPYNO))
				request.WithQueryParameter("TPYNO", m3_TPYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FORNO))
				request.WithQueryParameter("FORNO", m3_FORNO.Trim());
			if (m3_FPONR.HasValue)
				request.WithQueryParameter("FPONR", m3_FPONR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TORNO))
				request.WithQueryParameter("TORNO", m3_TORNO.Trim());
			if (m3_TPONR.HasValue)
				request.WithQueryParameter("TPONR", m3_TPONR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FAAGN))
				request.WithQueryParameter("FAAGN", m3_FAAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAAGN))
				request.WithQueryParameter("TAAGN", m3_TAAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FAPRS))
				request.WithQueryParameter("FAPRS", m3_FAPRS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAPRS))
				request.WithQueryParameter("TAPRS", m3_TAPRS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCSCD))
				request.WithQueryParameter("FCSCD", m3_FCSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TCSCD))
				request.WithQueryParameter("TCSCD", m3_TCSCD.Trim());
			if (m3_FOPRI.HasValue)
				request.WithQueryParameter("FOPRI", m3_FOPRI.Value.ToString());
			if (m3_TOPRI.HasValue)
				request.WithQueryParameter("TOPRI", m3_TOPRI.Value.ToString());
			if (m3_FSRVP.HasValue)
				request.WithQueryParameter("FSRVP", m3_FSRVP.Value.ToString());
			if (m3_TSRVP.HasValue)
				request.WithQueryParameter("TSRVP", m3_TSRVP.Value.ToString());
			if (m3_FCYP6.HasValue)
				request.WithQueryParameter("FCYP6", m3_FCYP6.Value.ToString());
			if (m3_TCYP6.HasValue)
				request.WithQueryParameter("TCYP6", m3_TCYP6.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FAOST))
				request.WithQueryParameter("FAOST", m3_FAOST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAOST))
				request.WithQueryParameter("TAOST", m3_TAOST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CNPE))
				request.WithQueryParameter("CNPE", m3_CNPE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EMAL))
				request.WithQueryParameter("EMAL", m3_EMAL.Trim());

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
		/// Name InvoiceProp
		/// Description InvoiceProp
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_IDAT">Invoice date (Required)</param>
		/// <param name="m3_ACDT">Accounting date (Required)</param>
		/// <param name="m3_PICD">Advance invoicing code (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_ADI2">Reconciliation invoice</param>
		/// <param name="m3_AZIN">Close meter based lines</param>
		/// <param name="m3_PAIC">Summary invoicing code</param>
		/// <param name="m3_INVR">Invoice round</param>
		/// <param name="m3_FFACI">Facility from</param>
		/// <param name="m3_TFACI">Facility to</param>
		/// <param name="m3_FRESP">Responsible from</param>
		/// <param name="m3_TRESP">Responsible to</param>
		/// <param name="m3_FPYNO">Payer from</param>
		/// <param name="m3_TPYNO">Payer to</param>
		/// <param name="m3_FORNO">Customer order number from</param>
		/// <param name="m3_FPONR">Order line number from</param>
		/// <param name="m3_TORNO">Customer order number to</param>
		/// <param name="m3_TPONR">Order line number to</param>
		/// <param name="m3_FAAGN">Agreement from</param>
		/// <param name="m3_TAAGN">Agreement to</param>
		/// <param name="m3_FAPRS">Project from</param>
		/// <param name="m3_TAPRS">Project to</param>
		/// <param name="m3_FCSCD">Country from</param>
		/// <param name="m3_TCSCD">Country to</param>
		/// <param name="m3_FOPRI">Priority from</param>
		/// <param name="m3_TOPRI">Priority to</param>
		/// <param name="m3_FSRVP">Service price method from</param>
		/// <param name="m3_TSRVP">Service price method to</param>
		/// <param name="m3_FCYP6">Period from</param>
		/// <param name="m3_TCYP6">Period to</param>
		/// <param name="m3_FAOST">Highest status from</param>
		/// <param name="m3_TAOST">Highest status to</param>
		/// <param name="m3_CNPE">Contact person</param>
		/// <param name="m3_EMAL">Electronic mail address</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> InvoiceProp(
			DateTime m3_IDAT, 
			DateTime m3_ACDT, 
			int m3_PICD, 
			string m3_DIVI = null, 
			int? m3_ADI2 = null, 
			int? m3_AZIN = null, 
			int? m3_PAIC = null, 
			decimal? m3_INVR = null, 
			string m3_FFACI = null, 
			string m3_TFACI = null, 
			string m3_FRESP = null, 
			string m3_TRESP = null, 
			string m3_FPYNO = null, 
			string m3_TPYNO = null, 
			string m3_FORNO = null, 
			int? m3_FPONR = null, 
			string m3_TORNO = null, 
			int? m3_TPONR = null, 
			string m3_FAAGN = null, 
			string m3_TAAGN = null, 
			string m3_FAPRS = null, 
			string m3_TAPRS = null, 
			string m3_FCSCD = null, 
			string m3_TCSCD = null, 
			int? m3_FOPRI = null, 
			int? m3_TOPRI = null, 
			int? m3_FSRVP = null, 
			int? m3_TSRVP = null, 
			int? m3_FCYP6 = null, 
			int? m3_TCYP6 = null, 
			string m3_FAOST = null, 
			string m3_TAOST = null, 
			string m3_CNPE = null, 
			string m3_EMAL = null, 
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
				.WithQueryParameter("IDAT", m3_IDAT.ToM3String())
				.WithQueryParameter("ACDT", m3_ACDT.ToM3String())
				.WithQueryParameter("PICD", m3_PICD.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_ADI2.HasValue)
				request.WithQueryParameter("ADI2", m3_ADI2.Value.ToString());
			if (m3_AZIN.HasValue)
				request.WithQueryParameter("AZIN", m3_AZIN.Value.ToString());
			if (m3_PAIC.HasValue)
				request.WithQueryParameter("PAIC", m3_PAIC.Value.ToString());
			if (m3_INVR.HasValue)
				request.WithQueryParameter("INVR", m3_INVR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FFACI))
				request.WithQueryParameter("FFACI", m3_FFACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFACI))
				request.WithQueryParameter("TFACI", m3_TFACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRESP))
				request.WithQueryParameter("FRESP", m3_FRESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRESP))
				request.WithQueryParameter("TRESP", m3_TRESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FPYNO))
				request.WithQueryParameter("FPYNO", m3_FPYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TPYNO))
				request.WithQueryParameter("TPYNO", m3_TPYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FORNO))
				request.WithQueryParameter("FORNO", m3_FORNO.Trim());
			if (m3_FPONR.HasValue)
				request.WithQueryParameter("FPONR", m3_FPONR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TORNO))
				request.WithQueryParameter("TORNO", m3_TORNO.Trim());
			if (m3_TPONR.HasValue)
				request.WithQueryParameter("TPONR", m3_TPONR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FAAGN))
				request.WithQueryParameter("FAAGN", m3_FAAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAAGN))
				request.WithQueryParameter("TAAGN", m3_TAAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FAPRS))
				request.WithQueryParameter("FAPRS", m3_FAPRS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAPRS))
				request.WithQueryParameter("TAPRS", m3_TAPRS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCSCD))
				request.WithQueryParameter("FCSCD", m3_FCSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TCSCD))
				request.WithQueryParameter("TCSCD", m3_TCSCD.Trim());
			if (m3_FOPRI.HasValue)
				request.WithQueryParameter("FOPRI", m3_FOPRI.Value.ToString());
			if (m3_TOPRI.HasValue)
				request.WithQueryParameter("TOPRI", m3_TOPRI.Value.ToString());
			if (m3_FSRVP.HasValue)
				request.WithQueryParameter("FSRVP", m3_FSRVP.Value.ToString());
			if (m3_TSRVP.HasValue)
				request.WithQueryParameter("TSRVP", m3_TSRVP.Value.ToString());
			if (m3_FCYP6.HasValue)
				request.WithQueryParameter("FCYP6", m3_FCYP6.Value.ToString());
			if (m3_TCYP6.HasValue)
				request.WithQueryParameter("TCYP6", m3_TCYP6.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FAOST))
				request.WithQueryParameter("FAOST", m3_FAOST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAOST))
				request.WithQueryParameter("TAOST", m3_TAOST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CNPE))
				request.WithQueryParameter("CNPE", m3_CNPE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EMAL))
				request.WithQueryParameter("EMAL", m3_EMAL.Trim());

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
		/// Name PrintQuotation
		/// Description InvoiceProp
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_IDAT">Invoice date (Required)</param>
		/// <param name="m3_ACDT">Accounting date (Required)</param>
		/// <param name="m3_PICD">Advance invoicing code (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_ADI2">Reconciliation invoice</param>
		/// <param name="m3_AZIN">Close meter based lines</param>
		/// <param name="m3_PAIC">Summary invoicing code</param>
		/// <param name="m3_INVR">Invoice round</param>
		/// <param name="m3_AQUO">Quotation</param>
		/// <param name="m3_FFACI">Facility from</param>
		/// <param name="m3_TFACI">Facility to</param>
		/// <param name="m3_FRESP">Responsible from</param>
		/// <param name="m3_TRESP">Responsible to</param>
		/// <param name="m3_FPYNO">Payer from</param>
		/// <param name="m3_TPYNO">Payer to</param>
		/// <param name="m3_FORNO">Customer order number from</param>
		/// <param name="m3_FPONR">Order line number from</param>
		/// <param name="m3_TORNO">Customer order number to</param>
		/// <param name="m3_TPONR">Order line number to</param>
		/// <param name="m3_FAAGN">Agreement from</param>
		/// <param name="m3_TAAGN">Agreement to</param>
		/// <param name="m3_FAPRS">Project from</param>
		/// <param name="m3_TAPRS">Project to</param>
		/// <param name="m3_FCSCD">Country from</param>
		/// <param name="m3_TCSCD">Country to</param>
		/// <param name="m3_FOPRI">Priority from</param>
		/// <param name="m3_TOPRI">Priority to</param>
		/// <param name="m3_FSRVP">Service price method from</param>
		/// <param name="m3_TSRVP">Service price method to</param>
		/// <param name="m3_FCYP6">Period from</param>
		/// <param name="m3_TCYP6">Period to</param>
		/// <param name="m3_FAOST">Highest status from</param>
		/// <param name="m3_TAOST">Highest status to</param>
		/// <param name="m3_CNPE">Contact person</param>
		/// <param name="m3_EMAL">Electronic mail address</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrintQuotation(
			DateTime m3_IDAT, 
			DateTime m3_ACDT, 
			int m3_PICD, 
			string m3_DIVI = null, 
			int? m3_ADI2 = null, 
			int? m3_AZIN = null, 
			int? m3_PAIC = null, 
			decimal? m3_INVR = null, 
			int? m3_AQUO = null, 
			string m3_FFACI = null, 
			string m3_TFACI = null, 
			string m3_FRESP = null, 
			string m3_TRESP = null, 
			string m3_FPYNO = null, 
			string m3_TPYNO = null, 
			string m3_FORNO = null, 
			int? m3_FPONR = null, 
			string m3_TORNO = null, 
			int? m3_TPONR = null, 
			string m3_FAAGN = null, 
			string m3_TAAGN = null, 
			string m3_FAPRS = null, 
			string m3_TAPRS = null, 
			string m3_FCSCD = null, 
			string m3_TCSCD = null, 
			int? m3_FOPRI = null, 
			int? m3_TOPRI = null, 
			int? m3_FSRVP = null, 
			int? m3_TSRVP = null, 
			int? m3_FCYP6 = null, 
			int? m3_TCYP6 = null, 
			string m3_FAOST = null, 
			string m3_TAOST = null, 
			string m3_CNPE = null, 
			string m3_EMAL = null, 
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
				.WithQueryParameter("IDAT", m3_IDAT.ToM3String())
				.WithQueryParameter("ACDT", m3_ACDT.ToM3String())
				.WithQueryParameter("PICD", m3_PICD.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_ADI2.HasValue)
				request.WithQueryParameter("ADI2", m3_ADI2.Value.ToString());
			if (m3_AZIN.HasValue)
				request.WithQueryParameter("AZIN", m3_AZIN.Value.ToString());
			if (m3_PAIC.HasValue)
				request.WithQueryParameter("PAIC", m3_PAIC.Value.ToString());
			if (m3_INVR.HasValue)
				request.WithQueryParameter("INVR", m3_INVR.Value.ToString());
			if (m3_AQUO.HasValue)
				request.WithQueryParameter("AQUO", m3_AQUO.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FFACI))
				request.WithQueryParameter("FFACI", m3_FFACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TFACI))
				request.WithQueryParameter("TFACI", m3_TFACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FRESP))
				request.WithQueryParameter("FRESP", m3_FRESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TRESP))
				request.WithQueryParameter("TRESP", m3_TRESP.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FPYNO))
				request.WithQueryParameter("FPYNO", m3_FPYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TPYNO))
				request.WithQueryParameter("TPYNO", m3_TPYNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FORNO))
				request.WithQueryParameter("FORNO", m3_FORNO.Trim());
			if (m3_FPONR.HasValue)
				request.WithQueryParameter("FPONR", m3_FPONR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_TORNO))
				request.WithQueryParameter("TORNO", m3_TORNO.Trim());
			if (m3_TPONR.HasValue)
				request.WithQueryParameter("TPONR", m3_TPONR.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FAAGN))
				request.WithQueryParameter("FAAGN", m3_FAAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAAGN))
				request.WithQueryParameter("TAAGN", m3_TAAGN.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FAPRS))
				request.WithQueryParameter("FAPRS", m3_FAPRS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAPRS))
				request.WithQueryParameter("TAPRS", m3_TAPRS.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FCSCD))
				request.WithQueryParameter("FCSCD", m3_FCSCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TCSCD))
				request.WithQueryParameter("TCSCD", m3_TCSCD.Trim());
			if (m3_FOPRI.HasValue)
				request.WithQueryParameter("FOPRI", m3_FOPRI.Value.ToString());
			if (m3_TOPRI.HasValue)
				request.WithQueryParameter("TOPRI", m3_TOPRI.Value.ToString());
			if (m3_FSRVP.HasValue)
				request.WithQueryParameter("FSRVP", m3_FSRVP.Value.ToString());
			if (m3_TSRVP.HasValue)
				request.WithQueryParameter("TSRVP", m3_TSRVP.Value.ToString());
			if (m3_FCYP6.HasValue)
				request.WithQueryParameter("FCYP6", m3_FCYP6.Value.ToString());
			if (m3_TCYP6.HasValue)
				request.WithQueryParameter("TCYP6", m3_TCYP6.Value.ToString());
			if (!string.IsNullOrWhiteSpace(m3_FAOST))
				request.WithQueryParameter("FAOST", m3_FAOST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TAOST))
				request.WithQueryParameter("TAOST", m3_TAOST.Trim());
			if (!string.IsNullOrWhiteSpace(m3_CNPE))
				request.WithQueryParameter("CNPE", m3_CNPE.Trim());
			if (!string.IsNullOrWhiteSpace(m3_EMAL))
				request.WithQueryParameter("EMAL", m3_EMAL.Trim());

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
