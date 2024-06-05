/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0352
/// **********************************************************************
using M3H5Lib.Api.FCS330MI;
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
	/// Name: FCS330MI
	/// Component Name: ForecastDistribution
	/// Description: Forecast distribution table interface
	/// Version Release: 15.1
	///</summary>
	public partial class FCS330MIResource : M3BaseResourceEndpoint
	{
		public FCS330MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "FCS330MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add Forecast distribution table
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3DITI">Distribution table</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX15">Name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3WHLO = null, 
			string m3DITI = null, 
			string m3TX40 = null, 
			string m3TX15 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Add",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DITI))
				request.WithQueryParameter("DITI", m3DITI.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX15))
				request.WithQueryParameter("TX15", m3TX15.Trim());

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
		/// Name AddLines
		/// Description Add Forecast distribution table lines
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3DITI">Distribution table</param>
		/// <param name="m3FRWE">From week</param>
		/// <param name="m3TOWE">To week</param>
		/// <param name="m3D1PC">Day percentage</param>
		/// <param name="m3D2PC">Day percentage</param>
		/// <param name="m3D3PC">Day percentage</param>
		/// <param name="m3D4PC">Day percentage</param>
		/// <param name="m3D5PC">Day percentage</param>
		/// <param name="m3D6PC">Day percentage</param>
		/// <param name="m3D7PC">Day percentage</param>
		/// <param name="m3DAQ1">Day 1 quantity</param>
		/// <param name="m3DAQ2">Day 2 quantity</param>
		/// <param name="m3DAQ3">Day 3 quantity</param>
		/// <param name="m3DAQ4">Day 4 quantity</param>
		/// <param name="m3DAQ5">Day 5 quantity</param>
		/// <param name="m3DAQ6">Day 6 quantity</param>
		/// <param name="m3DAQ7">Day 7 quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddLinesResponse></returns>
		/// <exception cref="M3Exception<AddLinesResponse>"></exception>
		public async Task<M3Response<AddLinesResponse>> AddLines(
			string m3WHLO = null, 
			string m3DITI = null, 
			int? m3FRWE = null, 
			int? m3TOWE = null, 
			int? m3D1PC = null, 
			int? m3D2PC = null, 
			int? m3D3PC = null, 
			int? m3D4PC = null, 
			int? m3D5PC = null, 
			int? m3D6PC = null, 
			int? m3D7PC = null, 
			decimal? m3DAQ1 = null, 
			decimal? m3DAQ2 = null, 
			decimal? m3DAQ3 = null, 
			decimal? m3DAQ4 = null, 
			decimal? m3DAQ5 = null, 
			decimal? m3DAQ6 = null, 
			decimal? m3DAQ7 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/AddLines",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DITI))
				request.WithQueryParameter("DITI", m3DITI.Trim());
			if (m3FRWE.HasValue)
				request.WithQueryParameter("FRWE", m3FRWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TOWE.HasValue)
				request.WithQueryParameter("TOWE", m3TOWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D1PC.HasValue)
				request.WithQueryParameter("D1PC", m3D1PC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D2PC.HasValue)
				request.WithQueryParameter("D2PC", m3D2PC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D3PC.HasValue)
				request.WithQueryParameter("D3PC", m3D3PC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D4PC.HasValue)
				request.WithQueryParameter("D4PC", m3D4PC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D5PC.HasValue)
				request.WithQueryParameter("D5PC", m3D5PC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D6PC.HasValue)
				request.WithQueryParameter("D6PC", m3D6PC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D7PC.HasValue)
				request.WithQueryParameter("D7PC", m3D7PC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DAQ1.HasValue)
				request.WithQueryParameter("DAQ1", m3DAQ1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DAQ2.HasValue)
				request.WithQueryParameter("DAQ2", m3DAQ2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DAQ3.HasValue)
				request.WithQueryParameter("DAQ3", m3DAQ3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DAQ4.HasValue)
				request.WithQueryParameter("DAQ4", m3DAQ4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DAQ5.HasValue)
				request.WithQueryParameter("DAQ5", m3DAQ5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DAQ6.HasValue)
				request.WithQueryParameter("DAQ6", m3DAQ6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DAQ7.HasValue)
				request.WithQueryParameter("DAQ7", m3DAQ7.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<AddLinesResponse>(
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
		/// Name Del
		/// Description Delete Forecast distribution table
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3DITI">Distribution table</param>
		/// <param name="m3FRWE">From week</param>
		/// <param name="m3TOWE">To week</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Del(
			string m3WHLO = null, 
			string m3DITI = null, 
			int? m3FRWE = null, 
			int? m3TOWE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Del",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DITI))
				request.WithQueryParameter("DITI", m3DITI.Trim());
			if (m3FRWE.HasValue)
				request.WithQueryParameter("FRWE", m3FRWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TOWE.HasValue)
				request.WithQueryParameter("TOWE", m3TOWE.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name Lst
		/// Description List Forecast table
		/// Version Release: 
		/// </summary>
		/// <param name="m3FWHL">Warehouse</param>
		/// <param name="m3TWHL">Warehouse</param>
		/// <param name="m3FDIT">Distribution table</param>
		/// <param name="m3TDIT">Distribution table</param>
		/// <param name="m3FRWE">From week</param>
		/// <param name="m3TOWE">To week</param>
		/// <param name="m3LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			string m3FWHL = null, 
			string m3TWHL = null, 
			string m3FDIT = null, 
			string m3TDIT = null, 
			int? m3FRWE = null, 
			int? m3TOWE = null, 
			decimal? m3LMTS = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Lst",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3FWHL))
				request.WithQueryParameter("FWHL", m3FWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWHL))
				request.WithQueryParameter("TWHL", m3TWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3FDIT))
				request.WithQueryParameter("FDIT", m3FDIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3TDIT))
				request.WithQueryParameter("TDIT", m3TDIT.Trim());
			if (m3FRWE.HasValue)
				request.WithQueryParameter("FRWE", m3FRWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TOWE.HasValue)
				request.WithQueryParameter("TOWE", m3TOWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3LMTS.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstResponse>(
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
		/// Name Sel
		/// Description Sel Forecast distribution table
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3DITI">Distribution table</param>
		/// <param name="m3FRWE">From week</param>
		/// <param name="m3TOWE">To week</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelResponse></returns>
		/// <exception cref="M3Exception<SelResponse>"></exception>
		public async Task<M3Response<SelResponse>> Sel(
			string m3WHLO = null, 
			string m3DITI = null, 
			int? m3FRWE = null, 
			int? m3TOWE = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Sel",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DITI))
				request.WithQueryParameter("DITI", m3DITI.Trim());
			if (m3FRWE.HasValue)
				request.WithQueryParameter("FRWE", m3FRWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TOWE.HasValue)
				request.WithQueryParameter("TOWE", m3TOWE.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<SelResponse>(
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
		/// Name Upd
		/// Description Update Forecast distribution table
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3WHLO">Warehouse</param>
		/// <param name="m3DITI">Distribution table</param>
		/// <param name="m3FRWE">From week</param>
		/// <param name="m3TOWE">To week</param>
		/// <param name="m3D1PC">Day percentage</param>
		/// <param name="m3D2PC">Day percentage</param>
		/// <param name="m3D3PC">Day percentage</param>
		/// <param name="m3D4PC">Day percentage</param>
		/// <param name="m3D5PC">Day percentage</param>
		/// <param name="m3D6PC">Day percentage</param>
		/// <param name="m3D7PC">Day percentage</param>
		/// <param name="m3DAQ1">Day 1 quantity</param>
		/// <param name="m3DAQ2">Day 2 quantity</param>
		/// <param name="m3DAQ3">Day 3 quantity</param>
		/// <param name="m3DAQ4">Day 4 quantity</param>
		/// <param name="m3DAQ5">Day 5 quantity</param>
		/// <param name="m3DAQ6">Day 6 quantity</param>
		/// <param name="m3DAQ7">Day 7 quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3WHLO = null, 
			string m3DITI = null, 
			int? m3FRWE = null, 
			int? m3TOWE = null, 
			int? m3D1PC = null, 
			int? m3D2PC = null, 
			int? m3D3PC = null, 
			int? m3D4PC = null, 
			int? m3D5PC = null, 
			int? m3D6PC = null, 
			int? m3D7PC = null, 
			decimal? m3DAQ1 = null, 
			decimal? m3DAQ2 = null, 
			decimal? m3DAQ3 = null, 
			decimal? m3DAQ4 = null, 
			decimal? m3DAQ5 = null, 
			decimal? m3DAQ6 = null, 
			decimal? m3DAQ7 = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Upd",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3WHLO))
				request.WithQueryParameter("WHLO", m3WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3DITI))
				request.WithQueryParameter("DITI", m3DITI.Trim());
			if (m3FRWE.HasValue)
				request.WithQueryParameter("FRWE", m3FRWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TOWE.HasValue)
				request.WithQueryParameter("TOWE", m3TOWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D1PC.HasValue)
				request.WithQueryParameter("D1PC", m3D1PC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D2PC.HasValue)
				request.WithQueryParameter("D2PC", m3D2PC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D3PC.HasValue)
				request.WithQueryParameter("D3PC", m3D3PC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D4PC.HasValue)
				request.WithQueryParameter("D4PC", m3D4PC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D5PC.HasValue)
				request.WithQueryParameter("D5PC", m3D5PC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D6PC.HasValue)
				request.WithQueryParameter("D6PC", m3D6PC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3D7PC.HasValue)
				request.WithQueryParameter("D7PC", m3D7PC.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DAQ1.HasValue)
				request.WithQueryParameter("DAQ1", m3DAQ1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DAQ2.HasValue)
				request.WithQueryParameter("DAQ2", m3DAQ2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DAQ3.HasValue)
				request.WithQueryParameter("DAQ3", m3DAQ3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DAQ4.HasValue)
				request.WithQueryParameter("DAQ4", m3DAQ4.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DAQ5.HasValue)
				request.WithQueryParameter("DAQ5", m3DAQ5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DAQ6.HasValue)
				request.WithQueryParameter("DAQ6", m3DAQ6.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DAQ7.HasValue)
				request.WithQueryParameter("DAQ7", m3DAQ7.Value.ToString(CultureInfo.CurrentCulture));

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
