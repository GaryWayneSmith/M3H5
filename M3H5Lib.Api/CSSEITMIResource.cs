/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.CSSEITMI;
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
	/// Name: CSSEITMI
	/// Component Name: ExternalInformation
	/// Description: Api: External Temporary order information
	/// Version Release: 
	///</summary>
	public partial class CSSEITMIResource : M3BaseResourceEndpoint
	{
		public CSSEITMIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CSSEITMI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstExtTempInf
		/// Description List External Temporary Order Information
		/// Version Release: 
		/// </summary>
		/// <param name="m3ORCA">Order category</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3TMPO">Temporary order</param>
		/// <param name="m3RIDL">Order line</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstExtTempInfResponse></returns>
		/// <exception cref="M3Exception<LstExtTempInfResponse>"></exception>
		public async Task<M3Response<LstExtTempInfResponse>> LstExtTempInf(
			string m3ORCA = null, 
			string m3RIDN = null, 
			int? m3TMPO = null, 
			int? m3RIDL = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstExtTempInf",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ORCA))
				request.WithQueryParameter("ORCA", m3ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (m3TMPO.HasValue)
				request.WithQueryParameter("TMPO", m3TMPO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3RIDL.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstExtTempInfResponse>(
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
		/// Name UpdExtTempInf
		/// Description Update External Temporary Order Information
		/// Version Release: 
		/// </summary>
		/// <param name="m3ORCA">Order category</param>
		/// <param name="m3RIDN">Order number</param>
		/// <param name="m3TMPO">Temporary order</param>
		/// <param name="m3RIDL">Order line</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3EICI">Credit indicator</param>
		/// <param name="m3IATH">Item authorized</param>
		/// <param name="m3ATHL">Authorization level</param>
		/// <param name="m3EREF">External reference</param>
		/// <param name="m3USD1">User-defined field</param>
		/// <param name="m3USD2">User-defined field</param>
		/// <param name="m3USD3">User-defined field</param>
		/// <param name="m3USD4">User-defined field</param>
		/// <param name="m3USD5">User-defined field</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdExtTempInf(
			string m3ORCA = null, 
			string m3RIDN = null, 
			int? m3TMPO = null, 
			int? m3RIDL = null, 
			string m3ITNO = null, 
			string m3EICI = null, 
			string m3IATH = null, 
			string m3ATHL = null, 
			string m3EREF = null, 
			string m3USD1 = null, 
			string m3USD2 = null, 
			string m3USD3 = null, 
			string m3USD4 = null, 
			string m3USD5 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdExtTempInf",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3ORCA))
				request.WithQueryParameter("ORCA", m3ORCA.Trim());
			if (!string.IsNullOrWhiteSpace(m3RIDN))
				request.WithQueryParameter("RIDN", m3RIDN.Trim());
			if (m3TMPO.HasValue)
				request.WithQueryParameter("TMPO", m3TMPO.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3RIDL.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3EICI))
				request.WithQueryParameter("EICI", m3EICI.Trim());
			if (!string.IsNullOrWhiteSpace(m3IATH))
				request.WithQueryParameter("IATH", m3IATH.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATHL))
				request.WithQueryParameter("ATHL", m3ATHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3EREF))
				request.WithQueryParameter("EREF", m3EREF.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD1))
				request.WithQueryParameter("USD1", m3USD1.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD2))
				request.WithQueryParameter("USD2", m3USD2.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD3))
				request.WithQueryParameter("USD3", m3USD3.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD4))
				request.WithQueryParameter("USD4", m3USD4.Trim());
			if (!string.IsNullOrWhiteSpace(m3USD5))
				request.WithQueryParameter("USD5", m3USD5.Trim());

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
