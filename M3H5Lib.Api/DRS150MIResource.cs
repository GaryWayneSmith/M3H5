/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.DRS150MI;
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
	/// Name: DRS150MI
	/// Component Name: Shipment package
	/// Description: Shipment Package Interface
	/// Version Release: 14.x
	///</summary>
	public partial class DRS150MIResource : M3BaseResourceEndpoint
	{
		public DRS150MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "DRS150MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddShipmentPck
		/// Description Add Shipment Package
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3PACT">Packaging (Required)</param>
		/// <param name="m3CONN">Shipment (Required)</param>
		/// <param name="m3SPNO">Shipment package number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<AddShipmentPckResponse></returns>
		/// <exception cref="M3Exception<AddShipmentPckResponse>"></exception>
		public async Task<M3Response<AddShipmentPckResponse>> AddShipmentPck(
			string m3PACT, 
			int m3CONN, 
			string m3SPNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddShipmentPck",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3PACT))
				throw new ArgumentNullException(nameof(m3PACT));

			// Set mandatory parameters
			request
				.WithQueryParameter("PACT", m3PACT.Trim())
				.WithQueryParameter("CONN", m3CONN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SPNO))
				request.WithQueryParameter("SPNO", m3SPNO.Trim());

			// Execute the request
			var result = await Execute<AddShipmentPckResponse>(
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
		/// Name DelShipmentPck
		/// Description Delete Shipment Package
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SPNO">Shipment package number</param>
		/// <param name="m3SSCC">SSCC number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<DelShipmentPckResponse></returns>
		/// <exception cref="M3Exception<DelShipmentPckResponse>"></exception>
		public async Task<M3Response<DelShipmentPckResponse>> DelShipmentPck(
			string m3SPNO = null, 
			string m3SSCC = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelShipmentPck",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SPNO))
				request.WithQueryParameter("SPNO", m3SPNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SSCC))
				request.WithQueryParameter("SSCC", m3SSCC.Trim());

			// Execute the request
			var result = await Execute<DelShipmentPckResponse>(
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
		/// Name GetShipmentPck
		/// Description Get Shipment Package
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SPNO">Shipment package number</param>
		/// <param name="m3SSCC">SSCC number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetShipmentPckResponse></returns>
		/// <exception cref="M3Exception<GetShipmentPckResponse>"></exception>
		public async Task<M3Response<GetShipmentPckResponse>> GetShipmentPck(
			string m3SPNO = null, 
			string m3SSCC = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetShipmentPck",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SPNO))
				request.WithQueryParameter("SPNO", m3SPNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SSCC))
				request.WithQueryParameter("SSCC", m3SSCC.Trim());

			// Execute the request
			var result = await Execute<GetShipmentPckResponse>(
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
		/// Name LstShipmentPck
		/// Description List Shipment Package
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3CONN">Shipment (Required)</param>
		/// <param name="m3SPNO">Shipment package number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstShipmentPckResponse></returns>
		/// <exception cref="M3Exception<LstShipmentPckResponse>"></exception>
		public async Task<M3Response<LstShipmentPckResponse>> LstShipmentPck(
			int m3CONN, 
			string m3SPNO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstShipmentPck",
			};

			// Validate mandatory parameters

			// Set mandatory parameters
			request
				.WithQueryParameter("CONN", m3CONN.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SPNO))
				request.WithQueryParameter("SPNO", m3SPNO.Trim());

			// Execute the request
			var result = await Execute<LstShipmentPckResponse>(
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
		/// Name PrtLabel
		/// Description Print shipment package label
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3SPNO">Shipment package number (Required)</param>
		/// <param name="m3DEV0">Printer</param>
		/// <param name="m3COPY">Number of copies</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrtLabel(
			string m3SPNO, 
			string m3DEV0 = null, 
			int? m3COPY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/PrtLabel",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SPNO))
				throw new ArgumentNullException(nameof(m3SPNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("SPNO", m3SPNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DEV0))
				request.WithQueryParameter("DEV0", m3DEV0.Trim());
			if (m3COPY.HasValue)
				request.WithQueryParameter("COPY", m3COPY.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name PrtNote
		/// Description Print shipment package note
		/// Version Release: 15.1
		/// </summary>
		/// <param name="m3SPNO">Shipment package number (Required)</param>
		/// <param name="m3DEV0">Printer</param>
		/// <param name="m3COPY">Number of copies</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> PrtNote(
			string m3SPNO, 
			string m3DEV0 = null, 
			int? m3COPY = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/PrtNote",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3SPNO))
				throw new ArgumentNullException(nameof(m3SPNO));

			// Set mandatory parameters
			request
				.WithQueryParameter("SPNO", m3SPNO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DEV0))
				request.WithQueryParameter("DEV0", m3DEV0.Trim());
			if (m3COPY.HasValue)
				request.WithQueryParameter("COPY", m3COPY.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name ReportShpPck
		/// Description Report Shipment Package
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SPNO">Shipment package number</param>
		/// <param name="m3SSCC">SSCC number</param>
		/// <param name="m3TWSL">To location</param>
		/// <param name="m3ISMD">Issue/move mode</param>
		/// <param name="m3LODO">Loading platform</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> ReportShpPck(
			string m3SPNO = null, 
			string m3SSCC = null, 
			string m3TWSL = null, 
			int? m3ISMD = null, 
			string m3LODO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/ReportShpPck",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SPNO))
				request.WithQueryParameter("SPNO", m3SPNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SSCC))
				request.WithQueryParameter("SSCC", m3SSCC.Trim());
			if (!string.IsNullOrWhiteSpace(m3TWSL))
				request.WithQueryParameter("TWSL", m3TWSL.Trim());
			if (m3ISMD.HasValue)
				request.WithQueryParameter("ISMD", m3ISMD.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3LODO))
				request.WithQueryParameter("LODO", m3LODO.Trim());

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
		/// Name UnpackShpPck
		/// Description Unpack Shipment Package
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3SPNO">Shipment package number</param>
		/// <param name="m3SSCC">SSCC number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UnpackShpPck(
			string m3SPNO = null, 
			string m3SSCC = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UnpackShpPck",
			};

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SPNO))
				request.WithQueryParameter("SPNO", m3SPNO.Trim());
			if (!string.IsNullOrWhiteSpace(m3SSCC))
				request.WithQueryParameter("SSCC", m3SSCC.Trim());

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
