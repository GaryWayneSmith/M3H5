/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.RPS180MI;
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
	/// Name: RPS180MI
	/// Component Name: Planning template
	/// Description: Api: Planning template
	/// Version Release: 5e90
	///</summary>
	public partial class RPS180MIResource : M3BaseResourceEndpoint
	{
		public RPS180MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "RPS180MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddPLT
		/// Description Add planning template
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PLNT">Planning template (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3CONO">Company (NO FUNCTION)</param>
		/// <param name="m3GMSG">Generate messages</param>
		/// <param name="m3PUIT">Acquisition code</param>
		/// <param name="m3DPID">Period frame</param>
		/// <param name="m3OPLC">Planning method</param>
		/// <param name="m3PLCD">Planning policy</param>
		/// <param name="m3MSCH">Master scheduled</param>
		/// <param name="m3SCPO">Supply chain policy</param>
		/// <param name="m3IPLA">Inventory planned</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3CONC">Continuous net change</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3PRCD">Forecast method</param>
		/// <param name="m3FCCM">Forecast logic</param>
		/// <param name="m3SVEI">Multiple supply</param>
		/// <param name="m3SSMT">Safety stock method</param>
		/// <param name="m3SSDA">Safety stock unit</param>
		/// <param name="m3SCGR">Service level</param>
		/// <param name="m3OPOM">Reorder point method</param>
		/// <param name="m3EOQM">Order policy</param>
		/// <param name="m3SALE">Sales item</param>
		/// <param name="m3CLDM">Clear demand</param>
		/// <param name="m3CLOR">Clear order quantities</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddPLTResponse></returns>
		/// <exception cref="M3Exception<AddPLTResponse>"></exception>
		public async Task<M3Response<AddPLTResponse>> AddPLT(
			string m3PLNT, 
			string m3TX40, 
			int? m3CONO = null, 
			int? m3GMSG = null, 
			int? m3PUIT = null, 
			int? m3DPID = null, 
			int? m3OPLC = null, 
			string m3PLCD = null, 
			int? m3MSCH = null, 
			string m3SCPO = null, 
			string m3IPLA = null, 
			string m3STAT = null, 
			int? m3CONC = null, 
			string m3ORTY = null, 
			string m3PRCD = null, 
			string m3FCCM = null, 
			int? m3SVEI = null, 
			int? m3SSMT = null, 
			int? m3SSDA = null, 
			int? m3SCGR = null, 
			int? m3OPOM = null, 
			int? m3EOQM = null, 
			int? m3SALE = null, 
			int? m3CLDM = null, 
			int? m3CLOR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddPLT",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PLNT))
				throw new ArgumentNullException(nameof(m3PLNT));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));

			// Set mandatory parameters
			request
				.WithQueryParameter("PLNT", m3PLNT.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3GMSG.HasValue)
				request.WithQueryParameter("GMSG", m3GMSG.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PUIT.HasValue)
				request.WithQueryParameter("PUIT", m3PUIT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DPID.HasValue)
				request.WithQueryParameter("DPID", m3DPID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPLC.HasValue)
				request.WithQueryParameter("OPLC", m3OPLC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PLCD))
				request.WithQueryParameter("PLCD", m3PLCD.Trim());
			if (m3MSCH.HasValue)
				request.WithQueryParameter("MSCH", m3MSCH.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SCPO))
				request.WithQueryParameter("SCPO", m3SCPO.Trim());
			if (!string.IsNullOrWhiteSpace(m3IPLA))
				request.WithQueryParameter("IPLA", m3IPLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3CONC.HasValue)
				request.WithQueryParameter("CONC", m3CONC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRCD))
				request.WithQueryParameter("PRCD", m3PRCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCCM))
				request.WithQueryParameter("FCCM", m3FCCM.Trim());
			if (m3SVEI.HasValue)
				request.WithQueryParameter("SVEI", m3SVEI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SSMT.HasValue)
				request.WithQueryParameter("SSMT", m3SSMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SSDA.HasValue)
				request.WithQueryParameter("SSDA", m3SSDA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCGR.HasValue)
				request.WithQueryParameter("SCGR", m3SCGR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPOM.HasValue)
				request.WithQueryParameter("OPOM", m3OPOM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EOQM.HasValue)
				request.WithQueryParameter("EOQM", m3EOQM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SALE.HasValue)
				request.WithQueryParameter("SALE", m3SALE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CLDM.HasValue)
				request.WithQueryParameter("CLDM", m3CLDM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CLOR.HasValue)
				request.WithQueryParameter("CLOR", m3CLOR.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddPLTResponse>(
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
		/// Name ChangePLT
		/// Description Edit planning template
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PLNT">Planning template (Required)</param>
		/// <param name="m3CONO">Company (NO FUNCTION)</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3GMSG">Generate messages</param>
		/// <param name="m3PUIT">Acquisition code</param>
		/// <param name="m3DPID">Period frame</param>
		/// <param name="m3OPLC">Planning method</param>
		/// <param name="m3PLCD">Planning policy</param>
		/// <param name="m3MSCH">Master scheduled</param>
		/// <param name="m3SCPO">Supply chain policy</param>
		/// <param name="m3IPLA">Inventory planned</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3CONC">Continuous net change</param>
		/// <param name="m3ORTY">Order type</param>
		/// <param name="m3PRCD">Forecast method</param>
		/// <param name="m3FCCM">Forecast logic</param>
		/// <param name="m3SVEI">Multiple supply</param>
		/// <param name="m3SSMT">Safety stock method</param>
		/// <param name="m3SSDA">Safety stock unit</param>
		/// <param name="m3SCGR">Service level</param>
		/// <param name="m3OPOM">Reorder point method</param>
		/// <param name="m3EOQM">Order policy</param>
		/// <param name="m3SALE">Sales item</param>
		/// <param name="m3CLDM">Clear demand</param>
		/// <param name="m3CLOR">Clear order quantities</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ChangePLT(
			string m3PLNT, 
			int? m3CONO = null, 
			string m3TX40 = null, 
			int? m3GMSG = null, 
			int? m3PUIT = null, 
			int? m3DPID = null, 
			int? m3OPLC = null, 
			string m3PLCD = null, 
			int? m3MSCH = null, 
			string m3SCPO = null, 
			string m3IPLA = null, 
			string m3STAT = null, 
			int? m3CONC = null, 
			string m3ORTY = null, 
			string m3PRCD = null, 
			string m3FCCM = null, 
			int? m3SVEI = null, 
			int? m3SSMT = null, 
			int? m3SSDA = null, 
			int? m3SCGR = null, 
			int? m3OPOM = null, 
			int? m3EOQM = null, 
			int? m3SALE = null, 
			int? m3CLDM = null, 
			int? m3CLOR = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ChangePLT",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PLNT))
				throw new ArgumentNullException(nameof(m3PLNT));

			// Set mandatory parameters
			request
				.WithQueryParameter("PLNT", m3PLNT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (m3GMSG.HasValue)
				request.WithQueryParameter("GMSG", m3GMSG.Value.ToString(CultureInfo.CurrentCulture));
			if (m3PUIT.HasValue)
				request.WithQueryParameter("PUIT", m3PUIT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DPID.HasValue)
				request.WithQueryParameter("DPID", m3DPID.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPLC.HasValue)
				request.WithQueryParameter("OPLC", m3OPLC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3PLCD))
				request.WithQueryParameter("PLCD", m3PLCD.Trim());
			if (m3MSCH.HasValue)
				request.WithQueryParameter("MSCH", m3MSCH.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3SCPO))
				request.WithQueryParameter("SCPO", m3SCPO.Trim());
			if (!string.IsNullOrWhiteSpace(m3IPLA))
				request.WithQueryParameter("IPLA", m3IPLA.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3CONC.HasValue)
				request.WithQueryParameter("CONC", m3CONC.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ORTY))
				request.WithQueryParameter("ORTY", m3ORTY.Trim());
			if (!string.IsNullOrWhiteSpace(m3PRCD))
				request.WithQueryParameter("PRCD", m3PRCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3FCCM))
				request.WithQueryParameter("FCCM", m3FCCM.Trim());
			if (m3SVEI.HasValue)
				request.WithQueryParameter("SVEI", m3SVEI.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SSMT.HasValue)
				request.WithQueryParameter("SSMT", m3SSMT.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SSDA.HasValue)
				request.WithQueryParameter("SSDA", m3SSDA.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SCGR.HasValue)
				request.WithQueryParameter("SCGR", m3SCGR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OPOM.HasValue)
				request.WithQueryParameter("OPOM", m3OPOM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3EOQM.HasValue)
				request.WithQueryParameter("EOQM", m3EOQM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SALE.HasValue)
				request.WithQueryParameter("SALE", m3SALE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CLDM.HasValue)
				request.WithQueryParameter("CLDM", m3CLDM.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CLOR.HasValue)
				request.WithQueryParameter("CLOR", m3CLOR.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name CopyPLT
		/// Description Copy planning template
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3FRPL">Planning template (Required)</param>
		/// <param name="m3TOPL">Planning template (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> CopyPLT(
			string m3FRPL, 
			string m3TOPL, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/CopyPLT",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FRPL))
				throw new ArgumentNullException(nameof(m3FRPL));
			if (string.IsNullOrWhiteSpace(m3TOPL))
				throw new ArgumentNullException(nameof(m3TOPL));

			// Set mandatory parameters
			request
				.WithQueryParameter("FRPL", m3FRPL.Trim())
				.WithQueryParameter("TOPL", m3TOPL.Trim());

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
		/// Name DeletePLT
		/// Description Delete planning template
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PLNT">Planning template (Required)</param>
		/// <param name="m3CONO">Company (NO FUNCTION)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DeletePLT(
			string m3PLNT, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DeletePLT",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PLNT))
				throw new ArgumentNullException(nameof(m3PLNT));

			// Set mandatory parameters
			request
				.WithQueryParameter("PLNT", m3PLNT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ListPLT
		/// Description List planning templates
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PLNT">Planning template (Required)</param>
		/// <param name="m3CONO">Company (NO FUNCTION)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<ListPLTResponse></returns>
		/// <exception cref="M3Exception<ListPLTResponse>"></exception>
		public async Task<M3Response<ListPLTResponse>> ListPLT(
			string m3PLNT, 
			int? m3CONO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ListPLT",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PLNT))
				throw new ArgumentNullException(nameof(m3PLNT));

			// Set mandatory parameters
			request
				.WithQueryParameter("PLNT", m3PLNT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3CONO.HasValue)
				request.WithQueryParameter("CONO", m3CONO.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<ListPLTResponse>(
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
