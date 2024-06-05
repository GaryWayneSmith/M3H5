/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
/// **********************************************************************
using M3H5Lib.Api.CSS006MI;
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
	/// Name: CSS006MI
	/// Component Name: Machine/Engine pricing API
	/// Description: Machine/Engine pricing API
	/// Version Release: 14.x
	///</summary>
	public partial class CSS006MIResource : M3BaseResourceEndpoint
	{
		public CSS006MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CSS006MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name AddN
		/// Description Add Machine and Enging Pricing N-records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3IDL1">Dealer code (Required)</param>
		/// <param name="m3APRM">Price model (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3SECO">Section code (Required)</param>
		/// <param name="m3SEQ3">Sequence number (Required)</param>
		/// <param name="m3SEQ2">Sub sequence number (Required)</param>
		/// <param name="m3TPCD">Item category (Required)</param>
		/// <param name="m3SEQ5">Reference sequence number (Required)</param>
		/// <param name="m3AVCD">Activity code</param>
		/// <param name="m3MSDS">Sequence number</param>
		/// <param name="m3ANSQ">Attribute sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddN(
			string m3IDL1, 
			string m3APRM, 
			DateTime m3FDAT, 
			string m3SECO, 
			int m3SEQ3, 
			int m3SEQ2, 
			int m3TPCD, 
			int m3SEQ5, 
			string m3AVCD = null, 
			int? m3MSDS = null, 
			int? m3ANSQ = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddN",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IDL1))
				throw new ArgumentNullException(nameof(m3IDL1));
			if (string.IsNullOrWhiteSpace(m3APRM))
				throw new ArgumentNullException(nameof(m3APRM));
			if (string.IsNullOrWhiteSpace(m3SECO))
				throw new ArgumentNullException(nameof(m3SECO));

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3IDL1.Trim())
				.WithQueryParameter("APRM", m3APRM.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String())
				.WithQueryParameter("SECO", m3SECO.Trim())
				.WithQueryParameter("SEQ3", m3SEQ3.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SEQ2", m3SEQ2.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TPCD", m3TPCD.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SEQ5", m3SEQ5.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3AVCD))
				request.WithQueryParameter("AVCD", m3AVCD.Trim());
			if (m3MSDS.HasValue)
				request.WithQueryParameter("MSDS", m3MSDS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ANSQ.HasValue)
				request.WithQueryParameter("ANSQ", m3ANSQ.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddP
		/// Description Add equipment Interface Parameters
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3STCO">Constant value (Required)</param>
		/// <param name="m3TX20">Text</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX70">Text</param>
		/// <param name="m3PARM">Parameter value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddP(
			string m3STCO, 
			string m3TX20 = null, 
			string m3TX40 = null, 
			string m3TX70 = null, 
			string m3PARM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddP",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3STCO))
				throw new ArgumentNullException(nameof(m3STCO));

			// Set mandatory parameters
			request
				.WithQueryParameter("STCO", m3STCO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3TX20))
				request.WithQueryParameter("TX20", m3TX20.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX70))
				request.WithQueryParameter("TX70", m3TX70.Trim());
			if (!string.IsNullOrWhiteSpace(m3PARM))
				request.WithQueryParameter("PARM", m3PARM.Trim());

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
		/// Name AddR
		/// Description Add Machine and Enging Pricing R-records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3IDL1">Dealer code (Required)</param>
		/// <param name="m3APRM">Price model (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3SECO">Section code (Required)</param>
		/// <param name="m3SEQ3">Sequence number (Required)</param>
		/// <param name="m3SEQ2">Sub sequence number (Required)</param>
		/// <param name="m3TPCD">Item category (Required)</param>
		/// <param name="m3SEQ5">Reference sequence number (Required)</param>
		/// <param name="m3CHDA">Change date (Required)</param>
		/// <param name="m3AVCD">Activity code</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BIRS">Date introduced into Movex</param>
		/// <param name="m3REPI">Replaced item number</param>
		/// <param name="m3USCO">Use code</param>
		/// <param name="m3GRWE">Gross weight</param>
		/// <param name="m3NEWE">Net weight</param>
		/// <param name="m3SAPR">Sales price</param>
		/// <param name="m3SAP1">Sales price</param>
		/// <param name="m3NTCD">Net price used</param>
		/// <param name="m3DIP1">Discount 1</param>
		/// <param name="m3ITDS">Name</param>
		/// <param name="m3ATCI">Attachment indicator</param>
		/// <param name="m3IN60">Indicator</param>
		/// <param name="m3ORPT">Order product type</param>
		/// <param name="m3IN71">Indicator</param>
		/// <param name="m3ASLM">Sales model</param>
		/// <param name="m3MSDS">Sequence number</param>
		/// <param name="m3ANSQ">Attribute sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddR(
			string m3IDL1, 
			string m3APRM, 
			DateTime m3FDAT, 
			string m3SECO, 
			int m3SEQ3, 
			int m3SEQ2, 
			int m3TPCD, 
			int m3SEQ5, 
			DateTime m3CHDA, 
			string m3AVCD = null, 
			string m3ITNO = null, 
			DateTime? m3BIRS = null, 
			string m3REPI = null, 
			string m3USCO = null, 
			decimal? m3GRWE = null, 
			decimal? m3NEWE = null, 
			decimal? m3SAPR = null, 
			decimal? m3SAP1 = null, 
			int? m3NTCD = null, 
			int? m3DIP1 = null, 
			string m3ITDS = null, 
			string m3ATCI = null, 
			string m3IN60 = null, 
			string m3ORPT = null, 
			string m3IN71 = null, 
			string m3ASLM = null, 
			int? m3MSDS = null, 
			int? m3ANSQ = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddR",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IDL1))
				throw new ArgumentNullException(nameof(m3IDL1));
			if (string.IsNullOrWhiteSpace(m3APRM))
				throw new ArgumentNullException(nameof(m3APRM));
			if (string.IsNullOrWhiteSpace(m3SECO))
				throw new ArgumentNullException(nameof(m3SECO));

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3IDL1.Trim())
				.WithQueryParameter("APRM", m3APRM.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String())
				.WithQueryParameter("SECO", m3SECO.Trim())
				.WithQueryParameter("SEQ3", m3SEQ3.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SEQ2", m3SEQ2.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TPCD", m3TPCD.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SEQ5", m3SEQ5.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CHDA", m3CHDA.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3AVCD))
				request.WithQueryParameter("AVCD", m3AVCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3BIRS.HasValue)
				request.WithQueryParameter("BIRS", m3BIRS.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3REPI))
				request.WithQueryParameter("REPI", m3REPI.Trim());
			if (!string.IsNullOrWhiteSpace(m3USCO))
				request.WithQueryParameter("USCO", m3USCO.Trim());
			if (m3GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3GRWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3NEWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAP1.HasValue)
				request.WithQueryParameter("SAP1", m3SAP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NTCD.HasValue)
				request.WithQueryParameter("NTCD", m3NTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIP1.HasValue)
				request.WithQueryParameter("DIP1", m3DIP1.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATCI))
				request.WithQueryParameter("ATCI", m3ATCI.Trim());
			if (!string.IsNullOrWhiteSpace(m3IN60))
				request.WithQueryParameter("IN60", m3IN60.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORPT))
				request.WithQueryParameter("ORPT", m3ORPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3IN71))
				request.WithQueryParameter("IN71", m3IN71.Trim());
			if (!string.IsNullOrWhiteSpace(m3ASLM))
				request.WithQueryParameter("ASLM", m3ASLM.Trim());
			if (m3MSDS.HasValue)
				request.WithQueryParameter("MSDS", m3MSDS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ANSQ.HasValue)
				request.WithQueryParameter("ANSQ", m3ANSQ.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddS
		/// Description Add Machine and Enging Pricing S-records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3IDL1">Dealer code (Required)</param>
		/// <param name="m3APRM">Price model (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3MSDS">Sequence number</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3ITCL">Product group</param>
		/// <param name="m3SUDT">Supesede date</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3ARAT">Exchange rate</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddS(
			string m3IDL1, 
			string m3APRM, 
			DateTime m3FDAT, 
			int? m3MSDS = null, 
			string m3FACI = null, 
			string m3ITCL = null, 
			DateTime? m3SUDT = null, 
			string m3CUCD = null, 
			decimal? m3ARAT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddS",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IDL1))
				throw new ArgumentNullException(nameof(m3IDL1));
			if (string.IsNullOrWhiteSpace(m3APRM))
				throw new ArgumentNullException(nameof(m3APRM));

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3IDL1.Trim())
				.WithQueryParameter("APRM", m3APRM.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3MSDS.HasValue)
				request.WithQueryParameter("MSDS", m3MSDS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITCL))
				request.WithQueryParameter("ITCL", m3ITCL.Trim());
			if (m3SUDT.HasValue)
				request.WithQueryParameter("SUDT", m3SUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3ARAT.HasValue)
				request.WithQueryParameter("ARAT", m3ARAT.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddT
		/// Description Add Machine and Enging Pricing N-records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3IDL1">Dealer code (Required)</param>
		/// <param name="m3APRM">Price model (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3SECO">Section code (Required)</param>
		/// <param name="m3SEQ3">Sequence number (Required)</param>
		/// <param name="m3SEQ2">Sub sequence number (Required)</param>
		/// <param name="m3TPCD">Item category (Required)</param>
		/// <param name="m3SEQ5">Reference sequence number (Required)</param>
		/// <param name="m3TXKY">Text sequence number (Required)</param>
		/// <param name="m3TXCC">Text control code (Required)</param>
		/// <param name="m3AVCD">Activity code</param>
		/// <param name="m3TX70">Text</param>
		/// <param name="m3MSDS">Sequence number</param>
		/// <param name="m3ANSQ">Attribute sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddT(
			string m3IDL1, 
			string m3APRM, 
			DateTime m3FDAT, 
			string m3SECO, 
			int m3SEQ3, 
			int m3SEQ2, 
			int m3TPCD, 
			int m3SEQ5, 
			int m3TXKY, 
			string m3TXCC, 
			string m3AVCD = null, 
			string m3TX70 = null, 
			int? m3MSDS = null, 
			int? m3ANSQ = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddT",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IDL1))
				throw new ArgumentNullException(nameof(m3IDL1));
			if (string.IsNullOrWhiteSpace(m3APRM))
				throw new ArgumentNullException(nameof(m3APRM));
			if (string.IsNullOrWhiteSpace(m3SECO))
				throw new ArgumentNullException(nameof(m3SECO));
			if (string.IsNullOrWhiteSpace(m3TXCC))
				throw new ArgumentNullException(nameof(m3TXCC));

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3IDL1.Trim())
				.WithQueryParameter("APRM", m3APRM.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String())
				.WithQueryParameter("SECO", m3SECO.Trim())
				.WithQueryParameter("SEQ3", m3SEQ3.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SEQ2", m3SEQ2.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TPCD", m3TPCD.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SEQ5", m3SEQ5.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TXKY", m3TXKY.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TXCC", m3TXCC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3AVCD))
				request.WithQueryParameter("AVCD", m3AVCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX70))
				request.WithQueryParameter("TX70", m3TX70.Trim());
			if (m3MSDS.HasValue)
				request.WithQueryParameter("MSDS", m3MSDS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ANSQ.HasValue)
				request.WithQueryParameter("ANSQ", m3ANSQ.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name AddU
		/// Description Add Machine and Enging Pricing U-records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3IDL1">Dealer code (Required)</param>
		/// <param name="m3APRM">Price model (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3SECO">Section code (Required)</param>
		/// <param name="m3SEQ3">Sequence number (Required)</param>
		/// <param name="m3SEQ2">Sub sequence number (Required)</param>
		/// <param name="m3TPCD">Item category (Required)</param>
		/// <param name="m3AVCD">Activity code</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX70">Text</param>
		/// <param name="m3MSDS">Sequence number</param>
		/// <param name="m3ANSQ">Attribute sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> AddU(
			string m3IDL1, 
			string m3APRM, 
			DateTime m3FDAT, 
			string m3SECO, 
			int m3SEQ3, 
			int m3SEQ2, 
			int m3TPCD, 
			string m3AVCD = null, 
			string m3TX40 = null, 
			string m3TX70 = null, 
			int? m3MSDS = null, 
			int? m3ANSQ = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/AddU",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IDL1))
				throw new ArgumentNullException(nameof(m3IDL1));
			if (string.IsNullOrWhiteSpace(m3APRM))
				throw new ArgumentNullException(nameof(m3APRM));
			if (string.IsNullOrWhiteSpace(m3SECO))
				throw new ArgumentNullException(nameof(m3SECO));

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3IDL1.Trim())
				.WithQueryParameter("APRM", m3APRM.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String())
				.WithQueryParameter("SECO", m3SECO.Trim())
				.WithQueryParameter("SEQ3", m3SEQ3.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SEQ2", m3SEQ2.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TPCD", m3TPCD.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3AVCD))
				request.WithQueryParameter("AVCD", m3AVCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX70))
				request.WithQueryParameter("TX70", m3TX70.Trim());
			if (m3MSDS.HasValue)
				request.WithQueryParameter("MSDS", m3MSDS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ANSQ.HasValue)
				request.WithQueryParameter("ANSQ", m3ANSQ.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DelP
		/// Description Delete equipment Interface Parameters
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3STCO">Constant value (Required)</param>
		/// <param name="m3TX20">Text (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3TX70">Text (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelP(
			string m3STCO, 
			string m3TX20, 
			string m3TX40, 
			string m3TX70, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelP",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3STCO))
				throw new ArgumentNullException(nameof(m3STCO));
			if (string.IsNullOrWhiteSpace(m3TX20))
				throw new ArgumentNullException(nameof(m3TX20));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));
			if (string.IsNullOrWhiteSpace(m3TX70))
				throw new ArgumentNullException(nameof(m3TX70));

			// Set mandatory parameters
			request
				.WithQueryParameter("STCO", m3STCO.Trim())
				.WithQueryParameter("TX20", m3TX20.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim())
				.WithQueryParameter("TX70", m3TX70.Trim());

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
		/// Name DltS
		/// Description Delete Machine and Enging Pricing S-record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3IDL1">Dealer code (Required)</param>
		/// <param name="m3APRM">Price model (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltS(
			string m3IDL1, 
			string m3APRM, 
			DateTime m3FDAT, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltS",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IDL1))
				throw new ArgumentNullException(nameof(m3IDL1));
			if (string.IsNullOrWhiteSpace(m3APRM))
				throw new ArgumentNullException(nameof(m3APRM));

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3IDL1.Trim())
				.WithQueryParameter("APRM", m3APRM.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String());

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
		/// Name DltT
		/// Description Delete Machine and Enging Pricing T-record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3IDL1">Dealer code (Required)</param>
		/// <param name="m3APRM">Price model (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3SECO">Section code (Required)</param>
		/// <param name="m3SEQ3">Sequence number (Required)</param>
		/// <param name="m3SEQ2">Sub sequence number (Required)</param>
		/// <param name="m3TPCD">Item category (Required)</param>
		/// <param name="m3SEQ5">Sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltT(
			string m3IDL1, 
			string m3APRM, 
			DateTime m3FDAT, 
			string m3SECO, 
			int m3SEQ3, 
			int m3SEQ2, 
			int m3TPCD, 
			int? m3SEQ5 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltT",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IDL1))
				throw new ArgumentNullException(nameof(m3IDL1));
			if (string.IsNullOrWhiteSpace(m3APRM))
				throw new ArgumentNullException(nameof(m3APRM));
			if (string.IsNullOrWhiteSpace(m3SECO))
				throw new ArgumentNullException(nameof(m3SECO));

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3IDL1.Trim())
				.WithQueryParameter("APRM", m3APRM.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String())
				.WithQueryParameter("SECO", m3SECO.Trim())
				.WithQueryParameter("SEQ3", m3SEQ3.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SEQ2", m3SEQ2.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TPCD", m3TPCD.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (m3SEQ5.HasValue)
				request.WithQueryParameter("SEQ5", m3SEQ5.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name DltU
		/// Description Delete Machine and Enging Pricing U-records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3IDL1">Dealer code (Required)</param>
		/// <param name="m3APRM">Price model (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3SECO">Section code (Required)</param>
		/// <param name="m3SEQ3">Sequence number (Required)</param>
		/// <param name="m3SEQ2">Sub sequence number (Required)</param>
		/// <param name="m3TPCD">Item category (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DltU(
			string m3IDL1, 
			string m3APRM, 
			DateTime m3FDAT, 
			string m3SECO, 
			int m3SEQ3, 
			int m3SEQ2, 
			int m3TPCD, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DltU",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IDL1))
				throw new ArgumentNullException(nameof(m3IDL1));
			if (string.IsNullOrWhiteSpace(m3APRM))
				throw new ArgumentNullException(nameof(m3APRM));
			if (string.IsNullOrWhiteSpace(m3SECO))
				throw new ArgumentNullException(nameof(m3SECO));

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3IDL1.Trim())
				.WithQueryParameter("APRM", m3APRM.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String())
				.WithQueryParameter("SECO", m3SECO.Trim())
				.WithQueryParameter("SEQ3", m3SEQ3.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SEQ2", m3SEQ2.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TPCD", m3TPCD.ToString(CultureInfo.CurrentCulture));

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
		/// Name GetN
		/// Description Get Machine and Enging Pricing N-records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3IDL1">Dealer code (Required)</param>
		/// <param name="m3APRM">Price model (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3SECO">Section code (Required)</param>
		/// <param name="m3SEQ3">Sequence number (Required)</param>
		/// <param name="m3SEQ2">Sub sequence number (Required)</param>
		/// <param name="m3TPCD">Item category (Required)</param>
		/// <param name="m3SEQ5">Reference sequence number (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetNResponse></returns>
		/// <exception cref="M3Exception<GetNResponse>"></exception>
		public async Task<M3Response<GetNResponse>> GetN(
			string m3IDL1, 
			string m3APRM, 
			DateTime m3FDAT, 
			string m3SECO, 
			int m3SEQ3, 
			int m3SEQ2, 
			int m3TPCD, 
			int m3SEQ5, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetN",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IDL1))
				throw new ArgumentNullException(nameof(m3IDL1));
			if (string.IsNullOrWhiteSpace(m3APRM))
				throw new ArgumentNullException(nameof(m3APRM));
			if (string.IsNullOrWhiteSpace(m3SECO))
				throw new ArgumentNullException(nameof(m3SECO));

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3IDL1.Trim())
				.WithQueryParameter("APRM", m3APRM.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String())
				.WithQueryParameter("SECO", m3SECO.Trim())
				.WithQueryParameter("SEQ3", m3SEQ3.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SEQ2", m3SEQ2.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TPCD", m3TPCD.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SEQ5", m3SEQ5.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetNResponse>(
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
		/// Name GetP
		/// Description Get equipment Interface Parameters
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3STCO">Constant value (Required)</param>
		/// <param name="m3TX20">Text (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3TX70">Text (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetPResponse></returns>
		/// <exception cref="M3Exception<GetPResponse>"></exception>
		public async Task<M3Response<GetPResponse>> GetP(
			string m3STCO, 
			string m3TX20, 
			string m3TX40, 
			string m3TX70, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetP",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3STCO))
				throw new ArgumentNullException(nameof(m3STCO));
			if (string.IsNullOrWhiteSpace(m3TX20))
				throw new ArgumentNullException(nameof(m3TX20));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));
			if (string.IsNullOrWhiteSpace(m3TX70))
				throw new ArgumentNullException(nameof(m3TX70));

			// Set mandatory parameters
			request
				.WithQueryParameter("STCO", m3STCO.Trim())
				.WithQueryParameter("TX20", m3TX20.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim())
				.WithQueryParameter("TX70", m3TX70.Trim());

			// Execute the request
			var result = await Execute<GetPResponse>(
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
		/// Name GetR
		/// Description Get Machine and Enging Pricing R-records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3IDL1">Dealer code (Required)</param>
		/// <param name="m3APRM">Price model (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3SECO">Section code (Required)</param>
		/// <param name="m3SEQ3">Sequence number (Required)</param>
		/// <param name="m3SEQ2">Sub sequence number (Required)</param>
		/// <param name="m3TPCD">Item category (Required)</param>
		/// <param name="m3SEQ5">Reference sequence number (Required)</param>
		/// <param name="m3CHDA">Change date (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetRResponse></returns>
		/// <exception cref="M3Exception<GetRResponse>"></exception>
		public async Task<M3Response<GetRResponse>> GetR(
			string m3IDL1, 
			string m3APRM, 
			DateTime m3FDAT, 
			string m3SECO, 
			int m3SEQ3, 
			int m3SEQ2, 
			int m3TPCD, 
			int m3SEQ5, 
			DateTime m3CHDA, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetR",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IDL1))
				throw new ArgumentNullException(nameof(m3IDL1));
			if (string.IsNullOrWhiteSpace(m3APRM))
				throw new ArgumentNullException(nameof(m3APRM));
			if (string.IsNullOrWhiteSpace(m3SECO))
				throw new ArgumentNullException(nameof(m3SECO));

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3IDL1.Trim())
				.WithQueryParameter("APRM", m3APRM.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String())
				.WithQueryParameter("SECO", m3SECO.Trim())
				.WithQueryParameter("SEQ3", m3SEQ3.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SEQ2", m3SEQ2.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TPCD", m3TPCD.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SEQ5", m3SEQ5.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CHDA", m3CHDA.ToM3String());

			// Execute the request
			var result = await Execute<GetRResponse>(
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
		/// Name GetS
		/// Description Get Machine and Enging Pricing S-record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3IDL1">Dealer code (Required)</param>
		/// <param name="m3APRM">Price model (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetSResponse></returns>
		/// <exception cref="M3Exception<GetSResponse>"></exception>
		public async Task<M3Response<GetSResponse>> GetS(
			string m3IDL1, 
			string m3APRM, 
			DateTime m3FDAT, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetS",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IDL1))
				throw new ArgumentNullException(nameof(m3IDL1));
			if (string.IsNullOrWhiteSpace(m3APRM))
				throw new ArgumentNullException(nameof(m3APRM));

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3IDL1.Trim())
				.WithQueryParameter("APRM", m3APRM.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String());

			// Execute the request
			var result = await Execute<GetSResponse>(
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
		/// Name GetT
		/// Description Get Machine and Enging Pricing N-records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3IDL1">Dealer code (Required)</param>
		/// <param name="m3APRM">Price model (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3SECO">Section code (Required)</param>
		/// <param name="m3SEQ3">Sequence number (Required)</param>
		/// <param name="m3SEQ2">Sub sequence number (Required)</param>
		/// <param name="m3TPCD">Item category (Required)</param>
		/// <param name="m3SEQ5">Reference sequence number (Required)</param>
		/// <param name="m3TXKY">Text sequence number (Required)</param>
		/// <param name="m3TXCC">Text control code (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetTResponse></returns>
		/// <exception cref="M3Exception<GetTResponse>"></exception>
		public async Task<M3Response<GetTResponse>> GetT(
			string m3IDL1, 
			string m3APRM, 
			DateTime m3FDAT, 
			string m3SECO, 
			int m3SEQ3, 
			int m3SEQ2, 
			int m3TPCD, 
			int m3SEQ5, 
			int m3TXKY, 
			string m3TXCC, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetT",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IDL1))
				throw new ArgumentNullException(nameof(m3IDL1));
			if (string.IsNullOrWhiteSpace(m3APRM))
				throw new ArgumentNullException(nameof(m3APRM));
			if (string.IsNullOrWhiteSpace(m3SECO))
				throw new ArgumentNullException(nameof(m3SECO));
			if (string.IsNullOrWhiteSpace(m3TXCC))
				throw new ArgumentNullException(nameof(m3TXCC));

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3IDL1.Trim())
				.WithQueryParameter("APRM", m3APRM.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String())
				.WithQueryParameter("SECO", m3SECO.Trim())
				.WithQueryParameter("SEQ3", m3SEQ3.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SEQ2", m3SEQ2.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TPCD", m3TPCD.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SEQ5", m3SEQ5.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TXKY", m3TXKY.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TXCC", m3TXCC.Trim());

			// Execute the request
			var result = await Execute<GetTResponse>(
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
		/// Name GetU
		/// Description Get Machine and Enging Pricing U-records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3IDL1">Dealer code (Required)</param>
		/// <param name="m3APRM">Price model (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3SECO">Section code (Required)</param>
		/// <param name="m3SEQ3">Sequence number (Required)</param>
		/// <param name="m3SEQ2">Sub sequence number (Required)</param>
		/// <param name="m3TPCD">Item category (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetUResponse></returns>
		/// <exception cref="M3Exception<GetUResponse>"></exception>
		public async Task<M3Response<GetUResponse>> GetU(
			string m3IDL1, 
			string m3APRM, 
			DateTime m3FDAT, 
			string m3SECO, 
			int m3SEQ3, 
			int m3SEQ2, 
			int m3TPCD, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/GetU",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IDL1))
				throw new ArgumentNullException(nameof(m3IDL1));
			if (string.IsNullOrWhiteSpace(m3APRM))
				throw new ArgumentNullException(nameof(m3APRM));
			if (string.IsNullOrWhiteSpace(m3SECO))
				throw new ArgumentNullException(nameof(m3SECO));

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3IDL1.Trim())
				.WithQueryParameter("APRM", m3APRM.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String())
				.WithQueryParameter("SECO", m3SECO.Trim())
				.WithQueryParameter("SEQ3", m3SEQ3.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SEQ2", m3SEQ2.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TPCD", m3TPCD.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<GetUResponse>(
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
		/// Name LstN
		/// Description List Machine and Enging Pricing N-records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3IDL1">Dealer code (Required)</param>
		/// <param name="m3APRM">Price model (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3SECO">Section code</param>
		/// <param name="m3SEQ3">Sequence number</param>
		/// <param name="m3SEQ2">Sub sequence number</param>
		/// <param name="m3TPCD">Item category</param>
		/// <param name="m3SEQ5">Reference sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstNResponse></returns>
		/// <exception cref="M3Exception<LstNResponse>"></exception>
		public async Task<M3Response<LstNResponse>> LstN(
			string m3IDL1, 
			string m3APRM, 
			DateTime m3FDAT, 
			string m3SECO = null, 
			int? m3SEQ3 = null, 
			int? m3SEQ2 = null, 
			int? m3TPCD = null, 
			int? m3SEQ5 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstN",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IDL1))
				throw new ArgumentNullException(nameof(m3IDL1));
			if (string.IsNullOrWhiteSpace(m3APRM))
				throw new ArgumentNullException(nameof(m3APRM));

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3IDL1.Trim())
				.WithQueryParameter("APRM", m3APRM.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SECO))
				request.WithQueryParameter("SECO", m3SECO.Trim());
			if (m3SEQ3.HasValue)
				request.WithQueryParameter("SEQ3", m3SEQ3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SEQ2.HasValue)
				request.WithQueryParameter("SEQ2", m3SEQ2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TPCD.HasValue)
				request.WithQueryParameter("TPCD", m3TPCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SEQ5.HasValue)
				request.WithQueryParameter("SEQ5", m3SEQ5.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstNResponse>(
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
		/// Name LstP
		/// Description List Equipment Interface Parameters
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3STCO">Constant value (Required)</param>
		/// <param name="m3PARM">Parameter value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstPResponse></returns>
		/// <exception cref="M3Exception<LstPResponse>"></exception>
		public async Task<M3Response<LstPResponse>> LstP(
			string m3STCO, 
			string m3PARM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstP",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3STCO))
				throw new ArgumentNullException(nameof(m3STCO));

			// Set mandatory parameters
			request
				.WithQueryParameter("STCO", m3STCO.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PARM))
				request.WithQueryParameter("PARM", m3PARM.Trim());

			// Execute the request
			var result = await Execute<LstPResponse>(
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
		/// Name LstR
		/// Description List Machine and Enging Pricing R-records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3IDL1">Dealer code (Required)</param>
		/// <param name="m3APRM">Price model (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3SECO">Section code</param>
		/// <param name="m3SEQ3">Sequence number</param>
		/// <param name="m3SEQ2">Sub sequence number</param>
		/// <param name="m3TPCD">Item category</param>
		/// <param name="m3SEQ5">Reference sequence number</param>
		/// <param name="m3CHDA">Change date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstRResponse></returns>
		/// <exception cref="M3Exception<LstRResponse>"></exception>
		public async Task<M3Response<LstRResponse>> LstR(
			string m3IDL1, 
			string m3APRM, 
			DateTime m3FDAT, 
			string m3SECO = null, 
			int? m3SEQ3 = null, 
			int? m3SEQ2 = null, 
			int? m3TPCD = null, 
			int? m3SEQ5 = null, 
			DateTime? m3CHDA = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstR",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IDL1))
				throw new ArgumentNullException(nameof(m3IDL1));
			if (string.IsNullOrWhiteSpace(m3APRM))
				throw new ArgumentNullException(nameof(m3APRM));

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3IDL1.Trim())
				.WithQueryParameter("APRM", m3APRM.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SECO))
				request.WithQueryParameter("SECO", m3SECO.Trim());
			if (m3SEQ3.HasValue)
				request.WithQueryParameter("SEQ3", m3SEQ3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SEQ2.HasValue)
				request.WithQueryParameter("SEQ2", m3SEQ2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TPCD.HasValue)
				request.WithQueryParameter("TPCD", m3TPCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SEQ5.HasValue)
				request.WithQueryParameter("SEQ5", m3SEQ5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3CHDA.HasValue)
				request.WithQueryParameter("CHDA", m3CHDA.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstRResponse>(
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
		/// Name LstS
		/// Description List Machine and Enging Pricing S-record
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3IDL1">Dealer code (Required)</param>
		/// <param name="m3APRM">Price model</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSResponse></returns>
		/// <exception cref="M3Exception<LstSResponse>"></exception>
		public async Task<M3Response<LstSResponse>> LstS(
			string m3IDL1, 
			string m3APRM = null, 
			DateTime? m3FDAT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstS",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IDL1))
				throw new ArgumentNullException(nameof(m3IDL1));

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3IDL1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3APRM))
				request.WithQueryParameter("APRM", m3APRM.Trim());
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());

			// Execute the request
			var result = await Execute<LstSResponse>(
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
		/// Name LstSByMSDS
		/// Description List Machine and Enging by Sales Model Seq No
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3IDL1">Dealer code (Required)</param>
		/// <param name="m3MSDS">Sequence number</param>
		/// <param name="m3FDAT">From date</param>
		/// <param name="m3APRM">Price model</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstSByMSDSResponse></returns>
		/// <exception cref="M3Exception<LstSByMSDSResponse>"></exception>
		public async Task<M3Response<LstSByMSDSResponse>> LstSByMSDS(
			string m3IDL1, 
			int? m3MSDS = null, 
			DateTime? m3FDAT = null, 
			string m3APRM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstSByMSDS",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IDL1))
				throw new ArgumentNullException(nameof(m3IDL1));

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3IDL1.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (m3MSDS.HasValue)
				request.WithQueryParameter("MSDS", m3MSDS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3FDAT.HasValue)
				request.WithQueryParameter("FDAT", m3FDAT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3APRM))
				request.WithQueryParameter("APRM", m3APRM.Trim());

			// Execute the request
			var result = await Execute<LstSByMSDSResponse>(
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
		/// Name LstT
		/// Description List Machine and Enging Pricing N-records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3IDL1">Dealer code (Required)</param>
		/// <param name="m3APRM">Price model (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3SECO">Section code</param>
		/// <param name="m3SEQ3">Sequence number</param>
		/// <param name="m3SEQ2">Sub sequence number</param>
		/// <param name="m3TPCD">Item category</param>
		/// <param name="m3SEQ5">Reference sequence number</param>
		/// <param name="m3TXKY">Text sequence number</param>
		/// <param name="m3TXCC">Text control code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstTResponse></returns>
		/// <exception cref="M3Exception<LstTResponse>"></exception>
		public async Task<M3Response<LstTResponse>> LstT(
			string m3IDL1, 
			string m3APRM, 
			DateTime m3FDAT, 
			string m3SECO = null, 
			int? m3SEQ3 = null, 
			int? m3SEQ2 = null, 
			int? m3TPCD = null, 
			int? m3SEQ5 = null, 
			int? m3TXKY = null, 
			string m3TXCC = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstT",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IDL1))
				throw new ArgumentNullException(nameof(m3IDL1));
			if (string.IsNullOrWhiteSpace(m3APRM))
				throw new ArgumentNullException(nameof(m3APRM));

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3IDL1.Trim())
				.WithQueryParameter("APRM", m3APRM.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SECO))
				request.WithQueryParameter("SECO", m3SECO.Trim());
			if (m3SEQ3.HasValue)
				request.WithQueryParameter("SEQ3", m3SEQ3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SEQ2.HasValue)
				request.WithQueryParameter("SEQ2", m3SEQ2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TPCD.HasValue)
				request.WithQueryParameter("TPCD", m3TPCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SEQ5.HasValue)
				request.WithQueryParameter("SEQ5", m3SEQ5.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TXKY.HasValue)
				request.WithQueryParameter("TXKY", m3TXKY.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3TXCC))
				request.WithQueryParameter("TXCC", m3TXCC.Trim());

			// Execute the request
			var result = await Execute<LstTResponse>(
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
		/// Name LstU
		/// Description List Machine and Enging Pricing U-records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3IDL1">Dealer code (Required)</param>
		/// <param name="m3APRM">Price model (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3SECO">Section code</param>
		/// <param name="m3SEQ3">Sequence number</param>
		/// <param name="m3SEQ2">Sub sequence number</param>
		/// <param name="m3TPCD">Item category</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstUResponse></returns>
		/// <exception cref="M3Exception<LstUResponse>"></exception>
		public async Task<M3Response<LstUResponse>> LstU(
			string m3IDL1, 
			string m3APRM, 
			DateTime m3FDAT, 
			string m3SECO = null, 
			int? m3SEQ3 = null, 
			int? m3SEQ2 = null, 
			int? m3TPCD = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstU",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IDL1))
				throw new ArgumentNullException(nameof(m3IDL1));
			if (string.IsNullOrWhiteSpace(m3APRM))
				throw new ArgumentNullException(nameof(m3APRM));

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3IDL1.Trim())
				.WithQueryParameter("APRM", m3APRM.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SECO))
				request.WithQueryParameter("SECO", m3SECO.Trim());
			if (m3SEQ3.HasValue)
				request.WithQueryParameter("SEQ3", m3SEQ3.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SEQ2.HasValue)
				request.WithQueryParameter("SEQ2", m3SEQ2.Value.ToString(CultureInfo.CurrentCulture));
			if (m3TPCD.HasValue)
				request.WithQueryParameter("TPCD", m3TPCD.Value.ToString(CultureInfo.CurrentCulture));

			// Execute the request
			var result = await Execute<LstUResponse>(
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
		/// Name Resequence
		/// Description Resequence Machine and Enging Pricing records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3IDL1">Dealer code (Required)</param>
		/// <param name="m3APRM">Price model (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3SECO">Section code</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Resequence(
			string m3IDL1, 
			string m3APRM, 
			DateTime m3FDAT, 
			string m3SECO = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Resequence",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IDL1))
				throw new ArgumentNullException(nameof(m3IDL1));
			if (string.IsNullOrWhiteSpace(m3APRM))
				throw new ArgumentNullException(nameof(m3APRM));

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3IDL1.Trim())
				.WithQueryParameter("APRM", m3APRM.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3SECO))
				request.WithQueryParameter("SECO", m3SECO.Trim());

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
		/// Name UpdateN
		/// Description Update Machine and Enging Pricing N-records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3IDL1">Dealer code (Required)</param>
		/// <param name="m3APRM">Price model (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3SECO">Section code (Required)</param>
		/// <param name="m3SEQ3">Sequence number (Required)</param>
		/// <param name="m3SEQ2">Sub sequence number (Required)</param>
		/// <param name="m3TPCD">Item category (Required)</param>
		/// <param name="m3SEQ5">Reference sequence number (Required)</param>
		/// <param name="m3AVCD">Activity code</param>
		/// <param name="m3MSDS">Sequence number</param>
		/// <param name="m3ANSQ">Attribute sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdateN(
			string m3IDL1, 
			string m3APRM, 
			DateTime m3FDAT, 
			string m3SECO, 
			int m3SEQ3, 
			int m3SEQ2, 
			int m3TPCD, 
			int m3SEQ5, 
			string m3AVCD = null, 
			int? m3MSDS = null, 
			int? m3ANSQ = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdateN",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IDL1))
				throw new ArgumentNullException(nameof(m3IDL1));
			if (string.IsNullOrWhiteSpace(m3APRM))
				throw new ArgumentNullException(nameof(m3APRM));
			if (string.IsNullOrWhiteSpace(m3SECO))
				throw new ArgumentNullException(nameof(m3SECO));

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3IDL1.Trim())
				.WithQueryParameter("APRM", m3APRM.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String())
				.WithQueryParameter("SECO", m3SECO.Trim())
				.WithQueryParameter("SEQ3", m3SEQ3.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SEQ2", m3SEQ2.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TPCD", m3TPCD.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SEQ5", m3SEQ5.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3AVCD))
				request.WithQueryParameter("AVCD", m3AVCD.Trim());
			if (m3MSDS.HasValue)
				request.WithQueryParameter("MSDS", m3MSDS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ANSQ.HasValue)
				request.WithQueryParameter("ANSQ", m3ANSQ.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdateP
		/// Description Update equipment Interface Parameters
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3STCO">Constant value (Required)</param>
		/// <param name="m3TX20">Text (Required)</param>
		/// <param name="m3TX40">Description (Required)</param>
		/// <param name="m3TX70">Text (Required)</param>
		/// <param name="m3PARM">Parameter value</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdateP(
			string m3STCO, 
			string m3TX20, 
			string m3TX40, 
			string m3TX70, 
			string m3PARM = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdateP",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3STCO))
				throw new ArgumentNullException(nameof(m3STCO));
			if (string.IsNullOrWhiteSpace(m3TX20))
				throw new ArgumentNullException(nameof(m3TX20));
			if (string.IsNullOrWhiteSpace(m3TX40))
				throw new ArgumentNullException(nameof(m3TX40));
			if (string.IsNullOrWhiteSpace(m3TX70))
				throw new ArgumentNullException(nameof(m3TX70));

			// Set mandatory parameters
			request
				.WithQueryParameter("STCO", m3STCO.Trim())
				.WithQueryParameter("TX20", m3TX20.Trim())
				.WithQueryParameter("TX40", m3TX40.Trim())
				.WithQueryParameter("TX70", m3TX70.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3PARM))
				request.WithQueryParameter("PARM", m3PARM.Trim());

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
		/// Name UpdateR
		/// Description Update Machine and Enging Pricing R-records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3IDL1">Dealer code (Required)</param>
		/// <param name="m3APRM">Price model (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3SECO">Section code (Required)</param>
		/// <param name="m3SEQ3">Sequence number (Required)</param>
		/// <param name="m3SEQ2">Sub sequence number (Required)</param>
		/// <param name="m3TPCD">Item category (Required)</param>
		/// <param name="m3SEQ5">Reference sequence number (Required)</param>
		/// <param name="m3CHDA">Change date (Required)</param>
		/// <param name="m3AVCD">Activity code</param>
		/// <param name="m3ITNO">Item number</param>
		/// <param name="m3BIRS">Date introduced into Movex</param>
		/// <param name="m3REPI">Replaced item number</param>
		/// <param name="m3USCO">Use code</param>
		/// <param name="m3GRWE">Gross weight</param>
		/// <param name="m3NEWE">Net weight</param>
		/// <param name="m3SAPR">Sales price</param>
		/// <param name="m3SAP1">Sales price</param>
		/// <param name="m3NTCD">Net price used</param>
		/// <param name="m3DIP1">Discount 1</param>
		/// <param name="m3ITDS">Name</param>
		/// <param name="m3ATCI">Attachment indicator</param>
		/// <param name="m3IN60">Indicator</param>
		/// <param name="m3ORPT">Order product type</param>
		/// <param name="m3IN71">Indicator</param>
		/// <param name="m3ASLM">Sales model</param>
		/// <param name="m3MSDS">Sequence number</param>
		/// <param name="m3ANSQ">Attribute sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdateR(
			string m3IDL1, 
			string m3APRM, 
			DateTime m3FDAT, 
			string m3SECO, 
			int m3SEQ3, 
			int m3SEQ2, 
			int m3TPCD, 
			int m3SEQ5, 
			DateTime m3CHDA, 
			string m3AVCD = null, 
			string m3ITNO = null, 
			DateTime? m3BIRS = null, 
			string m3REPI = null, 
			string m3USCO = null, 
			decimal? m3GRWE = null, 
			decimal? m3NEWE = null, 
			decimal? m3SAPR = null, 
			decimal? m3SAP1 = null, 
			int? m3NTCD = null, 
			int? m3DIP1 = null, 
			string m3ITDS = null, 
			string m3ATCI = null, 
			string m3IN60 = null, 
			string m3ORPT = null, 
			string m3IN71 = null, 
			string m3ASLM = null, 
			int? m3MSDS = null, 
			int? m3ANSQ = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdateR",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IDL1))
				throw new ArgumentNullException(nameof(m3IDL1));
			if (string.IsNullOrWhiteSpace(m3APRM))
				throw new ArgumentNullException(nameof(m3APRM));
			if (string.IsNullOrWhiteSpace(m3SECO))
				throw new ArgumentNullException(nameof(m3SECO));

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3IDL1.Trim())
				.WithQueryParameter("APRM", m3APRM.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String())
				.WithQueryParameter("SECO", m3SECO.Trim())
				.WithQueryParameter("SEQ3", m3SEQ3.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SEQ2", m3SEQ2.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TPCD", m3TPCD.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SEQ5", m3SEQ5.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("CHDA", m3CHDA.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3AVCD))
				request.WithQueryParameter("AVCD", m3AVCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITNO))
				request.WithQueryParameter("ITNO", m3ITNO.Trim());
			if (m3BIRS.HasValue)
				request.WithQueryParameter("BIRS", m3BIRS.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3REPI))
				request.WithQueryParameter("REPI", m3REPI.Trim());
			if (!string.IsNullOrWhiteSpace(m3USCO))
				request.WithQueryParameter("USCO", m3USCO.Trim());
			if (m3GRWE.HasValue)
				request.WithQueryParameter("GRWE", m3GRWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NEWE.HasValue)
				request.WithQueryParameter("NEWE", m3NEWE.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAPR.HasValue)
				request.WithQueryParameter("SAPR", m3SAPR.Value.ToString(CultureInfo.CurrentCulture));
			if (m3SAP1.HasValue)
				request.WithQueryParameter("SAP1", m3SAP1.Value.ToString(CultureInfo.CurrentCulture));
			if (m3NTCD.HasValue)
				request.WithQueryParameter("NTCD", m3NTCD.Value.ToString(CultureInfo.CurrentCulture));
			if (m3DIP1.HasValue)
				request.WithQueryParameter("DIP1", m3DIP1.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3ITDS))
				request.WithQueryParameter("ITDS", m3ITDS.Trim());
			if (!string.IsNullOrWhiteSpace(m3ATCI))
				request.WithQueryParameter("ATCI", m3ATCI.Trim());
			if (!string.IsNullOrWhiteSpace(m3IN60))
				request.WithQueryParameter("IN60", m3IN60.Trim());
			if (!string.IsNullOrWhiteSpace(m3ORPT))
				request.WithQueryParameter("ORPT", m3ORPT.Trim());
			if (!string.IsNullOrWhiteSpace(m3IN71))
				request.WithQueryParameter("IN71", m3IN71.Trim());
			if (!string.IsNullOrWhiteSpace(m3ASLM))
				request.WithQueryParameter("ASLM", m3ASLM.Trim());
			if (m3MSDS.HasValue)
				request.WithQueryParameter("MSDS", m3MSDS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ANSQ.HasValue)
				request.WithQueryParameter("ANSQ", m3ANSQ.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdateS
		/// Description Update Machine and Enging Pricing S-records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3IDL1">Dealer code (Required)</param>
		/// <param name="m3APRM">Price model (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3MSDS">Sequence number</param>
		/// <param name="m3FACI">Facility</param>
		/// <param name="m3ITCL">Product group</param>
		/// <param name="m3SUDT">Supesede date</param>
		/// <param name="m3CUCD">Currency</param>
		/// <param name="m3ARAT">Exchange rate</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdateS(
			string m3IDL1, 
			string m3APRM, 
			DateTime m3FDAT, 
			int? m3MSDS = null, 
			string m3FACI = null, 
			string m3ITCL = null, 
			DateTime? m3SUDT = null, 
			string m3CUCD = null, 
			decimal? m3ARAT = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdateS",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IDL1))
				throw new ArgumentNullException(nameof(m3IDL1));
			if (string.IsNullOrWhiteSpace(m3APRM))
				throw new ArgumentNullException(nameof(m3APRM));

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3IDL1.Trim())
				.WithQueryParameter("APRM", m3APRM.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String());

			// Set optional parameters, checking for null/blank data for each element
			if (m3MSDS.HasValue)
				request.WithQueryParameter("MSDS", m3MSDS.Value.ToString(CultureInfo.CurrentCulture));
			if (!string.IsNullOrWhiteSpace(m3FACI))
				request.WithQueryParameter("FACI", m3FACI.Trim());
			if (!string.IsNullOrWhiteSpace(m3ITCL))
				request.WithQueryParameter("ITCL", m3ITCL.Trim());
			if (m3SUDT.HasValue)
				request.WithQueryParameter("SUDT", m3SUDT.Value.ToM3String());
			if (!string.IsNullOrWhiteSpace(m3CUCD))
				request.WithQueryParameter("CUCD", m3CUCD.Trim());
			if (m3ARAT.HasValue)
				request.WithQueryParameter("ARAT", m3ARAT.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdateT
		/// Description Update Machine and Enging Pricing N-records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3IDL1">Dealer code (Required)</param>
		/// <param name="m3APRM">Price model (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3SECO">Section code (Required)</param>
		/// <param name="m3SEQ3">Sequence number (Required)</param>
		/// <param name="m3SEQ2">Sub sequence number (Required)</param>
		/// <param name="m3TPCD">Item category (Required)</param>
		/// <param name="m3SEQ5">Reference sequence number (Required)</param>
		/// <param name="m3TXKY">Text sequence number (Required)</param>
		/// <param name="m3TXCC">Text control code (Required)</param>
		/// <param name="m3AVCD">Activity code</param>
		/// <param name="m3TX70">Text</param>
		/// <param name="m3MSDS">Sequence number</param>
		/// <param name="m3ANSQ">Attribute sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdateT(
			string m3IDL1, 
			string m3APRM, 
			DateTime m3FDAT, 
			string m3SECO, 
			int m3SEQ3, 
			int m3SEQ2, 
			int m3TPCD, 
			int m3SEQ5, 
			int m3TXKY, 
			string m3TXCC, 
			string m3AVCD = null, 
			string m3TX70 = null, 
			int? m3MSDS = null, 
			int? m3ANSQ = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdateT",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IDL1))
				throw new ArgumentNullException(nameof(m3IDL1));
			if (string.IsNullOrWhiteSpace(m3APRM))
				throw new ArgumentNullException(nameof(m3APRM));
			if (string.IsNullOrWhiteSpace(m3SECO))
				throw new ArgumentNullException(nameof(m3SECO));
			if (string.IsNullOrWhiteSpace(m3TXCC))
				throw new ArgumentNullException(nameof(m3TXCC));

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3IDL1.Trim())
				.WithQueryParameter("APRM", m3APRM.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String())
				.WithQueryParameter("SECO", m3SECO.Trim())
				.WithQueryParameter("SEQ3", m3SEQ3.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SEQ2", m3SEQ2.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TPCD", m3TPCD.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SEQ5", m3SEQ5.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TXKY", m3TXKY.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TXCC", m3TXCC.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3AVCD))
				request.WithQueryParameter("AVCD", m3AVCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX70))
				request.WithQueryParameter("TX70", m3TX70.Trim());
			if (m3MSDS.HasValue)
				request.WithQueryParameter("MSDS", m3MSDS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ANSQ.HasValue)
				request.WithQueryParameter("ANSQ", m3ANSQ.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name UpdateU
		/// Description Update Machine and Enging Pricing U-records
		/// Version Release: 14.x
		/// </summary>
		/// <param name="m3IDL1">Dealer code (Required)</param>
		/// <param name="m3APRM">Price model (Required)</param>
		/// <param name="m3FDAT">From date (Required)</param>
		/// <param name="m3SECO">Section code (Required)</param>
		/// <param name="m3SEQ3">Sequence number (Required)</param>
		/// <param name="m3SEQ2">Sub sequence number (Required)</param>
		/// <param name="m3TPCD">Item category (Required)</param>
		/// <param name="m3AVCD">Activity code</param>
		/// <param name="m3TX40">Description</param>
		/// <param name="m3TX70">Text</param>
		/// <param name="m3MSDS">Sequence number</param>
		/// <param name="m3ANSQ">Attribute sequence number</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> UpdateU(
			string m3IDL1, 
			string m3APRM, 
			DateTime m3FDAT, 
			string m3SECO, 
			int m3SEQ3, 
			int m3SEQ2, 
			int m3TPCD, 
			string m3AVCD = null, 
			string m3TX40 = null, 
			string m3TX70 = null, 
			int? m3MSDS = null, 
			int? m3ANSQ = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/UpdateU",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3IDL1))
				throw new ArgumentNullException(nameof(m3IDL1));
			if (string.IsNullOrWhiteSpace(m3APRM))
				throw new ArgumentNullException(nameof(m3APRM));
			if (string.IsNullOrWhiteSpace(m3SECO))
				throw new ArgumentNullException(nameof(m3SECO));

			// Set mandatory parameters
			request
				.WithQueryParameter("IDL1", m3IDL1.Trim())
				.WithQueryParameter("APRM", m3APRM.Trim())
				.WithQueryParameter("FDAT", m3FDAT.ToM3String())
				.WithQueryParameter("SECO", m3SECO.Trim())
				.WithQueryParameter("SEQ3", m3SEQ3.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("SEQ2", m3SEQ2.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("TPCD", m3TPCD.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3AVCD))
				request.WithQueryParameter("AVCD", m3AVCD.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX40))
				request.WithQueryParameter("TX40", m3TX40.Trim());
			if (!string.IsNullOrWhiteSpace(m3TX70))
				request.WithQueryParameter("TX70", m3TX70.Trim());
			if (m3MSDS.HasValue)
				request.WithQueryParameter("MSDS", m3MSDS.Value.ToString(CultureInfo.CurrentCulture));
			if (m3ANSQ.HasValue)
				request.WithQueryParameter("ANSQ", m3ANSQ.Value.ToString(CultureInfo.CurrentCulture));

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
