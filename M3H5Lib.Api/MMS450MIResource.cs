/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.MMS450MI;
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
	/// Name: MMS450MI
	/// Component Name: Packing instructions
	/// Description: Packing instructions
	/// Version Release: 14.x
	///</summary>
	public partial class MMS450MIResource : M3BaseResourceEndpoint
	{
		public MMS450MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "MMS450MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name LstPckInstByOrd
		/// Description List packing instructions by order
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3ORCA">Order category (Required)</param>
		/// <param name="m3RIDN">Order number (Required)</param>
		/// <param name="m3RIDL">Order line</param>
		/// <param name="m3RIDX">Line suffix</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPckInstByOrdResponse></returns>
		/// <exception cref="M3Exception<LstPckInstByOrdResponse>"></exception>
		public async Task<M3Response<LstPckInstByOrdResponse>> LstPckInstByOrd(
			string m3ORCA, 
			string m3RIDN, 
			int? m3RIDL = null, 
			int? m3RIDX = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPckInstByOrd",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ORCA))
				throw new ArgumentNullException(nameof(m3ORCA));
			if (string.IsNullOrWhiteSpace(m3RIDN))
				throw new ArgumentNullException(nameof(m3RIDN));

			// Set mandatory parameters
			request
				.WithQueryParameter("ORCA", m3ORCA.Trim())
				.WithQueryParameter("RIDN", m3RIDN.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3RIDL.HasValue)
				request.WithQueryParameter("RIDL", m3RIDL.Value.ToString(CultureInfo.CurrentCulture));
			if (m3RIDX.HasValue)
				request.WithQueryParameter("RIDX", m3RIDX.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstPckInstByOrdResponse>(
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
		/// Name LstPckInstCons
		/// Description List packing instructions Consignee
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PINN">Packing instruction header number (Required)</param>
		/// <param name="m3PPNB">Pre-pack number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPckInstConsResponse></returns>
		/// <exception cref="M3Exception<LstPckInstConsResponse>"></exception>
		public async Task<M3Response<LstPckInstConsResponse>> LstPckInstCons(
			long m3PINN, 
			string m3PPNB, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPckInstCons",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PPNB))
				throw new ArgumentNullException(nameof(m3PPNB));

			// Set mandatory parameters
			request
				.WithQueryParameter("PINN", m3PINN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PPNB", m3PPNB.Trim());

			// Execute the request
			var result = await Execute<LstPckInstConsResponse>(
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
		/// Name LstPckInstDet
		/// Description List packing instructions detail
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PINN">Packing instruction header number (Required)</param>
		/// <param name="m3PPNB">Pre-pack number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPckInstDetResponse></returns>
		/// <exception cref="M3Exception<LstPckInstDetResponse>"></exception>
		public async Task<M3Response<LstPckInstDetResponse>> LstPckInstDet(
			long m3PINN, 
			string m3PPNB, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPckInstDet",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PPNB))
				throw new ArgumentNullException(nameof(m3PPNB));

			// Set mandatory parameters
			request
				.WithQueryParameter("PINN", m3PINN.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("PPNB", m3PPNB.Trim());

			// Execute the request
			var result = await Execute<LstPckInstDetResponse>(
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
		/// Name LstPckInstLines
		/// Description List Packing Instruction Lines
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PINN">Packing instruction header number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPckInstLinesResponse></returns>
		/// <exception cref="M3Exception<LstPckInstLinesResponse>"></exception>
		public async Task<M3Response<LstPckInstLinesResponse>> LstPckInstLines(
			long m3PINN, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstPckInstLines",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("PINN", m3PINN.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstPckInstLinesResponse>(
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
