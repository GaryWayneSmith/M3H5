/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_DITI">Distribution table</param>
		/// <param name="m3_TX40">Description</param>
		/// <param name="m3_TX15">Name</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_WHLO = null, 
			string m3_DITI = null, 
			string m3_TX40 = null, 
			string m3_TX15 = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DITI))
				request.WithQueryParameter("DITI", m3_DITI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX40))
				request.WithQueryParameter("TX40", m3_TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TX15))
				request.WithQueryParameter("TX15", m3_TX15.Trim());

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
		/// Name AddLines
		/// Description Add Forecast distribution table lines
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_DITI">Distribution table</param>
		/// <param name="m3_FRWE">From week</param>
		/// <param name="m3_TOWE">To week</param>
		/// <param name="m3_D1PC">Day percentage</param>
		/// <param name="m3_D2PC">Day percentage</param>
		/// <param name="m3_D3PC">Day percentage</param>
		/// <param name="m3_D4PC">Day percentage</param>
		/// <param name="m3_D5PC">Day percentage</param>
		/// <param name="m3_D6PC">Day percentage</param>
		/// <param name="m3_D7PC">Day percentage</param>
		/// <param name="m3_DAQ1">Day 1 quantity</param>
		/// <param name="m3_DAQ2">Day 2 quantity</param>
		/// <param name="m3_DAQ3">Day 3 quantity</param>
		/// <param name="m3_DAQ4">Day 4 quantity</param>
		/// <param name="m3_DAQ5">Day 5 quantity</param>
		/// <param name="m3_DAQ6">Day 6 quantity</param>
		/// <param name="m3_DAQ7">Day 7 quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddLinesResponse></returns>
		/// <exception cref="M3Exception<AddLinesResponse>"></exception>
		public async Task<M3Response<AddLinesResponse>> AddLines(
			string m3_WHLO = null, 
			string m3_DITI = null, 
			int? m3_FRWE = null, 
			int? m3_TOWE = null, 
			int? m3_D1PC = null, 
			int? m3_D2PC = null, 
			int? m3_D3PC = null, 
			int? m3_D4PC = null, 
			int? m3_D5PC = null, 
			int? m3_D6PC = null, 
			int? m3_D7PC = null, 
			decimal? m3_DAQ1 = null, 
			decimal? m3_DAQ2 = null, 
			decimal? m3_DAQ3 = null, 
			decimal? m3_DAQ4 = null, 
			decimal? m3_DAQ5 = null, 
			decimal? m3_DAQ6 = null, 
			decimal? m3_DAQ7 = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DITI))
				request.WithQueryParameter("DITI", m3_DITI.Trim());
			if (m3_FRWE.HasValue)
				request.WithQueryParameter("FRWE", m3_FRWE.Value.ToString());
			if (m3_TOWE.HasValue)
				request.WithQueryParameter("TOWE", m3_TOWE.Value.ToString());
			if (m3_D1PC.HasValue)
				request.WithQueryParameter("D1PC", m3_D1PC.Value.ToString());
			if (m3_D2PC.HasValue)
				request.WithQueryParameter("D2PC", m3_D2PC.Value.ToString());
			if (m3_D3PC.HasValue)
				request.WithQueryParameter("D3PC", m3_D3PC.Value.ToString());
			if (m3_D4PC.HasValue)
				request.WithQueryParameter("D4PC", m3_D4PC.Value.ToString());
			if (m3_D5PC.HasValue)
				request.WithQueryParameter("D5PC", m3_D5PC.Value.ToString());
			if (m3_D6PC.HasValue)
				request.WithQueryParameter("D6PC", m3_D6PC.Value.ToString());
			if (m3_D7PC.HasValue)
				request.WithQueryParameter("D7PC", m3_D7PC.Value.ToString());
			if (m3_DAQ1.HasValue)
				request.WithQueryParameter("DAQ1", m3_DAQ1.Value.ToString());
			if (m3_DAQ2.HasValue)
				request.WithQueryParameter("DAQ2", m3_DAQ2.Value.ToString());
			if (m3_DAQ3.HasValue)
				request.WithQueryParameter("DAQ3", m3_DAQ3.Value.ToString());
			if (m3_DAQ4.HasValue)
				request.WithQueryParameter("DAQ4", m3_DAQ4.Value.ToString());
			if (m3_DAQ5.HasValue)
				request.WithQueryParameter("DAQ5", m3_DAQ5.Value.ToString());
			if (m3_DAQ6.HasValue)
				request.WithQueryParameter("DAQ6", m3_DAQ6.Value.ToString());
			if (m3_DAQ7.HasValue)
				request.WithQueryParameter("DAQ7", m3_DAQ7.Value.ToString());

			// Execute the request
			var result = await Execute<AddLinesResponse>(
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
		/// Name Del
		/// Description Delete Forecast distribution table
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_DITI">Distribution table</param>
		/// <param name="m3_FRWE">From week</param>
		/// <param name="m3_TOWE">To week</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Del(
			string m3_WHLO = null, 
			string m3_DITI = null, 
			int? m3_FRWE = null, 
			int? m3_TOWE = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DITI))
				request.WithQueryParameter("DITI", m3_DITI.Trim());
			if (m3_FRWE.HasValue)
				request.WithQueryParameter("FRWE", m3_FRWE.Value.ToString());
			if (m3_TOWE.HasValue)
				request.WithQueryParameter("TOWE", m3_TOWE.Value.ToString());

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
		/// Name Lst
		/// Description List Forecast table
		/// Version Release: 
		/// </summary>
		/// <param name="m3_FWHL">Warehouse</param>
		/// <param name="m3_TWHL">Warehouse</param>
		/// <param name="m3_FDIT">Distribution table</param>
		/// <param name="m3_TDIT">Distribution table</param>
		/// <param name="m3_FRWE">From week</param>
		/// <param name="m3_TOWE">To week</param>
		/// <param name="m3_LMTS">Timestamp</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			string m3_FWHL = null, 
			string m3_TWHL = null, 
			string m3_FDIT = null, 
			string m3_TDIT = null, 
			int? m3_FRWE = null, 
			int? m3_TOWE = null, 
			decimal? m3_LMTS = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_FWHL))
				request.WithQueryParameter("FWHL", m3_FWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TWHL))
				request.WithQueryParameter("TWHL", m3_TWHL.Trim());
			if (!string.IsNullOrWhiteSpace(m3_FDIT))
				request.WithQueryParameter("FDIT", m3_FDIT.Trim());
			if (!string.IsNullOrWhiteSpace(m3_TDIT))
				request.WithQueryParameter("TDIT", m3_TDIT.Trim());
			if (m3_FRWE.HasValue)
				request.WithQueryParameter("FRWE", m3_FRWE.Value.ToString());
			if (m3_TOWE.HasValue)
				request.WithQueryParameter("TOWE", m3_TOWE.Value.ToString());
			if (m3_LMTS.HasValue)
				request.WithQueryParameter("LMTS", m3_LMTS.Value.ToString());

			// Execute the request
			var result = await Execute<LstResponse>(
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
		/// Name Sel
		/// Description Sel Forecast distribution table
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_DITI">Distribution table</param>
		/// <param name="m3_FRWE">From week</param>
		/// <param name="m3_TOWE">To week</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<SelResponse></returns>
		/// <exception cref="M3Exception<SelResponse>"></exception>
		public async Task<M3Response<SelResponse>> Sel(
			string m3_WHLO = null, 
			string m3_DITI = null, 
			int? m3_FRWE = null, 
			int? m3_TOWE = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DITI))
				request.WithQueryParameter("DITI", m3_DITI.Trim());
			if (m3_FRWE.HasValue)
				request.WithQueryParameter("FRWE", m3_FRWE.Value.ToString());
			if (m3_TOWE.HasValue)
				request.WithQueryParameter("TOWE", m3_TOWE.Value.ToString());

			// Execute the request
			var result = await Execute<SelResponse>(
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
		/// Name Upd
		/// Description Update Forecast distribution table
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3_WHLO">Warehouse</param>
		/// <param name="m3_DITI">Distribution table</param>
		/// <param name="m3_FRWE">From week</param>
		/// <param name="m3_TOWE">To week</param>
		/// <param name="m3_D1PC">Day percentage</param>
		/// <param name="m3_D2PC">Day percentage</param>
		/// <param name="m3_D3PC">Day percentage</param>
		/// <param name="m3_D4PC">Day percentage</param>
		/// <param name="m3_D5PC">Day percentage</param>
		/// <param name="m3_D6PC">Day percentage</param>
		/// <param name="m3_D7PC">Day percentage</param>
		/// <param name="m3_DAQ1">Day 1 quantity</param>
		/// <param name="m3_DAQ2">Day 2 quantity</param>
		/// <param name="m3_DAQ3">Day 3 quantity</param>
		/// <param name="m3_DAQ4">Day 4 quantity</param>
		/// <param name="m3_DAQ5">Day 5 quantity</param>
		/// <param name="m3_DAQ6">Day 6 quantity</param>
		/// <param name="m3_DAQ7">Day 7 quantity</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3_WHLO = null, 
			string m3_DITI = null, 
			int? m3_FRWE = null, 
			int? m3_TOWE = null, 
			int? m3_D1PC = null, 
			int? m3_D2PC = null, 
			int? m3_D3PC = null, 
			int? m3_D4PC = null, 
			int? m3_D5PC = null, 
			int? m3_D6PC = null, 
			int? m3_D7PC = null, 
			decimal? m3_DAQ1 = null, 
			decimal? m3_DAQ2 = null, 
			decimal? m3_DAQ3 = null, 
			decimal? m3_DAQ4 = null, 
			decimal? m3_DAQ5 = null, 
			decimal? m3_DAQ6 = null, 
			decimal? m3_DAQ7 = null, 
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
			if (!string.IsNullOrWhiteSpace(m3_WHLO))
				request.WithQueryParameter("WHLO", m3_WHLO.Trim());
			if (!string.IsNullOrWhiteSpace(m3_DITI))
				request.WithQueryParameter("DITI", m3_DITI.Trim());
			if (m3_FRWE.HasValue)
				request.WithQueryParameter("FRWE", m3_FRWE.Value.ToString());
			if (m3_TOWE.HasValue)
				request.WithQueryParameter("TOWE", m3_TOWE.Value.ToString());
			if (m3_D1PC.HasValue)
				request.WithQueryParameter("D1PC", m3_D1PC.Value.ToString());
			if (m3_D2PC.HasValue)
				request.WithQueryParameter("D2PC", m3_D2PC.Value.ToString());
			if (m3_D3PC.HasValue)
				request.WithQueryParameter("D3PC", m3_D3PC.Value.ToString());
			if (m3_D4PC.HasValue)
				request.WithQueryParameter("D4PC", m3_D4PC.Value.ToString());
			if (m3_D5PC.HasValue)
				request.WithQueryParameter("D5PC", m3_D5PC.Value.ToString());
			if (m3_D6PC.HasValue)
				request.WithQueryParameter("D6PC", m3_D6PC.Value.ToString());
			if (m3_D7PC.HasValue)
				request.WithQueryParameter("D7PC", m3_D7PC.Value.ToString());
			if (m3_DAQ1.HasValue)
				request.WithQueryParameter("DAQ1", m3_DAQ1.Value.ToString());
			if (m3_DAQ2.HasValue)
				request.WithQueryParameter("DAQ2", m3_DAQ2.Value.ToString());
			if (m3_DAQ3.HasValue)
				request.WithQueryParameter("DAQ3", m3_DAQ3.Value.ToString());
			if (m3_DAQ4.HasValue)
				request.WithQueryParameter("DAQ4", m3_DAQ4.Value.ToString());
			if (m3_DAQ5.HasValue)
				request.WithQueryParameter("DAQ5", m3_DAQ5.Value.ToString());
			if (m3_DAQ6.HasValue)
				request.WithQueryParameter("DAQ6", m3_DAQ6.Value.ToString());
			if (m3_DAQ7.HasValue)
				request.WithQueryParameter("DAQ7", m3_DAQ7.Value.ToString());

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
