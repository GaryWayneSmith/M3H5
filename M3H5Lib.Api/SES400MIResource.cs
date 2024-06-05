/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
/// **********************************************************************
using M3H5Lib.Api.SES400MI;
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
	/// Name: SES400MI
	/// Component Name: Manage Security option
	/// Description: Manage Security option interface
	/// Version Release: 5ea2
	///</summary>
	public partial class SES400MIResource : M3BaseResourceEndpoint
	{
		public SES400MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "SES400MI";
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FNID">Function (Required)</param>
		/// <param name="m3_ROLL">Role (Required)</param>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_STAT">Status (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_AL01">Option 1 permitted</param>
		/// <param name="m3_AL02">Option 2 permitted</param>
		/// <param name="m3_AL03">Option 3 permitted</param>
		/// <param name="m3_AL04">Option 4 permitted</param>
		/// <param name="m3_AL05">Option 5 permitted</param>
		/// <param name="m3_AL06">Option 6 permitted</param>
		/// <param name="m3_AL07">Option 7 permitted</param>
		/// <param name="m3_AL08">Option 8 permitted</param>
		/// <param name="m3_AL09">Option 9 permitted</param>
		/// <param name="m3_OK10">Option 10 permitted</param>
		/// <param name="m3_OK11">Option 11 permitted</param>
		/// <param name="m3_OK12">Option 12 permitted</param>
		/// <param name="m3_OK13">Option 13 permitted</param>
		/// <param name="m3_OK14">Option 14 permitted</param>
		/// <param name="m3_OK15">Option 15 permitted</param>
		/// <param name="m3_OK16">Option 16 permitted</param>
		/// <param name="m3_OK17">Option 17 permitted</param>
		/// <param name="m3_OK18">Option 18 permitted</param>
		/// <param name="m3_OK19">Option 19 permitted</param>
		/// <param name="m3_OK20">Option 20 permitted</param>
		/// <param name="m3_OK21">Option 21 permitted</param>
		/// <param name="m3_OK22">Option 22 permitted</param>
		/// <param name="m3_OK23">Option 23 permitted</param>
		/// <param name="m3_OK24">Option 24 permitted</param>
		/// <param name="m3_OK25">Option 25 permitted</param>
		/// <param name="m3_OK26">Option 26 permitted</param>
		/// <param name="m3_OK27">Option 27 permitted</param>
		/// <param name="m3_OK28">Option 28 permitted</param>
		/// <param name="m3_OK29">Option 29 permitted</param>
		/// <param name="m3_OK30">Option 30 permitted</param>
		/// <param name="m3_OK31">Option 31 permitted</param>
		/// <param name="m3_OK32">Option 32 permitted</param>
		/// <param name="m3_OK33">Option 33 permitted</param>
		/// <param name="m3_OK34">Option 34 permitted</param>
		/// <param name="m3_OK35">Option 35 permitted</param>
		/// <param name="m3_OK36">Option 36 permitted</param>
		/// <param name="m3_OK37">Option 37 permitted</param>
		/// <param name="m3_OK38">Option 38 permitted</param>
		/// <param name="m3_OK39">Option 39 permitted</param>
		/// <param name="m3_OK40">Option 40 permitted</param>
		/// <param name="m3_OK41">Option 41 permitted</param>
		/// <param name="m3_OK42">Option 42 permitted</param>
		/// <param name="m3_OK43">Option 43 permitted</param>
		/// <param name="m3_OK44">Option 44 permitted</param>
		/// <param name="m3_OK45">Option 45 permitted</param>
		/// <param name="m3_OK46">Option 46 permitted</param>
		/// <param name="m3_OK47">Option 47 permitted</param>
		/// <param name="m3_OK48">Option 48 permitted</param>
		/// <param name="m3_OK49">Option 49 permitted</param>
		/// <param name="m3_OK50">Option 50 permitted</param>
		/// <param name="m3_OK51">Option 51 permitted</param>
		/// <param name="m3_OK52">Option 52 permitted</param>
		/// <param name="m3_OK53">Option 53 permitted</param>
		/// <param name="m3_OK54">Option 54 permitted</param>
		/// <param name="m3_OK55">Option 55 permitted</param>
		/// <param name="m3_OK56">Option 56 permitted</param>
		/// <param name="m3_OK57">Option 57 permitted</param>
		/// <param name="m3_OK58">Option 58 permitted</param>
		/// <param name="m3_OK59">Option 59 permitted</param>
		/// <param name="m3_OK60">Option 60 permitted</param>
		/// <param name="m3_OK61">Option 61 permitted</param>
		/// <param name="m3_OK62">Option 62 permitted</param>
		/// <param name="m3_OK63">Option 63 permitted</param>
		/// <param name="m3_OK64">Option 64 permitted</param>
		/// <param name="m3_OK65">Option 65 permitted</param>
		/// <param name="m3_OK66">Option 66 permitted</param>
		/// <param name="m3_OK67">Option 67 permitted</param>
		/// <param name="m3_OK68">Option 68 permitted</param>
		/// <param name="m3_OK69">Option 69 permitted</param>
		/// <param name="m3_OK70">Option 70 permitted</param>
		/// <param name="m3_OK71">Option 71 permitted</param>
		/// <param name="m3_OK72">Option 72 permitted</param>
		/// <param name="m3_OK73">Option 73 permitted</param>
		/// <param name="m3_OK74">Option 74 permitted</param>
		/// <param name="m3_OK75">Option 75 permitted</param>
		/// <param name="m3_OK76">Option 76 permitted</param>
		/// <param name="m3_OK77">Option 77 permitted</param>
		/// <param name="m3_OK78">Option 78 permitted</param>
		/// <param name="m3_OK79">Option 79 permitted</param>
		/// <param name="m3_OK80">Option 80 permitted</param>
		/// <param name="m3_OK81">Option 81 permitted</param>
		/// <param name="m3_OK82">Option 82 permitted</param>
		/// <param name="m3_OK83">Option 83 permitted</param>
		/// <param name="m3_OK84">Option 84 permitted</param>
		/// <param name="m3_OK85">Option 85 permitted</param>
		/// <param name="m3_OK86">Option 86 permitted</param>
		/// <param name="m3_OK87">Option 87 permitted</param>
		/// <param name="m3_OK88">Option 88 permitted</param>
		/// <param name="m3_OK89">Option 89 permitted</param>
		/// <param name="m3_OK90">Option 90 permitted</param>
		/// <param name="m3_OK91">Option 91 permitted</param>
		/// <param name="m3_OK92">Option 92 permitted</param>
		/// <param name="m3_OK93">Option 93 permitted</param>
		/// <param name="m3_OK94">Option 94 permitted</param>
		/// <param name="m3_OK95">Option 95 permitted</param>
		/// <param name="m3_OK96">Option 96 permitted</param>
		/// <param name="m3_OK97">Option 97 permitted</param>
		/// <param name="m3_OK98">Option 98 permitted</param>
		/// <param name="m3_OK99">Option 99 permitted</param>
		/// <param name="m3_KK01">Function key F1 permitted</param>
		/// <param name="m3_KK02">Function key F2 permitted</param>
		/// <param name="m3_KK03">Function key F3 permitted</param>
		/// <param name="m3_KK04">Function key F4 permitted</param>
		/// <param name="m3_KK05">Function key F5 permitted</param>
		/// <param name="m3_KK06">Function key F6 permitted</param>
		/// <param name="m3_KK07">Function key F7 permitted</param>
		/// <param name="m3_KK08">Function key F8 permitted</param>
		/// <param name="m3_KK09">Function key F9 permitted</param>
		/// <param name="m3_KK10">Function key F10 permitted</param>
		/// <param name="m3_KK11">Function key F11 permitted</param>
		/// <param name="m3_KK12">Function key F12 permitted</param>
		/// <param name="m3_KK13">Function key F13 permitted</param>
		/// <param name="m3_KK14">Function key F14 permitted</param>
		/// <param name="m3_KK15">Function key F15 permitted</param>
		/// <param name="m3_KK16">Function key F16 permitted</param>
		/// <param name="m3_KK17">Function key F17 permitted</param>
		/// <param name="m3_KK18">Function key F18 permitted</param>
		/// <param name="m3_KK19">Function key F19 permitted</param>
		/// <param name="m3_KK20">Function key F20 permitted</param>
		/// <param name="m3_KK21">Function key F21 permitted</param>
		/// <param name="m3_KK22">Function key F22 permitted</param>
		/// <param name="m3_KK23">Function key F23 permitted</param>
		/// <param name="m3_KK24">Function key F24 permitted</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3_FNID, 
			string m3_ROLL, 
			int m3_CONO, 
			string m3_STAT, 
			string m3_DIVI = null, 
			int? m3_AL01 = null, 
			int? m3_AL02 = null, 
			int? m3_AL03 = null, 
			int? m3_AL04 = null, 
			int? m3_AL05 = null, 
			int? m3_AL06 = null, 
			int? m3_AL07 = null, 
			int? m3_AL08 = null, 
			int? m3_AL09 = null, 
			int? m3_OK10 = null, 
			int? m3_OK11 = null, 
			int? m3_OK12 = null, 
			int? m3_OK13 = null, 
			int? m3_OK14 = null, 
			int? m3_OK15 = null, 
			int? m3_OK16 = null, 
			int? m3_OK17 = null, 
			int? m3_OK18 = null, 
			int? m3_OK19 = null, 
			int? m3_OK20 = null, 
			int? m3_OK21 = null, 
			int? m3_OK22 = null, 
			int? m3_OK23 = null, 
			int? m3_OK24 = null, 
			int? m3_OK25 = null, 
			int? m3_OK26 = null, 
			int? m3_OK27 = null, 
			int? m3_OK28 = null, 
			int? m3_OK29 = null, 
			int? m3_OK30 = null, 
			int? m3_OK31 = null, 
			int? m3_OK32 = null, 
			int? m3_OK33 = null, 
			int? m3_OK34 = null, 
			int? m3_OK35 = null, 
			int? m3_OK36 = null, 
			int? m3_OK37 = null, 
			int? m3_OK38 = null, 
			int? m3_OK39 = null, 
			int? m3_OK40 = null, 
			int? m3_OK41 = null, 
			int? m3_OK42 = null, 
			int? m3_OK43 = null, 
			int? m3_OK44 = null, 
			int? m3_OK45 = null, 
			int? m3_OK46 = null, 
			int? m3_OK47 = null, 
			int? m3_OK48 = null, 
			int? m3_OK49 = null, 
			int? m3_OK50 = null, 
			int? m3_OK51 = null, 
			int? m3_OK52 = null, 
			int? m3_OK53 = null, 
			int? m3_OK54 = null, 
			int? m3_OK55 = null, 
			int? m3_OK56 = null, 
			int? m3_OK57 = null, 
			int? m3_OK58 = null, 
			int? m3_OK59 = null, 
			int? m3_OK60 = null, 
			int? m3_OK61 = null, 
			int? m3_OK62 = null, 
			int? m3_OK63 = null, 
			int? m3_OK64 = null, 
			int? m3_OK65 = null, 
			int? m3_OK66 = null, 
			int? m3_OK67 = null, 
			int? m3_OK68 = null, 
			int? m3_OK69 = null, 
			int? m3_OK70 = null, 
			int? m3_OK71 = null, 
			int? m3_OK72 = null, 
			int? m3_OK73 = null, 
			int? m3_OK74 = null, 
			int? m3_OK75 = null, 
			int? m3_OK76 = null, 
			int? m3_OK77 = null, 
			int? m3_OK78 = null, 
			int? m3_OK79 = null, 
			int? m3_OK80 = null, 
			int? m3_OK81 = null, 
			int? m3_OK82 = null, 
			int? m3_OK83 = null, 
			int? m3_OK84 = null, 
			int? m3_OK85 = null, 
			int? m3_OK86 = null, 
			int? m3_OK87 = null, 
			int? m3_OK88 = null, 
			int? m3_OK89 = null, 
			int? m3_OK90 = null, 
			int? m3_OK91 = null, 
			int? m3_OK92 = null, 
			int? m3_OK93 = null, 
			int? m3_OK94 = null, 
			int? m3_OK95 = null, 
			int? m3_OK96 = null, 
			int? m3_OK97 = null, 
			int? m3_OK98 = null, 
			int? m3_OK99 = null, 
			int? m3_KK01 = null, 
			int? m3_KK02 = null, 
			int? m3_KK03 = null, 
			int? m3_KK04 = null, 
			int? m3_KK05 = null, 
			int? m3_KK06 = null, 
			int? m3_KK07 = null, 
			int? m3_KK08 = null, 
			int? m3_KK09 = null, 
			int? m3_KK10 = null, 
			int? m3_KK11 = null, 
			int? m3_KK12 = null, 
			int? m3_KK13 = null, 
			int? m3_KK14 = null, 
			int? m3_KK15 = null, 
			int? m3_KK16 = null, 
			int? m3_KK17 = null, 
			int? m3_KK18 = null, 
			int? m3_KK19 = null, 
			int? m3_KK20 = null, 
			int? m3_KK21 = null, 
			int? m3_KK22 = null, 
			int? m3_KK23 = null, 
			int? m3_KK24 = null, 
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

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FNID))
				throw new ArgumentNullException("m3_FNID");
			if (string.IsNullOrWhiteSpace(m3_ROLL))
				throw new ArgumentNullException("m3_ROLL");
			if (string.IsNullOrWhiteSpace(m3_STAT))
				throw new ArgumentNullException("m3_STAT");

			// Set mandatory parameters
			request
				.WithQueryParameter("FNID", m3_FNID.Trim())
				.WithQueryParameter("ROLL", m3_ROLL.Trim())
				.WithQueryParameter("CONO", m3_CONO.ToString())
				.WithQueryParameter("STAT", m3_STAT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (m3_AL01.HasValue)
				request.WithQueryParameter("AL01", m3_AL01.Value.ToString());
			if (m3_AL02.HasValue)
				request.WithQueryParameter("AL02", m3_AL02.Value.ToString());
			if (m3_AL03.HasValue)
				request.WithQueryParameter("AL03", m3_AL03.Value.ToString());
			if (m3_AL04.HasValue)
				request.WithQueryParameter("AL04", m3_AL04.Value.ToString());
			if (m3_AL05.HasValue)
				request.WithQueryParameter("AL05", m3_AL05.Value.ToString());
			if (m3_AL06.HasValue)
				request.WithQueryParameter("AL06", m3_AL06.Value.ToString());
			if (m3_AL07.HasValue)
				request.WithQueryParameter("AL07", m3_AL07.Value.ToString());
			if (m3_AL08.HasValue)
				request.WithQueryParameter("AL08", m3_AL08.Value.ToString());
			if (m3_AL09.HasValue)
				request.WithQueryParameter("AL09", m3_AL09.Value.ToString());
			if (m3_OK10.HasValue)
				request.WithQueryParameter("OK10", m3_OK10.Value.ToString());
			if (m3_OK11.HasValue)
				request.WithQueryParameter("OK11", m3_OK11.Value.ToString());
			if (m3_OK12.HasValue)
				request.WithQueryParameter("OK12", m3_OK12.Value.ToString());
			if (m3_OK13.HasValue)
				request.WithQueryParameter("OK13", m3_OK13.Value.ToString());
			if (m3_OK14.HasValue)
				request.WithQueryParameter("OK14", m3_OK14.Value.ToString());
			if (m3_OK15.HasValue)
				request.WithQueryParameter("OK15", m3_OK15.Value.ToString());
			if (m3_OK16.HasValue)
				request.WithQueryParameter("OK16", m3_OK16.Value.ToString());
			if (m3_OK17.HasValue)
				request.WithQueryParameter("OK17", m3_OK17.Value.ToString());
			if (m3_OK18.HasValue)
				request.WithQueryParameter("OK18", m3_OK18.Value.ToString());
			if (m3_OK19.HasValue)
				request.WithQueryParameter("OK19", m3_OK19.Value.ToString());
			if (m3_OK20.HasValue)
				request.WithQueryParameter("OK20", m3_OK20.Value.ToString());
			if (m3_OK21.HasValue)
				request.WithQueryParameter("OK21", m3_OK21.Value.ToString());
			if (m3_OK22.HasValue)
				request.WithQueryParameter("OK22", m3_OK22.Value.ToString());
			if (m3_OK23.HasValue)
				request.WithQueryParameter("OK23", m3_OK23.Value.ToString());
			if (m3_OK24.HasValue)
				request.WithQueryParameter("OK24", m3_OK24.Value.ToString());
			if (m3_OK25.HasValue)
				request.WithQueryParameter("OK25", m3_OK25.Value.ToString());
			if (m3_OK26.HasValue)
				request.WithQueryParameter("OK26", m3_OK26.Value.ToString());
			if (m3_OK27.HasValue)
				request.WithQueryParameter("OK27", m3_OK27.Value.ToString());
			if (m3_OK28.HasValue)
				request.WithQueryParameter("OK28", m3_OK28.Value.ToString());
			if (m3_OK29.HasValue)
				request.WithQueryParameter("OK29", m3_OK29.Value.ToString());
			if (m3_OK30.HasValue)
				request.WithQueryParameter("OK30", m3_OK30.Value.ToString());
			if (m3_OK31.HasValue)
				request.WithQueryParameter("OK31", m3_OK31.Value.ToString());
			if (m3_OK32.HasValue)
				request.WithQueryParameter("OK32", m3_OK32.Value.ToString());
			if (m3_OK33.HasValue)
				request.WithQueryParameter("OK33", m3_OK33.Value.ToString());
			if (m3_OK34.HasValue)
				request.WithQueryParameter("OK34", m3_OK34.Value.ToString());
			if (m3_OK35.HasValue)
				request.WithQueryParameter("OK35", m3_OK35.Value.ToString());
			if (m3_OK36.HasValue)
				request.WithQueryParameter("OK36", m3_OK36.Value.ToString());
			if (m3_OK37.HasValue)
				request.WithQueryParameter("OK37", m3_OK37.Value.ToString());
			if (m3_OK38.HasValue)
				request.WithQueryParameter("OK38", m3_OK38.Value.ToString());
			if (m3_OK39.HasValue)
				request.WithQueryParameter("OK39", m3_OK39.Value.ToString());
			if (m3_OK40.HasValue)
				request.WithQueryParameter("OK40", m3_OK40.Value.ToString());
			if (m3_OK41.HasValue)
				request.WithQueryParameter("OK41", m3_OK41.Value.ToString());
			if (m3_OK42.HasValue)
				request.WithQueryParameter("OK42", m3_OK42.Value.ToString());
			if (m3_OK43.HasValue)
				request.WithQueryParameter("OK43", m3_OK43.Value.ToString());
			if (m3_OK44.HasValue)
				request.WithQueryParameter("OK44", m3_OK44.Value.ToString());
			if (m3_OK45.HasValue)
				request.WithQueryParameter("OK45", m3_OK45.Value.ToString());
			if (m3_OK46.HasValue)
				request.WithQueryParameter("OK46", m3_OK46.Value.ToString());
			if (m3_OK47.HasValue)
				request.WithQueryParameter("OK47", m3_OK47.Value.ToString());
			if (m3_OK48.HasValue)
				request.WithQueryParameter("OK48", m3_OK48.Value.ToString());
			if (m3_OK49.HasValue)
				request.WithQueryParameter("OK49", m3_OK49.Value.ToString());
			if (m3_OK50.HasValue)
				request.WithQueryParameter("OK50", m3_OK50.Value.ToString());
			if (m3_OK51.HasValue)
				request.WithQueryParameter("OK51", m3_OK51.Value.ToString());
			if (m3_OK52.HasValue)
				request.WithQueryParameter("OK52", m3_OK52.Value.ToString());
			if (m3_OK53.HasValue)
				request.WithQueryParameter("OK53", m3_OK53.Value.ToString());
			if (m3_OK54.HasValue)
				request.WithQueryParameter("OK54", m3_OK54.Value.ToString());
			if (m3_OK55.HasValue)
				request.WithQueryParameter("OK55", m3_OK55.Value.ToString());
			if (m3_OK56.HasValue)
				request.WithQueryParameter("OK56", m3_OK56.Value.ToString());
			if (m3_OK57.HasValue)
				request.WithQueryParameter("OK57", m3_OK57.Value.ToString());
			if (m3_OK58.HasValue)
				request.WithQueryParameter("OK58", m3_OK58.Value.ToString());
			if (m3_OK59.HasValue)
				request.WithQueryParameter("OK59", m3_OK59.Value.ToString());
			if (m3_OK60.HasValue)
				request.WithQueryParameter("OK60", m3_OK60.Value.ToString());
			if (m3_OK61.HasValue)
				request.WithQueryParameter("OK61", m3_OK61.Value.ToString());
			if (m3_OK62.HasValue)
				request.WithQueryParameter("OK62", m3_OK62.Value.ToString());
			if (m3_OK63.HasValue)
				request.WithQueryParameter("OK63", m3_OK63.Value.ToString());
			if (m3_OK64.HasValue)
				request.WithQueryParameter("OK64", m3_OK64.Value.ToString());
			if (m3_OK65.HasValue)
				request.WithQueryParameter("OK65", m3_OK65.Value.ToString());
			if (m3_OK66.HasValue)
				request.WithQueryParameter("OK66", m3_OK66.Value.ToString());
			if (m3_OK67.HasValue)
				request.WithQueryParameter("OK67", m3_OK67.Value.ToString());
			if (m3_OK68.HasValue)
				request.WithQueryParameter("OK68", m3_OK68.Value.ToString());
			if (m3_OK69.HasValue)
				request.WithQueryParameter("OK69", m3_OK69.Value.ToString());
			if (m3_OK70.HasValue)
				request.WithQueryParameter("OK70", m3_OK70.Value.ToString());
			if (m3_OK71.HasValue)
				request.WithQueryParameter("OK71", m3_OK71.Value.ToString());
			if (m3_OK72.HasValue)
				request.WithQueryParameter("OK72", m3_OK72.Value.ToString());
			if (m3_OK73.HasValue)
				request.WithQueryParameter("OK73", m3_OK73.Value.ToString());
			if (m3_OK74.HasValue)
				request.WithQueryParameter("OK74", m3_OK74.Value.ToString());
			if (m3_OK75.HasValue)
				request.WithQueryParameter("OK75", m3_OK75.Value.ToString());
			if (m3_OK76.HasValue)
				request.WithQueryParameter("OK76", m3_OK76.Value.ToString());
			if (m3_OK77.HasValue)
				request.WithQueryParameter("OK77", m3_OK77.Value.ToString());
			if (m3_OK78.HasValue)
				request.WithQueryParameter("OK78", m3_OK78.Value.ToString());
			if (m3_OK79.HasValue)
				request.WithQueryParameter("OK79", m3_OK79.Value.ToString());
			if (m3_OK80.HasValue)
				request.WithQueryParameter("OK80", m3_OK80.Value.ToString());
			if (m3_OK81.HasValue)
				request.WithQueryParameter("OK81", m3_OK81.Value.ToString());
			if (m3_OK82.HasValue)
				request.WithQueryParameter("OK82", m3_OK82.Value.ToString());
			if (m3_OK83.HasValue)
				request.WithQueryParameter("OK83", m3_OK83.Value.ToString());
			if (m3_OK84.HasValue)
				request.WithQueryParameter("OK84", m3_OK84.Value.ToString());
			if (m3_OK85.HasValue)
				request.WithQueryParameter("OK85", m3_OK85.Value.ToString());
			if (m3_OK86.HasValue)
				request.WithQueryParameter("OK86", m3_OK86.Value.ToString());
			if (m3_OK87.HasValue)
				request.WithQueryParameter("OK87", m3_OK87.Value.ToString());
			if (m3_OK88.HasValue)
				request.WithQueryParameter("OK88", m3_OK88.Value.ToString());
			if (m3_OK89.HasValue)
				request.WithQueryParameter("OK89", m3_OK89.Value.ToString());
			if (m3_OK90.HasValue)
				request.WithQueryParameter("OK90", m3_OK90.Value.ToString());
			if (m3_OK91.HasValue)
				request.WithQueryParameter("OK91", m3_OK91.Value.ToString());
			if (m3_OK92.HasValue)
				request.WithQueryParameter("OK92", m3_OK92.Value.ToString());
			if (m3_OK93.HasValue)
				request.WithQueryParameter("OK93", m3_OK93.Value.ToString());
			if (m3_OK94.HasValue)
				request.WithQueryParameter("OK94", m3_OK94.Value.ToString());
			if (m3_OK95.HasValue)
				request.WithQueryParameter("OK95", m3_OK95.Value.ToString());
			if (m3_OK96.HasValue)
				request.WithQueryParameter("OK96", m3_OK96.Value.ToString());
			if (m3_OK97.HasValue)
				request.WithQueryParameter("OK97", m3_OK97.Value.ToString());
			if (m3_OK98.HasValue)
				request.WithQueryParameter("OK98", m3_OK98.Value.ToString());
			if (m3_OK99.HasValue)
				request.WithQueryParameter("OK99", m3_OK99.Value.ToString());
			if (m3_KK01.HasValue)
				request.WithQueryParameter("KK01", m3_KK01.Value.ToString());
			if (m3_KK02.HasValue)
				request.WithQueryParameter("KK02", m3_KK02.Value.ToString());
			if (m3_KK03.HasValue)
				request.WithQueryParameter("KK03", m3_KK03.Value.ToString());
			if (m3_KK04.HasValue)
				request.WithQueryParameter("KK04", m3_KK04.Value.ToString());
			if (m3_KK05.HasValue)
				request.WithQueryParameter("KK05", m3_KK05.Value.ToString());
			if (m3_KK06.HasValue)
				request.WithQueryParameter("KK06", m3_KK06.Value.ToString());
			if (m3_KK07.HasValue)
				request.WithQueryParameter("KK07", m3_KK07.Value.ToString());
			if (m3_KK08.HasValue)
				request.WithQueryParameter("KK08", m3_KK08.Value.ToString());
			if (m3_KK09.HasValue)
				request.WithQueryParameter("KK09", m3_KK09.Value.ToString());
			if (m3_KK10.HasValue)
				request.WithQueryParameter("KK10", m3_KK10.Value.ToString());
			if (m3_KK11.HasValue)
				request.WithQueryParameter("KK11", m3_KK11.Value.ToString());
			if (m3_KK12.HasValue)
				request.WithQueryParameter("KK12", m3_KK12.Value.ToString());
			if (m3_KK13.HasValue)
				request.WithQueryParameter("KK13", m3_KK13.Value.ToString());
			if (m3_KK14.HasValue)
				request.WithQueryParameter("KK14", m3_KK14.Value.ToString());
			if (m3_KK15.HasValue)
				request.WithQueryParameter("KK15", m3_KK15.Value.ToString());
			if (m3_KK16.HasValue)
				request.WithQueryParameter("KK16", m3_KK16.Value.ToString());
			if (m3_KK17.HasValue)
				request.WithQueryParameter("KK17", m3_KK17.Value.ToString());
			if (m3_KK18.HasValue)
				request.WithQueryParameter("KK18", m3_KK18.Value.ToString());
			if (m3_KK19.HasValue)
				request.WithQueryParameter("KK19", m3_KK19.Value.ToString());
			if (m3_KK20.HasValue)
				request.WithQueryParameter("KK20", m3_KK20.Value.ToString());
			if (m3_KK21.HasValue)
				request.WithQueryParameter("KK21", m3_KK21.Value.ToString());
			if (m3_KK22.HasValue)
				request.WithQueryParameter("KK22", m3_KK22.Value.ToString());
			if (m3_KK23.HasValue)
				request.WithQueryParameter("KK23", m3_KK23.Value.ToString());
			if (m3_KK24.HasValue)
				request.WithQueryParameter("KK24", m3_KK24.Value.ToString());

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
		/// Name Dlt
		/// Description Dlt
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FNID">Function (Required)</param>
		/// <param name="m3_ROLL">Role (Required)</param>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Dlt(
			string m3_FNID, 
			string m3_ROLL, 
			int m3_CONO, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Dlt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FNID))
				throw new ArgumentNullException("m3_FNID");
			if (string.IsNullOrWhiteSpace(m3_ROLL))
				throw new ArgumentNullException("m3_ROLL");

			// Set mandatory parameters
			request
				.WithQueryParameter("FNID", m3_FNID.Trim())
				.WithQueryParameter("ROLL", m3_ROLL.Trim())
				.WithQueryParameter("CONO", m3_CONO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

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
		/// Name Get
		/// Description Get
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FNID">Function (Required)</param>
		/// <param name="m3_ROLL">Role (Required)</param>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3_FNID, 
			string m3_ROLL, 
			int m3_CONO, 
			string m3_DIVI = null, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/Get",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FNID))
				throw new ArgumentNullException("m3_FNID");
			if (string.IsNullOrWhiteSpace(m3_ROLL))
				throw new ArgumentNullException("m3_ROLL");

			// Set mandatory parameters
			request
				.WithQueryParameter("FNID", m3_FNID.Trim())
				.WithQueryParameter("ROLL", m3_ROLL.Trim())
				.WithQueryParameter("CONO", m3_CONO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Description Lst
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3_FNID">Function (Required)</param>
		/// <param name="m3_ROLL">Role (Required)</param>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			string m3_FNID, 
			string m3_ROLL, 
			int m3_CONO, 
			string m3_DIVI = null, 
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

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FNID))
				throw new ArgumentNullException("m3_FNID");
			if (string.IsNullOrWhiteSpace(m3_ROLL))
				throw new ArgumentNullException("m3_ROLL");

			// Set mandatory parameters
			request
				.WithQueryParameter("FNID", m3_FNID.Trim())
				.WithQueryParameter("ROLL", m3_ROLL.Trim())
				.WithQueryParameter("CONO", m3_CONO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());

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
		/// Name LstAuthByRole
		/// Description List Authority By Role
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3_ROLL">Role (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAuthByRoleResponse></returns>
		/// <exception cref="M3Exception<LstAuthByRoleResponse>"></exception>
		public async Task<M3Response<LstAuthByRoleResponse>> LstAuthByRole(
			string m3_ROLL, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/LstAuthByRole",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_ROLL))
				throw new ArgumentNullException("m3_ROLL");

			// Set mandatory parameters
			request
				.WithQueryParameter("ROLL", m3_ROLL.Trim());

			// Execute the request
			var result = await Execute<LstAuthByRoleResponse>(
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
		/// Description Upd
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3_FNID">Function (Required)</param>
		/// <param name="m3_ROLL">Role (Required)</param>
		/// <param name="m3_CONO">Company (Required)</param>
		/// <param name="m3_DIVI">Division</param>
		/// <param name="m3_STAT">Status</param>
		/// <param name="m3_AL01">Option 1 permitted</param>
		/// <param name="m3_AL02">Option 2 permitted</param>
		/// <param name="m3_AL03">Option 3 permitted</param>
		/// <param name="m3_AL04">Option 4 permitted</param>
		/// <param name="m3_AL05">Option 5 permitted</param>
		/// <param name="m3_AL06">Option 6 permitted</param>
		/// <param name="m3_AL07">Option 7 permitted</param>
		/// <param name="m3_AL08">Option 8 permitted</param>
		/// <param name="m3_AL09">Option 9 permitted</param>
		/// <param name="m3_OK10">Option 10 permitted</param>
		/// <param name="m3_OK11">Option 11 permitted</param>
		/// <param name="m3_OK12">Option 12 permitted</param>
		/// <param name="m3_OK13">Option 13 permitted</param>
		/// <param name="m3_OK14">Option 14 permitted</param>
		/// <param name="m3_OK15">Option 15 permitted</param>
		/// <param name="m3_OK16">Option 16 permitted</param>
		/// <param name="m3_OK17">Option 17 permitted</param>
		/// <param name="m3_OK18">Option 18 permitted</param>
		/// <param name="m3_OK19">Option 19 permitted</param>
		/// <param name="m3_OK20">Option 20 permitted</param>
		/// <param name="m3_OK21">Option 21 permitted</param>
		/// <param name="m3_OK22">Option 22 permitted</param>
		/// <param name="m3_OK23">Option 23 permitted</param>
		/// <param name="m3_OK24">Option 24 permitted</param>
		/// <param name="m3_OK25">Option 25 permitted</param>
		/// <param name="m3_OK26">Option 26 permitted</param>
		/// <param name="m3_OK27">Option 27 permitted</param>
		/// <param name="m3_OK28">Option 28 permitted</param>
		/// <param name="m3_OK29">Option 29 permitted</param>
		/// <param name="m3_OK30">Option 30 permitted</param>
		/// <param name="m3_OK31">Option 31 permitted</param>
		/// <param name="m3_OK32">Option 32 permitted</param>
		/// <param name="m3_OK33">Option 33 permitted</param>
		/// <param name="m3_OK34">Option 34 permitted</param>
		/// <param name="m3_OK35">Option 35 permitted</param>
		/// <param name="m3_OK36">Option 36 permitted</param>
		/// <param name="m3_OK37">Option 37 permitted</param>
		/// <param name="m3_OK38">Option 38 permitted</param>
		/// <param name="m3_OK39">Option 39 permitted</param>
		/// <param name="m3_OK40">Option 40 permitted</param>
		/// <param name="m3_OK41">Option 41 permitted</param>
		/// <param name="m3_OK42">Option 42 permitted</param>
		/// <param name="m3_OK43">Option 43 permitted</param>
		/// <param name="m3_OK44">Option 44 permitted</param>
		/// <param name="m3_OK45">Option 45 permitted</param>
		/// <param name="m3_OK46">Option 46 permitted</param>
		/// <param name="m3_OK47">Option 47 permitted</param>
		/// <param name="m3_OK48">Option 48 permitted</param>
		/// <param name="m3_OK49">Option 49 permitted</param>
		/// <param name="m3_OK50">Option 50 permitted</param>
		/// <param name="m3_OK51">Option 51 permitted</param>
		/// <param name="m3_OK52">Option 52 permitted</param>
		/// <param name="m3_OK53">Option 53 permitted</param>
		/// <param name="m3_OK54">Option 54 permitted</param>
		/// <param name="m3_OK55">Option 55 permitted</param>
		/// <param name="m3_OK56">Option 56 permitted</param>
		/// <param name="m3_OK57">Option 57 permitted</param>
		/// <param name="m3_OK58">Option 58 permitted</param>
		/// <param name="m3_OK59">Option 59 permitted</param>
		/// <param name="m3_OK60">Option 60 permitted</param>
		/// <param name="m3_OK61">Option 61 permitted</param>
		/// <param name="m3_OK62">Option 62 permitted</param>
		/// <param name="m3_OK63">Option 63 permitted</param>
		/// <param name="m3_OK64">Option 64 permitted</param>
		/// <param name="m3_OK65">Option 65 permitted</param>
		/// <param name="m3_OK66">Option 66 permitted</param>
		/// <param name="m3_OK67">Option 67 permitted</param>
		/// <param name="m3_OK68">Option 68 permitted</param>
		/// <param name="m3_OK69">Option 69 permitted</param>
		/// <param name="m3_OK70">Option 70 permitted</param>
		/// <param name="m3_OK71">Option 71 permitted</param>
		/// <param name="m3_OK72">Option 72 permitted</param>
		/// <param name="m3_OK73">Option 73 permitted</param>
		/// <param name="m3_OK74">Option 74 permitted</param>
		/// <param name="m3_OK75">Option 75 permitted</param>
		/// <param name="m3_OK76">Option 76 permitted</param>
		/// <param name="m3_OK77">Option 77 permitted</param>
		/// <param name="m3_OK78">Option 78 permitted</param>
		/// <param name="m3_OK79">Option 79 permitted</param>
		/// <param name="m3_OK80">Option 80 permitted</param>
		/// <param name="m3_OK81">Option 81 permitted</param>
		/// <param name="m3_OK82">Option 82 permitted</param>
		/// <param name="m3_OK83">Option 83 permitted</param>
		/// <param name="m3_OK84">Option 84 permitted</param>
		/// <param name="m3_OK85">Option 85 permitted</param>
		/// <param name="m3_OK86">Option 86 permitted</param>
		/// <param name="m3_OK87">Option 87 permitted</param>
		/// <param name="m3_OK88">Option 88 permitted</param>
		/// <param name="m3_OK89">Option 89 permitted</param>
		/// <param name="m3_OK90">Option 90 permitted</param>
		/// <param name="m3_OK91">Option 91 permitted</param>
		/// <param name="m3_OK92">Option 92 permitted</param>
		/// <param name="m3_OK93">Option 93 permitted</param>
		/// <param name="m3_OK94">Option 94 permitted</param>
		/// <param name="m3_OK95">Option 95 permitted</param>
		/// <param name="m3_OK96">Option 96 permitted</param>
		/// <param name="m3_OK97">Option 97 permitted</param>
		/// <param name="m3_OK98">Option 98 permitted</param>
		/// <param name="m3_OK99">Option 99 permitted</param>
		/// <param name="m3_KK01">Function key F1 permitted</param>
		/// <param name="m3_KK02">Function key F2 permitted</param>
		/// <param name="m3_KK03">Function key F3 permitted</param>
		/// <param name="m3_KK04">Function key F4 permitted</param>
		/// <param name="m3_KK05">Function key F5 permitted</param>
		/// <param name="m3_KK06">Function key F6 permitted</param>
		/// <param name="m3_KK07">Function key F7 permitted</param>
		/// <param name="m3_KK08">Function key F8 permitted</param>
		/// <param name="m3_KK09">Function key F9 permitted</param>
		/// <param name="m3_KK10">Function key F10 permitted</param>
		/// <param name="m3_KK11">Function key F11 permitted</param>
		/// <param name="m3_KK12">Function key F12 permitted</param>
		/// <param name="m3_KK13">Function key F13 permitted</param>
		/// <param name="m3_KK14">Function key F14 permitted</param>
		/// <param name="m3_KK15">Function key F15 permitted</param>
		/// <param name="m3_KK16">Function key F16 permitted</param>
		/// <param name="m3_KK17">Function key F17 permitted</param>
		/// <param name="m3_KK18">Function key F18 permitted</param>
		/// <param name="m3_KK19">Function key F19 permitted</param>
		/// <param name="m3_KK20">Function key F20 permitted</param>
		/// <param name="m3_KK21">Function key F21 permitted</param>
		/// <param name="m3_KK22">Function key F22 permitted</param>
		/// <param name="m3_KK23">Function key F23 permitted</param>
		/// <param name="m3_KK24">Function key F24 permitted</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3_FNID, 
			string m3_ROLL, 
			int m3_CONO, 
			string m3_DIVI = null, 
			string m3_STAT = null, 
			int? m3_AL01 = null, 
			int? m3_AL02 = null, 
			int? m3_AL03 = null, 
			int? m3_AL04 = null, 
			int? m3_AL05 = null, 
			int? m3_AL06 = null, 
			int? m3_AL07 = null, 
			int? m3_AL08 = null, 
			int? m3_AL09 = null, 
			int? m3_OK10 = null, 
			int? m3_OK11 = null, 
			int? m3_OK12 = null, 
			int? m3_OK13 = null, 
			int? m3_OK14 = null, 
			int? m3_OK15 = null, 
			int? m3_OK16 = null, 
			int? m3_OK17 = null, 
			int? m3_OK18 = null, 
			int? m3_OK19 = null, 
			int? m3_OK20 = null, 
			int? m3_OK21 = null, 
			int? m3_OK22 = null, 
			int? m3_OK23 = null, 
			int? m3_OK24 = null, 
			int? m3_OK25 = null, 
			int? m3_OK26 = null, 
			int? m3_OK27 = null, 
			int? m3_OK28 = null, 
			int? m3_OK29 = null, 
			int? m3_OK30 = null, 
			int? m3_OK31 = null, 
			int? m3_OK32 = null, 
			int? m3_OK33 = null, 
			int? m3_OK34 = null, 
			int? m3_OK35 = null, 
			int? m3_OK36 = null, 
			int? m3_OK37 = null, 
			int? m3_OK38 = null, 
			int? m3_OK39 = null, 
			int? m3_OK40 = null, 
			int? m3_OK41 = null, 
			int? m3_OK42 = null, 
			int? m3_OK43 = null, 
			int? m3_OK44 = null, 
			int? m3_OK45 = null, 
			int? m3_OK46 = null, 
			int? m3_OK47 = null, 
			int? m3_OK48 = null, 
			int? m3_OK49 = null, 
			int? m3_OK50 = null, 
			int? m3_OK51 = null, 
			int? m3_OK52 = null, 
			int? m3_OK53 = null, 
			int? m3_OK54 = null, 
			int? m3_OK55 = null, 
			int? m3_OK56 = null, 
			int? m3_OK57 = null, 
			int? m3_OK58 = null, 
			int? m3_OK59 = null, 
			int? m3_OK60 = null, 
			int? m3_OK61 = null, 
			int? m3_OK62 = null, 
			int? m3_OK63 = null, 
			int? m3_OK64 = null, 
			int? m3_OK65 = null, 
			int? m3_OK66 = null, 
			int? m3_OK67 = null, 
			int? m3_OK68 = null, 
			int? m3_OK69 = null, 
			int? m3_OK70 = null, 
			int? m3_OK71 = null, 
			int? m3_OK72 = null, 
			int? m3_OK73 = null, 
			int? m3_OK74 = null, 
			int? m3_OK75 = null, 
			int? m3_OK76 = null, 
			int? m3_OK77 = null, 
			int? m3_OK78 = null, 
			int? m3_OK79 = null, 
			int? m3_OK80 = null, 
			int? m3_OK81 = null, 
			int? m3_OK82 = null, 
			int? m3_OK83 = null, 
			int? m3_OK84 = null, 
			int? m3_OK85 = null, 
			int? m3_OK86 = null, 
			int? m3_OK87 = null, 
			int? m3_OK88 = null, 
			int? m3_OK89 = null, 
			int? m3_OK90 = null, 
			int? m3_OK91 = null, 
			int? m3_OK92 = null, 
			int? m3_OK93 = null, 
			int? m3_OK94 = null, 
			int? m3_OK95 = null, 
			int? m3_OK96 = null, 
			int? m3_OK97 = null, 
			int? m3_OK98 = null, 
			int? m3_OK99 = null, 
			int? m3_KK01 = null, 
			int? m3_KK02 = null, 
			int? m3_KK03 = null, 
			int? m3_KK04 = null, 
			int? m3_KK05 = null, 
			int? m3_KK06 = null, 
			int? m3_KK07 = null, 
			int? m3_KK08 = null, 
			int? m3_KK09 = null, 
			int? m3_KK10 = null, 
			int? m3_KK11 = null, 
			int? m3_KK12 = null, 
			int? m3_KK13 = null, 
			int? m3_KK14 = null, 
			int? m3_KK15 = null, 
			int? m3_KK16 = null, 
			int? m3_KK17 = null, 
			int? m3_KK18 = null, 
			int? m3_KK19 = null, 
			int? m3_KK20 = null, 
			int? m3_KK21 = null, 
			int? m3_KK22 = null, 
			int? m3_KK23 = null, 
			int? m3_KK24 = null, 
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

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_FNID))
				throw new ArgumentNullException("m3_FNID");
			if (string.IsNullOrWhiteSpace(m3_ROLL))
				throw new ArgumentNullException("m3_ROLL");

			// Set mandatory parameters
			request
				.WithQueryParameter("FNID", m3_FNID.Trim())
				.WithQueryParameter("ROLL", m3_ROLL.Trim())
				.WithQueryParameter("CONO", m3_CONO.ToString());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3_DIVI))
				request.WithQueryParameter("DIVI", m3_DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3_STAT))
				request.WithQueryParameter("STAT", m3_STAT.Trim());
			if (m3_AL01.HasValue)
				request.WithQueryParameter("AL01", m3_AL01.Value.ToString());
			if (m3_AL02.HasValue)
				request.WithQueryParameter("AL02", m3_AL02.Value.ToString());
			if (m3_AL03.HasValue)
				request.WithQueryParameter("AL03", m3_AL03.Value.ToString());
			if (m3_AL04.HasValue)
				request.WithQueryParameter("AL04", m3_AL04.Value.ToString());
			if (m3_AL05.HasValue)
				request.WithQueryParameter("AL05", m3_AL05.Value.ToString());
			if (m3_AL06.HasValue)
				request.WithQueryParameter("AL06", m3_AL06.Value.ToString());
			if (m3_AL07.HasValue)
				request.WithQueryParameter("AL07", m3_AL07.Value.ToString());
			if (m3_AL08.HasValue)
				request.WithQueryParameter("AL08", m3_AL08.Value.ToString());
			if (m3_AL09.HasValue)
				request.WithQueryParameter("AL09", m3_AL09.Value.ToString());
			if (m3_OK10.HasValue)
				request.WithQueryParameter("OK10", m3_OK10.Value.ToString());
			if (m3_OK11.HasValue)
				request.WithQueryParameter("OK11", m3_OK11.Value.ToString());
			if (m3_OK12.HasValue)
				request.WithQueryParameter("OK12", m3_OK12.Value.ToString());
			if (m3_OK13.HasValue)
				request.WithQueryParameter("OK13", m3_OK13.Value.ToString());
			if (m3_OK14.HasValue)
				request.WithQueryParameter("OK14", m3_OK14.Value.ToString());
			if (m3_OK15.HasValue)
				request.WithQueryParameter("OK15", m3_OK15.Value.ToString());
			if (m3_OK16.HasValue)
				request.WithQueryParameter("OK16", m3_OK16.Value.ToString());
			if (m3_OK17.HasValue)
				request.WithQueryParameter("OK17", m3_OK17.Value.ToString());
			if (m3_OK18.HasValue)
				request.WithQueryParameter("OK18", m3_OK18.Value.ToString());
			if (m3_OK19.HasValue)
				request.WithQueryParameter("OK19", m3_OK19.Value.ToString());
			if (m3_OK20.HasValue)
				request.WithQueryParameter("OK20", m3_OK20.Value.ToString());
			if (m3_OK21.HasValue)
				request.WithQueryParameter("OK21", m3_OK21.Value.ToString());
			if (m3_OK22.HasValue)
				request.WithQueryParameter("OK22", m3_OK22.Value.ToString());
			if (m3_OK23.HasValue)
				request.WithQueryParameter("OK23", m3_OK23.Value.ToString());
			if (m3_OK24.HasValue)
				request.WithQueryParameter("OK24", m3_OK24.Value.ToString());
			if (m3_OK25.HasValue)
				request.WithQueryParameter("OK25", m3_OK25.Value.ToString());
			if (m3_OK26.HasValue)
				request.WithQueryParameter("OK26", m3_OK26.Value.ToString());
			if (m3_OK27.HasValue)
				request.WithQueryParameter("OK27", m3_OK27.Value.ToString());
			if (m3_OK28.HasValue)
				request.WithQueryParameter("OK28", m3_OK28.Value.ToString());
			if (m3_OK29.HasValue)
				request.WithQueryParameter("OK29", m3_OK29.Value.ToString());
			if (m3_OK30.HasValue)
				request.WithQueryParameter("OK30", m3_OK30.Value.ToString());
			if (m3_OK31.HasValue)
				request.WithQueryParameter("OK31", m3_OK31.Value.ToString());
			if (m3_OK32.HasValue)
				request.WithQueryParameter("OK32", m3_OK32.Value.ToString());
			if (m3_OK33.HasValue)
				request.WithQueryParameter("OK33", m3_OK33.Value.ToString());
			if (m3_OK34.HasValue)
				request.WithQueryParameter("OK34", m3_OK34.Value.ToString());
			if (m3_OK35.HasValue)
				request.WithQueryParameter("OK35", m3_OK35.Value.ToString());
			if (m3_OK36.HasValue)
				request.WithQueryParameter("OK36", m3_OK36.Value.ToString());
			if (m3_OK37.HasValue)
				request.WithQueryParameter("OK37", m3_OK37.Value.ToString());
			if (m3_OK38.HasValue)
				request.WithQueryParameter("OK38", m3_OK38.Value.ToString());
			if (m3_OK39.HasValue)
				request.WithQueryParameter("OK39", m3_OK39.Value.ToString());
			if (m3_OK40.HasValue)
				request.WithQueryParameter("OK40", m3_OK40.Value.ToString());
			if (m3_OK41.HasValue)
				request.WithQueryParameter("OK41", m3_OK41.Value.ToString());
			if (m3_OK42.HasValue)
				request.WithQueryParameter("OK42", m3_OK42.Value.ToString());
			if (m3_OK43.HasValue)
				request.WithQueryParameter("OK43", m3_OK43.Value.ToString());
			if (m3_OK44.HasValue)
				request.WithQueryParameter("OK44", m3_OK44.Value.ToString());
			if (m3_OK45.HasValue)
				request.WithQueryParameter("OK45", m3_OK45.Value.ToString());
			if (m3_OK46.HasValue)
				request.WithQueryParameter("OK46", m3_OK46.Value.ToString());
			if (m3_OK47.HasValue)
				request.WithQueryParameter("OK47", m3_OK47.Value.ToString());
			if (m3_OK48.HasValue)
				request.WithQueryParameter("OK48", m3_OK48.Value.ToString());
			if (m3_OK49.HasValue)
				request.WithQueryParameter("OK49", m3_OK49.Value.ToString());
			if (m3_OK50.HasValue)
				request.WithQueryParameter("OK50", m3_OK50.Value.ToString());
			if (m3_OK51.HasValue)
				request.WithQueryParameter("OK51", m3_OK51.Value.ToString());
			if (m3_OK52.HasValue)
				request.WithQueryParameter("OK52", m3_OK52.Value.ToString());
			if (m3_OK53.HasValue)
				request.WithQueryParameter("OK53", m3_OK53.Value.ToString());
			if (m3_OK54.HasValue)
				request.WithQueryParameter("OK54", m3_OK54.Value.ToString());
			if (m3_OK55.HasValue)
				request.WithQueryParameter("OK55", m3_OK55.Value.ToString());
			if (m3_OK56.HasValue)
				request.WithQueryParameter("OK56", m3_OK56.Value.ToString());
			if (m3_OK57.HasValue)
				request.WithQueryParameter("OK57", m3_OK57.Value.ToString());
			if (m3_OK58.HasValue)
				request.WithQueryParameter("OK58", m3_OK58.Value.ToString());
			if (m3_OK59.HasValue)
				request.WithQueryParameter("OK59", m3_OK59.Value.ToString());
			if (m3_OK60.HasValue)
				request.WithQueryParameter("OK60", m3_OK60.Value.ToString());
			if (m3_OK61.HasValue)
				request.WithQueryParameter("OK61", m3_OK61.Value.ToString());
			if (m3_OK62.HasValue)
				request.WithQueryParameter("OK62", m3_OK62.Value.ToString());
			if (m3_OK63.HasValue)
				request.WithQueryParameter("OK63", m3_OK63.Value.ToString());
			if (m3_OK64.HasValue)
				request.WithQueryParameter("OK64", m3_OK64.Value.ToString());
			if (m3_OK65.HasValue)
				request.WithQueryParameter("OK65", m3_OK65.Value.ToString());
			if (m3_OK66.HasValue)
				request.WithQueryParameter("OK66", m3_OK66.Value.ToString());
			if (m3_OK67.HasValue)
				request.WithQueryParameter("OK67", m3_OK67.Value.ToString());
			if (m3_OK68.HasValue)
				request.WithQueryParameter("OK68", m3_OK68.Value.ToString());
			if (m3_OK69.HasValue)
				request.WithQueryParameter("OK69", m3_OK69.Value.ToString());
			if (m3_OK70.HasValue)
				request.WithQueryParameter("OK70", m3_OK70.Value.ToString());
			if (m3_OK71.HasValue)
				request.WithQueryParameter("OK71", m3_OK71.Value.ToString());
			if (m3_OK72.HasValue)
				request.WithQueryParameter("OK72", m3_OK72.Value.ToString());
			if (m3_OK73.HasValue)
				request.WithQueryParameter("OK73", m3_OK73.Value.ToString());
			if (m3_OK74.HasValue)
				request.WithQueryParameter("OK74", m3_OK74.Value.ToString());
			if (m3_OK75.HasValue)
				request.WithQueryParameter("OK75", m3_OK75.Value.ToString());
			if (m3_OK76.HasValue)
				request.WithQueryParameter("OK76", m3_OK76.Value.ToString());
			if (m3_OK77.HasValue)
				request.WithQueryParameter("OK77", m3_OK77.Value.ToString());
			if (m3_OK78.HasValue)
				request.WithQueryParameter("OK78", m3_OK78.Value.ToString());
			if (m3_OK79.HasValue)
				request.WithQueryParameter("OK79", m3_OK79.Value.ToString());
			if (m3_OK80.HasValue)
				request.WithQueryParameter("OK80", m3_OK80.Value.ToString());
			if (m3_OK81.HasValue)
				request.WithQueryParameter("OK81", m3_OK81.Value.ToString());
			if (m3_OK82.HasValue)
				request.WithQueryParameter("OK82", m3_OK82.Value.ToString());
			if (m3_OK83.HasValue)
				request.WithQueryParameter("OK83", m3_OK83.Value.ToString());
			if (m3_OK84.HasValue)
				request.WithQueryParameter("OK84", m3_OK84.Value.ToString());
			if (m3_OK85.HasValue)
				request.WithQueryParameter("OK85", m3_OK85.Value.ToString());
			if (m3_OK86.HasValue)
				request.WithQueryParameter("OK86", m3_OK86.Value.ToString());
			if (m3_OK87.HasValue)
				request.WithQueryParameter("OK87", m3_OK87.Value.ToString());
			if (m3_OK88.HasValue)
				request.WithQueryParameter("OK88", m3_OK88.Value.ToString());
			if (m3_OK89.HasValue)
				request.WithQueryParameter("OK89", m3_OK89.Value.ToString());
			if (m3_OK90.HasValue)
				request.WithQueryParameter("OK90", m3_OK90.Value.ToString());
			if (m3_OK91.HasValue)
				request.WithQueryParameter("OK91", m3_OK91.Value.ToString());
			if (m3_OK92.HasValue)
				request.WithQueryParameter("OK92", m3_OK92.Value.ToString());
			if (m3_OK93.HasValue)
				request.WithQueryParameter("OK93", m3_OK93.Value.ToString());
			if (m3_OK94.HasValue)
				request.WithQueryParameter("OK94", m3_OK94.Value.ToString());
			if (m3_OK95.HasValue)
				request.WithQueryParameter("OK95", m3_OK95.Value.ToString());
			if (m3_OK96.HasValue)
				request.WithQueryParameter("OK96", m3_OK96.Value.ToString());
			if (m3_OK97.HasValue)
				request.WithQueryParameter("OK97", m3_OK97.Value.ToString());
			if (m3_OK98.HasValue)
				request.WithQueryParameter("OK98", m3_OK98.Value.ToString());
			if (m3_OK99.HasValue)
				request.WithQueryParameter("OK99", m3_OK99.Value.ToString());
			if (m3_KK01.HasValue)
				request.WithQueryParameter("KK01", m3_KK01.Value.ToString());
			if (m3_KK02.HasValue)
				request.WithQueryParameter("KK02", m3_KK02.Value.ToString());
			if (m3_KK03.HasValue)
				request.WithQueryParameter("KK03", m3_KK03.Value.ToString());
			if (m3_KK04.HasValue)
				request.WithQueryParameter("KK04", m3_KK04.Value.ToString());
			if (m3_KK05.HasValue)
				request.WithQueryParameter("KK05", m3_KK05.Value.ToString());
			if (m3_KK06.HasValue)
				request.WithQueryParameter("KK06", m3_KK06.Value.ToString());
			if (m3_KK07.HasValue)
				request.WithQueryParameter("KK07", m3_KK07.Value.ToString());
			if (m3_KK08.HasValue)
				request.WithQueryParameter("KK08", m3_KK08.Value.ToString());
			if (m3_KK09.HasValue)
				request.WithQueryParameter("KK09", m3_KK09.Value.ToString());
			if (m3_KK10.HasValue)
				request.WithQueryParameter("KK10", m3_KK10.Value.ToString());
			if (m3_KK11.HasValue)
				request.WithQueryParameter("KK11", m3_KK11.Value.ToString());
			if (m3_KK12.HasValue)
				request.WithQueryParameter("KK12", m3_KK12.Value.ToString());
			if (m3_KK13.HasValue)
				request.WithQueryParameter("KK13", m3_KK13.Value.ToString());
			if (m3_KK14.HasValue)
				request.WithQueryParameter("KK14", m3_KK14.Value.ToString());
			if (m3_KK15.HasValue)
				request.WithQueryParameter("KK15", m3_KK15.Value.ToString());
			if (m3_KK16.HasValue)
				request.WithQueryParameter("KK16", m3_KK16.Value.ToString());
			if (m3_KK17.HasValue)
				request.WithQueryParameter("KK17", m3_KK17.Value.ToString());
			if (m3_KK18.HasValue)
				request.WithQueryParameter("KK18", m3_KK18.Value.ToString());
			if (m3_KK19.HasValue)
				request.WithQueryParameter("KK19", m3_KK19.Value.ToString());
			if (m3_KK20.HasValue)
				request.WithQueryParameter("KK20", m3_KK20.Value.ToString());
			if (m3_KK21.HasValue)
				request.WithQueryParameter("KK21", m3_KK21.Value.ToString());
			if (m3_KK22.HasValue)
				request.WithQueryParameter("KK22", m3_KK22.Value.ToString());
			if (m3_KK23.HasValue)
				request.WithQueryParameter("KK23", m3_KK23.Value.ToString());
			if (m3_KK24.HasValue)
				request.WithQueryParameter("KK24", m3_KK24.Value.ToString());

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
