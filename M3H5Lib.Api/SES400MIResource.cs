/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

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
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name Add
		/// Description Add
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FNID">Function (Required)</param>
		/// <param name="m3ROLL">Role (Required)</param>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3STAT">Status (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3AL01">Option 1 permitted</param>
		/// <param name="m3AL02">Option 2 permitted</param>
		/// <param name="m3AL03">Option 3 permitted</param>
		/// <param name="m3AL04">Option 4 permitted</param>
		/// <param name="m3AL05">Option 5 permitted</param>
		/// <param name="m3AL06">Option 6 permitted</param>
		/// <param name="m3AL07">Option 7 permitted</param>
		/// <param name="m3AL08">Option 8 permitted</param>
		/// <param name="m3AL09">Option 9 permitted</param>
		/// <param name="m3OK10">Option 10 permitted</param>
		/// <param name="m3OK11">Option 11 permitted</param>
		/// <param name="m3OK12">Option 12 permitted</param>
		/// <param name="m3OK13">Option 13 permitted</param>
		/// <param name="m3OK14">Option 14 permitted</param>
		/// <param name="m3OK15">Option 15 permitted</param>
		/// <param name="m3OK16">Option 16 permitted</param>
		/// <param name="m3OK17">Option 17 permitted</param>
		/// <param name="m3OK18">Option 18 permitted</param>
		/// <param name="m3OK19">Option 19 permitted</param>
		/// <param name="m3OK20">Option 20 permitted</param>
		/// <param name="m3OK21">Option 21 permitted</param>
		/// <param name="m3OK22">Option 22 permitted</param>
		/// <param name="m3OK23">Option 23 permitted</param>
		/// <param name="m3OK24">Option 24 permitted</param>
		/// <param name="m3OK25">Option 25 permitted</param>
		/// <param name="m3OK26">Option 26 permitted</param>
		/// <param name="m3OK27">Option 27 permitted</param>
		/// <param name="m3OK28">Option 28 permitted</param>
		/// <param name="m3OK29">Option 29 permitted</param>
		/// <param name="m3OK30">Option 30 permitted</param>
		/// <param name="m3OK31">Option 31 permitted</param>
		/// <param name="m3OK32">Option 32 permitted</param>
		/// <param name="m3OK33">Option 33 permitted</param>
		/// <param name="m3OK34">Option 34 permitted</param>
		/// <param name="m3OK35">Option 35 permitted</param>
		/// <param name="m3OK36">Option 36 permitted</param>
		/// <param name="m3OK37">Option 37 permitted</param>
		/// <param name="m3OK38">Option 38 permitted</param>
		/// <param name="m3OK39">Option 39 permitted</param>
		/// <param name="m3OK40">Option 40 permitted</param>
		/// <param name="m3OK41">Option 41 permitted</param>
		/// <param name="m3OK42">Option 42 permitted</param>
		/// <param name="m3OK43">Option 43 permitted</param>
		/// <param name="m3OK44">Option 44 permitted</param>
		/// <param name="m3OK45">Option 45 permitted</param>
		/// <param name="m3OK46">Option 46 permitted</param>
		/// <param name="m3OK47">Option 47 permitted</param>
		/// <param name="m3OK48">Option 48 permitted</param>
		/// <param name="m3OK49">Option 49 permitted</param>
		/// <param name="m3OK50">Option 50 permitted</param>
		/// <param name="m3OK51">Option 51 permitted</param>
		/// <param name="m3OK52">Option 52 permitted</param>
		/// <param name="m3OK53">Option 53 permitted</param>
		/// <param name="m3OK54">Option 54 permitted</param>
		/// <param name="m3OK55">Option 55 permitted</param>
		/// <param name="m3OK56">Option 56 permitted</param>
		/// <param name="m3OK57">Option 57 permitted</param>
		/// <param name="m3OK58">Option 58 permitted</param>
		/// <param name="m3OK59">Option 59 permitted</param>
		/// <param name="m3OK60">Option 60 permitted</param>
		/// <param name="m3OK61">Option 61 permitted</param>
		/// <param name="m3OK62">Option 62 permitted</param>
		/// <param name="m3OK63">Option 63 permitted</param>
		/// <param name="m3OK64">Option 64 permitted</param>
		/// <param name="m3OK65">Option 65 permitted</param>
		/// <param name="m3OK66">Option 66 permitted</param>
		/// <param name="m3OK67">Option 67 permitted</param>
		/// <param name="m3OK68">Option 68 permitted</param>
		/// <param name="m3OK69">Option 69 permitted</param>
		/// <param name="m3OK70">Option 70 permitted</param>
		/// <param name="m3OK71">Option 71 permitted</param>
		/// <param name="m3OK72">Option 72 permitted</param>
		/// <param name="m3OK73">Option 73 permitted</param>
		/// <param name="m3OK74">Option 74 permitted</param>
		/// <param name="m3OK75">Option 75 permitted</param>
		/// <param name="m3OK76">Option 76 permitted</param>
		/// <param name="m3OK77">Option 77 permitted</param>
		/// <param name="m3OK78">Option 78 permitted</param>
		/// <param name="m3OK79">Option 79 permitted</param>
		/// <param name="m3OK80">Option 80 permitted</param>
		/// <param name="m3OK81">Option 81 permitted</param>
		/// <param name="m3OK82">Option 82 permitted</param>
		/// <param name="m3OK83">Option 83 permitted</param>
		/// <param name="m3OK84">Option 84 permitted</param>
		/// <param name="m3OK85">Option 85 permitted</param>
		/// <param name="m3OK86">Option 86 permitted</param>
		/// <param name="m3OK87">Option 87 permitted</param>
		/// <param name="m3OK88">Option 88 permitted</param>
		/// <param name="m3OK89">Option 89 permitted</param>
		/// <param name="m3OK90">Option 90 permitted</param>
		/// <param name="m3OK91">Option 91 permitted</param>
		/// <param name="m3OK92">Option 92 permitted</param>
		/// <param name="m3OK93">Option 93 permitted</param>
		/// <param name="m3OK94">Option 94 permitted</param>
		/// <param name="m3OK95">Option 95 permitted</param>
		/// <param name="m3OK96">Option 96 permitted</param>
		/// <param name="m3OK97">Option 97 permitted</param>
		/// <param name="m3OK98">Option 98 permitted</param>
		/// <param name="m3OK99">Option 99 permitted</param>
		/// <param name="m3KK01">Function key F1 permitted</param>
		/// <param name="m3KK02">Function key F2 permitted</param>
		/// <param name="m3KK03">Function key F3 permitted</param>
		/// <param name="m3KK04">Function key F4 permitted</param>
		/// <param name="m3KK05">Function key F5 permitted</param>
		/// <param name="m3KK06">Function key F6 permitted</param>
		/// <param name="m3KK07">Function key F7 permitted</param>
		/// <param name="m3KK08">Function key F8 permitted</param>
		/// <param name="m3KK09">Function key F9 permitted</param>
		/// <param name="m3KK10">Function key F10 permitted</param>
		/// <param name="m3KK11">Function key F11 permitted</param>
		/// <param name="m3KK12">Function key F12 permitted</param>
		/// <param name="m3KK13">Function key F13 permitted</param>
		/// <param name="m3KK14">Function key F14 permitted</param>
		/// <param name="m3KK15">Function key F15 permitted</param>
		/// <param name="m3KK16">Function key F16 permitted</param>
		/// <param name="m3KK17">Function key F17 permitted</param>
		/// <param name="m3KK18">Function key F18 permitted</param>
		/// <param name="m3KK19">Function key F19 permitted</param>
		/// <param name="m3KK20">Function key F20 permitted</param>
		/// <param name="m3KK21">Function key F21 permitted</param>
		/// <param name="m3KK22">Function key F22 permitted</param>
		/// <param name="m3KK23">Function key F23 permitted</param>
		/// <param name="m3KK24">Function key F24 permitted</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Add(
			string m3FNID, 
			string m3ROLL, 
			int m3CONO, 
			string m3STAT, 
			string m3DIVI = null, 
			int? m3AL01 = null, 
			int? m3AL02 = null, 
			int? m3AL03 = null, 
			int? m3AL04 = null, 
			int? m3AL05 = null, 
			int? m3AL06 = null, 
			int? m3AL07 = null, 
			int? m3AL08 = null, 
			int? m3AL09 = null, 
			int? m3OK10 = null, 
			int? m3OK11 = null, 
			int? m3OK12 = null, 
			int? m3OK13 = null, 
			int? m3OK14 = null, 
			int? m3OK15 = null, 
			int? m3OK16 = null, 
			int? m3OK17 = null, 
			int? m3OK18 = null, 
			int? m3OK19 = null, 
			int? m3OK20 = null, 
			int? m3OK21 = null, 
			int? m3OK22 = null, 
			int? m3OK23 = null, 
			int? m3OK24 = null, 
			int? m3OK25 = null, 
			int? m3OK26 = null, 
			int? m3OK27 = null, 
			int? m3OK28 = null, 
			int? m3OK29 = null, 
			int? m3OK30 = null, 
			int? m3OK31 = null, 
			int? m3OK32 = null, 
			int? m3OK33 = null, 
			int? m3OK34 = null, 
			int? m3OK35 = null, 
			int? m3OK36 = null, 
			int? m3OK37 = null, 
			int? m3OK38 = null, 
			int? m3OK39 = null, 
			int? m3OK40 = null, 
			int? m3OK41 = null, 
			int? m3OK42 = null, 
			int? m3OK43 = null, 
			int? m3OK44 = null, 
			int? m3OK45 = null, 
			int? m3OK46 = null, 
			int? m3OK47 = null, 
			int? m3OK48 = null, 
			int? m3OK49 = null, 
			int? m3OK50 = null, 
			int? m3OK51 = null, 
			int? m3OK52 = null, 
			int? m3OK53 = null, 
			int? m3OK54 = null, 
			int? m3OK55 = null, 
			int? m3OK56 = null, 
			int? m3OK57 = null, 
			int? m3OK58 = null, 
			int? m3OK59 = null, 
			int? m3OK60 = null, 
			int? m3OK61 = null, 
			int? m3OK62 = null, 
			int? m3OK63 = null, 
			int? m3OK64 = null, 
			int? m3OK65 = null, 
			int? m3OK66 = null, 
			int? m3OK67 = null, 
			int? m3OK68 = null, 
			int? m3OK69 = null, 
			int? m3OK70 = null, 
			int? m3OK71 = null, 
			int? m3OK72 = null, 
			int? m3OK73 = null, 
			int? m3OK74 = null, 
			int? m3OK75 = null, 
			int? m3OK76 = null, 
			int? m3OK77 = null, 
			int? m3OK78 = null, 
			int? m3OK79 = null, 
			int? m3OK80 = null, 
			int? m3OK81 = null, 
			int? m3OK82 = null, 
			int? m3OK83 = null, 
			int? m3OK84 = null, 
			int? m3OK85 = null, 
			int? m3OK86 = null, 
			int? m3OK87 = null, 
			int? m3OK88 = null, 
			int? m3OK89 = null, 
			int? m3OK90 = null, 
			int? m3OK91 = null, 
			int? m3OK92 = null, 
			int? m3OK93 = null, 
			int? m3OK94 = null, 
			int? m3OK95 = null, 
			int? m3OK96 = null, 
			int? m3OK97 = null, 
			int? m3OK98 = null, 
			int? m3OK99 = null, 
			int? m3KK01 = null, 
			int? m3KK02 = null, 
			int? m3KK03 = null, 
			int? m3KK04 = null, 
			int? m3KK05 = null, 
			int? m3KK06 = null, 
			int? m3KK07 = null, 
			int? m3KK08 = null, 
			int? m3KK09 = null, 
			int? m3KK10 = null, 
			int? m3KK11 = null, 
			int? m3KK12 = null, 
			int? m3KK13 = null, 
			int? m3KK14 = null, 
			int? m3KK15 = null, 
			int? m3KK16 = null, 
			int? m3KK17 = null, 
			int? m3KK18 = null, 
			int? m3KK19 = null, 
			int? m3KK20 = null, 
			int? m3KK21 = null, 
			int? m3KK22 = null, 
			int? m3KK23 = null, 
			int? m3KK24 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Add",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FNID))
				throw new ArgumentNullException(nameof(m3FNID));
			if (string.IsNullOrWhiteSpace(m3ROLL))
				throw new ArgumentNullException(nameof(m3ROLL));
			if (string.IsNullOrWhiteSpace(m3STAT))
				throw new ArgumentNullException(nameof(m3STAT));

			// Set mandatory parameters
			request
				.WithQueryParameter("FNID", m3FNID.Trim())
				.WithQueryParameter("ROLL", m3ROLL.Trim())
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture))
				.WithQueryParameter("STAT", m3STAT.Trim());

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (m3AL01.HasValue)
				request.WithQueryParameter("AL01", m3AL01.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AL02.HasValue)
				request.WithQueryParameter("AL02", m3AL02.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AL03.HasValue)
				request.WithQueryParameter("AL03", m3AL03.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AL04.HasValue)
				request.WithQueryParameter("AL04", m3AL04.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AL05.HasValue)
				request.WithQueryParameter("AL05", m3AL05.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AL06.HasValue)
				request.WithQueryParameter("AL06", m3AL06.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AL07.HasValue)
				request.WithQueryParameter("AL07", m3AL07.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AL08.HasValue)
				request.WithQueryParameter("AL08", m3AL08.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AL09.HasValue)
				request.WithQueryParameter("AL09", m3AL09.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK10.HasValue)
				request.WithQueryParameter("OK10", m3OK10.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK11.HasValue)
				request.WithQueryParameter("OK11", m3OK11.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK12.HasValue)
				request.WithQueryParameter("OK12", m3OK12.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK13.HasValue)
				request.WithQueryParameter("OK13", m3OK13.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK14.HasValue)
				request.WithQueryParameter("OK14", m3OK14.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK15.HasValue)
				request.WithQueryParameter("OK15", m3OK15.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK16.HasValue)
				request.WithQueryParameter("OK16", m3OK16.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK17.HasValue)
				request.WithQueryParameter("OK17", m3OK17.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK18.HasValue)
				request.WithQueryParameter("OK18", m3OK18.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK19.HasValue)
				request.WithQueryParameter("OK19", m3OK19.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK20.HasValue)
				request.WithQueryParameter("OK20", m3OK20.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK21.HasValue)
				request.WithQueryParameter("OK21", m3OK21.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK22.HasValue)
				request.WithQueryParameter("OK22", m3OK22.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK23.HasValue)
				request.WithQueryParameter("OK23", m3OK23.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK24.HasValue)
				request.WithQueryParameter("OK24", m3OK24.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK25.HasValue)
				request.WithQueryParameter("OK25", m3OK25.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK26.HasValue)
				request.WithQueryParameter("OK26", m3OK26.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK27.HasValue)
				request.WithQueryParameter("OK27", m3OK27.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK28.HasValue)
				request.WithQueryParameter("OK28", m3OK28.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK29.HasValue)
				request.WithQueryParameter("OK29", m3OK29.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK30.HasValue)
				request.WithQueryParameter("OK30", m3OK30.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK31.HasValue)
				request.WithQueryParameter("OK31", m3OK31.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK32.HasValue)
				request.WithQueryParameter("OK32", m3OK32.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK33.HasValue)
				request.WithQueryParameter("OK33", m3OK33.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK34.HasValue)
				request.WithQueryParameter("OK34", m3OK34.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK35.HasValue)
				request.WithQueryParameter("OK35", m3OK35.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK36.HasValue)
				request.WithQueryParameter("OK36", m3OK36.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK37.HasValue)
				request.WithQueryParameter("OK37", m3OK37.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK38.HasValue)
				request.WithQueryParameter("OK38", m3OK38.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK39.HasValue)
				request.WithQueryParameter("OK39", m3OK39.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK40.HasValue)
				request.WithQueryParameter("OK40", m3OK40.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK41.HasValue)
				request.WithQueryParameter("OK41", m3OK41.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK42.HasValue)
				request.WithQueryParameter("OK42", m3OK42.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK43.HasValue)
				request.WithQueryParameter("OK43", m3OK43.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK44.HasValue)
				request.WithQueryParameter("OK44", m3OK44.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK45.HasValue)
				request.WithQueryParameter("OK45", m3OK45.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK46.HasValue)
				request.WithQueryParameter("OK46", m3OK46.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK47.HasValue)
				request.WithQueryParameter("OK47", m3OK47.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK48.HasValue)
				request.WithQueryParameter("OK48", m3OK48.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK49.HasValue)
				request.WithQueryParameter("OK49", m3OK49.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK50.HasValue)
				request.WithQueryParameter("OK50", m3OK50.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK51.HasValue)
				request.WithQueryParameter("OK51", m3OK51.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK52.HasValue)
				request.WithQueryParameter("OK52", m3OK52.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK53.HasValue)
				request.WithQueryParameter("OK53", m3OK53.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK54.HasValue)
				request.WithQueryParameter("OK54", m3OK54.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK55.HasValue)
				request.WithQueryParameter("OK55", m3OK55.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK56.HasValue)
				request.WithQueryParameter("OK56", m3OK56.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK57.HasValue)
				request.WithQueryParameter("OK57", m3OK57.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK58.HasValue)
				request.WithQueryParameter("OK58", m3OK58.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK59.HasValue)
				request.WithQueryParameter("OK59", m3OK59.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK60.HasValue)
				request.WithQueryParameter("OK60", m3OK60.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK61.HasValue)
				request.WithQueryParameter("OK61", m3OK61.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK62.HasValue)
				request.WithQueryParameter("OK62", m3OK62.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK63.HasValue)
				request.WithQueryParameter("OK63", m3OK63.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK64.HasValue)
				request.WithQueryParameter("OK64", m3OK64.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK65.HasValue)
				request.WithQueryParameter("OK65", m3OK65.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK66.HasValue)
				request.WithQueryParameter("OK66", m3OK66.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK67.HasValue)
				request.WithQueryParameter("OK67", m3OK67.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK68.HasValue)
				request.WithQueryParameter("OK68", m3OK68.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK69.HasValue)
				request.WithQueryParameter("OK69", m3OK69.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK70.HasValue)
				request.WithQueryParameter("OK70", m3OK70.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK71.HasValue)
				request.WithQueryParameter("OK71", m3OK71.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK72.HasValue)
				request.WithQueryParameter("OK72", m3OK72.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK73.HasValue)
				request.WithQueryParameter("OK73", m3OK73.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK74.HasValue)
				request.WithQueryParameter("OK74", m3OK74.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK75.HasValue)
				request.WithQueryParameter("OK75", m3OK75.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK76.HasValue)
				request.WithQueryParameter("OK76", m3OK76.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK77.HasValue)
				request.WithQueryParameter("OK77", m3OK77.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK78.HasValue)
				request.WithQueryParameter("OK78", m3OK78.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK79.HasValue)
				request.WithQueryParameter("OK79", m3OK79.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK80.HasValue)
				request.WithQueryParameter("OK80", m3OK80.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK81.HasValue)
				request.WithQueryParameter("OK81", m3OK81.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK82.HasValue)
				request.WithQueryParameter("OK82", m3OK82.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK83.HasValue)
				request.WithQueryParameter("OK83", m3OK83.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK84.HasValue)
				request.WithQueryParameter("OK84", m3OK84.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK85.HasValue)
				request.WithQueryParameter("OK85", m3OK85.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK86.HasValue)
				request.WithQueryParameter("OK86", m3OK86.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK87.HasValue)
				request.WithQueryParameter("OK87", m3OK87.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK88.HasValue)
				request.WithQueryParameter("OK88", m3OK88.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK89.HasValue)
				request.WithQueryParameter("OK89", m3OK89.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK90.HasValue)
				request.WithQueryParameter("OK90", m3OK90.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK91.HasValue)
				request.WithQueryParameter("OK91", m3OK91.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK92.HasValue)
				request.WithQueryParameter("OK92", m3OK92.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK93.HasValue)
				request.WithQueryParameter("OK93", m3OK93.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK94.HasValue)
				request.WithQueryParameter("OK94", m3OK94.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK95.HasValue)
				request.WithQueryParameter("OK95", m3OK95.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK96.HasValue)
				request.WithQueryParameter("OK96", m3OK96.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK97.HasValue)
				request.WithQueryParameter("OK97", m3OK97.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK98.HasValue)
				request.WithQueryParameter("OK98", m3OK98.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK99.HasValue)
				request.WithQueryParameter("OK99", m3OK99.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK01.HasValue)
				request.WithQueryParameter("KK01", m3KK01.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK02.HasValue)
				request.WithQueryParameter("KK02", m3KK02.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK03.HasValue)
				request.WithQueryParameter("KK03", m3KK03.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK04.HasValue)
				request.WithQueryParameter("KK04", m3KK04.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK05.HasValue)
				request.WithQueryParameter("KK05", m3KK05.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK06.HasValue)
				request.WithQueryParameter("KK06", m3KK06.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK07.HasValue)
				request.WithQueryParameter("KK07", m3KK07.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK08.HasValue)
				request.WithQueryParameter("KK08", m3KK08.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK09.HasValue)
				request.WithQueryParameter("KK09", m3KK09.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK10.HasValue)
				request.WithQueryParameter("KK10", m3KK10.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK11.HasValue)
				request.WithQueryParameter("KK11", m3KK11.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK12.HasValue)
				request.WithQueryParameter("KK12", m3KK12.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK13.HasValue)
				request.WithQueryParameter("KK13", m3KK13.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK14.HasValue)
				request.WithQueryParameter("KK14", m3KK14.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK15.HasValue)
				request.WithQueryParameter("KK15", m3KK15.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK16.HasValue)
				request.WithQueryParameter("KK16", m3KK16.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK17.HasValue)
				request.WithQueryParameter("KK17", m3KK17.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK18.HasValue)
				request.WithQueryParameter("KK18", m3KK18.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK19.HasValue)
				request.WithQueryParameter("KK19", m3KK19.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK20.HasValue)
				request.WithQueryParameter("KK20", m3KK20.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK21.HasValue)
				request.WithQueryParameter("KK21", m3KK21.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK22.HasValue)
				request.WithQueryParameter("KK22", m3KK22.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK23.HasValue)
				request.WithQueryParameter("KK23", m3KK23.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK24.HasValue)
				request.WithQueryParameter("KK24", m3KK24.Value.ToString(CultureInfo.CurrentCulture));

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
		/// Name Dlt
		/// Description Dlt
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FNID">Function (Required)</param>
		/// <param name="m3ROLL">Role (Required)</param>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Dlt(
			string m3FNID, 
			string m3ROLL, 
			int m3CONO, 
			string m3DIVI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Dlt",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FNID))
				throw new ArgumentNullException(nameof(m3FNID));
			if (string.IsNullOrWhiteSpace(m3ROLL))
				throw new ArgumentNullException(nameof(m3ROLL));

			// Set mandatory parameters
			request
				.WithQueryParameter("FNID", m3FNID.Trim())
				.WithQueryParameter("ROLL", m3ROLL.Trim())
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

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
		/// Name Get
		/// Description Get
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FNID">Function (Required)</param>
		/// <param name="m3ROLL">Role (Required)</param>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<GetResponse></returns>
		/// <exception cref="M3Exception<GetResponse>"></exception>
		public async Task<M3Response<GetResponse>> Get(
			string m3FNID, 
			string m3ROLL, 
			int m3CONO, 
			string m3DIVI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Get",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FNID))
				throw new ArgumentNullException(nameof(m3FNID));
			if (string.IsNullOrWhiteSpace(m3ROLL))
				throw new ArgumentNullException(nameof(m3ROLL));

			// Set mandatory parameters
			request
				.WithQueryParameter("FNID", m3FNID.Trim())
				.WithQueryParameter("ROLL", m3ROLL.Trim())
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

			// Execute the request
			var result = await Execute<GetResponse>(
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
		/// Description Lst
		/// Version Release: 5ea0
		/// </summary>
		/// <param name="m3FNID">Function (Required)</param>
		/// <param name="m3ROLL">Role (Required)</param>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstResponse></returns>
		/// <exception cref="M3Exception<LstResponse>"></exception>
		public async Task<M3Response<LstResponse>> Lst(
			string m3FNID, 
			string m3ROLL, 
			int m3CONO, 
			string m3DIVI = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Lst",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FNID))
				throw new ArgumentNullException(nameof(m3FNID));
			if (string.IsNullOrWhiteSpace(m3ROLL))
				throw new ArgumentNullException(nameof(m3ROLL));

			// Set mandatory parameters
			request
				.WithQueryParameter("FNID", m3FNID.Trim())
				.WithQueryParameter("ROLL", m3ROLL.Trim())
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());

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
		/// Name LstAuthByRole
		/// Description List Authority By Role
		/// Version Release: 5ea2
		/// </summary>
		/// <param name="m3ROLL">Role (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<LstAuthByRoleResponse></returns>
		/// <exception cref="M3Exception<LstAuthByRoleResponse>"></exception>
		public async Task<M3Response<LstAuthByRoleResponse>> LstAuthByRole(
			string m3ROLL, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/LstAuthByRole",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3ROLL))
				throw new ArgumentNullException(nameof(m3ROLL));

			// Set mandatory parameters
			request
				.WithQueryParameter("ROLL", m3ROLL.Trim());

			// Execute the request
			var result = await Execute<LstAuthByRoleResponse>(
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
		/// Description Upd
		/// Version Release: 5ea1
		/// </summary>
		/// <param name="m3FNID">Function (Required)</param>
		/// <param name="m3ROLL">Role (Required)</param>
		/// <param name="m3CONO">Company (Required)</param>
		/// <param name="m3DIVI">Division</param>
		/// <param name="m3STAT">Status</param>
		/// <param name="m3AL01">Option 1 permitted</param>
		/// <param name="m3AL02">Option 2 permitted</param>
		/// <param name="m3AL03">Option 3 permitted</param>
		/// <param name="m3AL04">Option 4 permitted</param>
		/// <param name="m3AL05">Option 5 permitted</param>
		/// <param name="m3AL06">Option 6 permitted</param>
		/// <param name="m3AL07">Option 7 permitted</param>
		/// <param name="m3AL08">Option 8 permitted</param>
		/// <param name="m3AL09">Option 9 permitted</param>
		/// <param name="m3OK10">Option 10 permitted</param>
		/// <param name="m3OK11">Option 11 permitted</param>
		/// <param name="m3OK12">Option 12 permitted</param>
		/// <param name="m3OK13">Option 13 permitted</param>
		/// <param name="m3OK14">Option 14 permitted</param>
		/// <param name="m3OK15">Option 15 permitted</param>
		/// <param name="m3OK16">Option 16 permitted</param>
		/// <param name="m3OK17">Option 17 permitted</param>
		/// <param name="m3OK18">Option 18 permitted</param>
		/// <param name="m3OK19">Option 19 permitted</param>
		/// <param name="m3OK20">Option 20 permitted</param>
		/// <param name="m3OK21">Option 21 permitted</param>
		/// <param name="m3OK22">Option 22 permitted</param>
		/// <param name="m3OK23">Option 23 permitted</param>
		/// <param name="m3OK24">Option 24 permitted</param>
		/// <param name="m3OK25">Option 25 permitted</param>
		/// <param name="m3OK26">Option 26 permitted</param>
		/// <param name="m3OK27">Option 27 permitted</param>
		/// <param name="m3OK28">Option 28 permitted</param>
		/// <param name="m3OK29">Option 29 permitted</param>
		/// <param name="m3OK30">Option 30 permitted</param>
		/// <param name="m3OK31">Option 31 permitted</param>
		/// <param name="m3OK32">Option 32 permitted</param>
		/// <param name="m3OK33">Option 33 permitted</param>
		/// <param name="m3OK34">Option 34 permitted</param>
		/// <param name="m3OK35">Option 35 permitted</param>
		/// <param name="m3OK36">Option 36 permitted</param>
		/// <param name="m3OK37">Option 37 permitted</param>
		/// <param name="m3OK38">Option 38 permitted</param>
		/// <param name="m3OK39">Option 39 permitted</param>
		/// <param name="m3OK40">Option 40 permitted</param>
		/// <param name="m3OK41">Option 41 permitted</param>
		/// <param name="m3OK42">Option 42 permitted</param>
		/// <param name="m3OK43">Option 43 permitted</param>
		/// <param name="m3OK44">Option 44 permitted</param>
		/// <param name="m3OK45">Option 45 permitted</param>
		/// <param name="m3OK46">Option 46 permitted</param>
		/// <param name="m3OK47">Option 47 permitted</param>
		/// <param name="m3OK48">Option 48 permitted</param>
		/// <param name="m3OK49">Option 49 permitted</param>
		/// <param name="m3OK50">Option 50 permitted</param>
		/// <param name="m3OK51">Option 51 permitted</param>
		/// <param name="m3OK52">Option 52 permitted</param>
		/// <param name="m3OK53">Option 53 permitted</param>
		/// <param name="m3OK54">Option 54 permitted</param>
		/// <param name="m3OK55">Option 55 permitted</param>
		/// <param name="m3OK56">Option 56 permitted</param>
		/// <param name="m3OK57">Option 57 permitted</param>
		/// <param name="m3OK58">Option 58 permitted</param>
		/// <param name="m3OK59">Option 59 permitted</param>
		/// <param name="m3OK60">Option 60 permitted</param>
		/// <param name="m3OK61">Option 61 permitted</param>
		/// <param name="m3OK62">Option 62 permitted</param>
		/// <param name="m3OK63">Option 63 permitted</param>
		/// <param name="m3OK64">Option 64 permitted</param>
		/// <param name="m3OK65">Option 65 permitted</param>
		/// <param name="m3OK66">Option 66 permitted</param>
		/// <param name="m3OK67">Option 67 permitted</param>
		/// <param name="m3OK68">Option 68 permitted</param>
		/// <param name="m3OK69">Option 69 permitted</param>
		/// <param name="m3OK70">Option 70 permitted</param>
		/// <param name="m3OK71">Option 71 permitted</param>
		/// <param name="m3OK72">Option 72 permitted</param>
		/// <param name="m3OK73">Option 73 permitted</param>
		/// <param name="m3OK74">Option 74 permitted</param>
		/// <param name="m3OK75">Option 75 permitted</param>
		/// <param name="m3OK76">Option 76 permitted</param>
		/// <param name="m3OK77">Option 77 permitted</param>
		/// <param name="m3OK78">Option 78 permitted</param>
		/// <param name="m3OK79">Option 79 permitted</param>
		/// <param name="m3OK80">Option 80 permitted</param>
		/// <param name="m3OK81">Option 81 permitted</param>
		/// <param name="m3OK82">Option 82 permitted</param>
		/// <param name="m3OK83">Option 83 permitted</param>
		/// <param name="m3OK84">Option 84 permitted</param>
		/// <param name="m3OK85">Option 85 permitted</param>
		/// <param name="m3OK86">Option 86 permitted</param>
		/// <param name="m3OK87">Option 87 permitted</param>
		/// <param name="m3OK88">Option 88 permitted</param>
		/// <param name="m3OK89">Option 89 permitted</param>
		/// <param name="m3OK90">Option 90 permitted</param>
		/// <param name="m3OK91">Option 91 permitted</param>
		/// <param name="m3OK92">Option 92 permitted</param>
		/// <param name="m3OK93">Option 93 permitted</param>
		/// <param name="m3OK94">Option 94 permitted</param>
		/// <param name="m3OK95">Option 95 permitted</param>
		/// <param name="m3OK96">Option 96 permitted</param>
		/// <param name="m3OK97">Option 97 permitted</param>
		/// <param name="m3OK98">Option 98 permitted</param>
		/// <param name="m3OK99">Option 99 permitted</param>
		/// <param name="m3KK01">Function key F1 permitted</param>
		/// <param name="m3KK02">Function key F2 permitted</param>
		/// <param name="m3KK03">Function key F3 permitted</param>
		/// <param name="m3KK04">Function key F4 permitted</param>
		/// <param name="m3KK05">Function key F5 permitted</param>
		/// <param name="m3KK06">Function key F6 permitted</param>
		/// <param name="m3KK07">Function key F7 permitted</param>
		/// <param name="m3KK08">Function key F8 permitted</param>
		/// <param name="m3KK09">Function key F9 permitted</param>
		/// <param name="m3KK10">Function key F10 permitted</param>
		/// <param name="m3KK11">Function key F11 permitted</param>
		/// <param name="m3KK12">Function key F12 permitted</param>
		/// <param name="m3KK13">Function key F13 permitted</param>
		/// <param name="m3KK14">Function key F14 permitted</param>
		/// <param name="m3KK15">Function key F15 permitted</param>
		/// <param name="m3KK16">Function key F16 permitted</param>
		/// <param name="m3KK17">Function key F17 permitted</param>
		/// <param name="m3KK18">Function key F18 permitted</param>
		/// <param name="m3KK19">Function key F19 permitted</param>
		/// <param name="m3KK20">Function key F20 permitted</param>
		/// <param name="m3KK21">Function key F21 permitted</param>
		/// <param name="m3KK22">Function key F22 permitted</param>
		/// <param name="m3KK23">Function key F23 permitted</param>
		/// <param name="m3KK24">Function key F24 permitted</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> Upd(
			string m3FNID, 
			string m3ROLL, 
			int m3CONO, 
			string m3DIVI = null, 
			string m3STAT = null, 
			int? m3AL01 = null, 
			int? m3AL02 = null, 
			int? m3AL03 = null, 
			int? m3AL04 = null, 
			int? m3AL05 = null, 
			int? m3AL06 = null, 
			int? m3AL07 = null, 
			int? m3AL08 = null, 
			int? m3AL09 = null, 
			int? m3OK10 = null, 
			int? m3OK11 = null, 
			int? m3OK12 = null, 
			int? m3OK13 = null, 
			int? m3OK14 = null, 
			int? m3OK15 = null, 
			int? m3OK16 = null, 
			int? m3OK17 = null, 
			int? m3OK18 = null, 
			int? m3OK19 = null, 
			int? m3OK20 = null, 
			int? m3OK21 = null, 
			int? m3OK22 = null, 
			int? m3OK23 = null, 
			int? m3OK24 = null, 
			int? m3OK25 = null, 
			int? m3OK26 = null, 
			int? m3OK27 = null, 
			int? m3OK28 = null, 
			int? m3OK29 = null, 
			int? m3OK30 = null, 
			int? m3OK31 = null, 
			int? m3OK32 = null, 
			int? m3OK33 = null, 
			int? m3OK34 = null, 
			int? m3OK35 = null, 
			int? m3OK36 = null, 
			int? m3OK37 = null, 
			int? m3OK38 = null, 
			int? m3OK39 = null, 
			int? m3OK40 = null, 
			int? m3OK41 = null, 
			int? m3OK42 = null, 
			int? m3OK43 = null, 
			int? m3OK44 = null, 
			int? m3OK45 = null, 
			int? m3OK46 = null, 
			int? m3OK47 = null, 
			int? m3OK48 = null, 
			int? m3OK49 = null, 
			int? m3OK50 = null, 
			int? m3OK51 = null, 
			int? m3OK52 = null, 
			int? m3OK53 = null, 
			int? m3OK54 = null, 
			int? m3OK55 = null, 
			int? m3OK56 = null, 
			int? m3OK57 = null, 
			int? m3OK58 = null, 
			int? m3OK59 = null, 
			int? m3OK60 = null, 
			int? m3OK61 = null, 
			int? m3OK62 = null, 
			int? m3OK63 = null, 
			int? m3OK64 = null, 
			int? m3OK65 = null, 
			int? m3OK66 = null, 
			int? m3OK67 = null, 
			int? m3OK68 = null, 
			int? m3OK69 = null, 
			int? m3OK70 = null, 
			int? m3OK71 = null, 
			int? m3OK72 = null, 
			int? m3OK73 = null, 
			int? m3OK74 = null, 
			int? m3OK75 = null, 
			int? m3OK76 = null, 
			int? m3OK77 = null, 
			int? m3OK78 = null, 
			int? m3OK79 = null, 
			int? m3OK80 = null, 
			int? m3OK81 = null, 
			int? m3OK82 = null, 
			int? m3OK83 = null, 
			int? m3OK84 = null, 
			int? m3OK85 = null, 
			int? m3OK86 = null, 
			int? m3OK87 = null, 
			int? m3OK88 = null, 
			int? m3OK89 = null, 
			int? m3OK90 = null, 
			int? m3OK91 = null, 
			int? m3OK92 = null, 
			int? m3OK93 = null, 
			int? m3OK94 = null, 
			int? m3OK95 = null, 
			int? m3OK96 = null, 
			int? m3OK97 = null, 
			int? m3OK98 = null, 
			int? m3OK99 = null, 
			int? m3KK01 = null, 
			int? m3KK02 = null, 
			int? m3KK03 = null, 
			int? m3KK04 = null, 
			int? m3KK05 = null, 
			int? m3KK06 = null, 
			int? m3KK07 = null, 
			int? m3KK08 = null, 
			int? m3KK09 = null, 
			int? m3KK10 = null, 
			int? m3KK11 = null, 
			int? m3KK12 = null, 
			int? m3KK13 = null, 
			int? m3KK14 = null, 
			int? m3KK15 = null, 
			int? m3KK16 = null, 
			int? m3KK17 = null, 
			int? m3KK18 = null, 
			int? m3KK19 = null, 
			int? m3KK20 = null, 
			int? m3KK21 = null, 
			int? m3KK22 = null, 
			int? m3KK23 = null, 
			int? m3KK24 = null, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/Upd",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3FNID))
				throw new ArgumentNullException(nameof(m3FNID));
			if (string.IsNullOrWhiteSpace(m3ROLL))
				throw new ArgumentNullException(nameof(m3ROLL));

			// Set mandatory parameters
			request
				.WithQueryParameter("FNID", m3FNID.Trim())
				.WithQueryParameter("ROLL", m3ROLL.Trim())
				.WithQueryParameter("CONO", m3CONO.ToString(CultureInfo.CurrentCulture));

			// Set optional parameters, checking for null/blank data for each element
			if (!string.IsNullOrWhiteSpace(m3DIVI))
				request.WithQueryParameter("DIVI", m3DIVI.Trim());
			if (!string.IsNullOrWhiteSpace(m3STAT))
				request.WithQueryParameter("STAT", m3STAT.Trim());
			if (m3AL01.HasValue)
				request.WithQueryParameter("AL01", m3AL01.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AL02.HasValue)
				request.WithQueryParameter("AL02", m3AL02.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AL03.HasValue)
				request.WithQueryParameter("AL03", m3AL03.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AL04.HasValue)
				request.WithQueryParameter("AL04", m3AL04.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AL05.HasValue)
				request.WithQueryParameter("AL05", m3AL05.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AL06.HasValue)
				request.WithQueryParameter("AL06", m3AL06.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AL07.HasValue)
				request.WithQueryParameter("AL07", m3AL07.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AL08.HasValue)
				request.WithQueryParameter("AL08", m3AL08.Value.ToString(CultureInfo.CurrentCulture));
			if (m3AL09.HasValue)
				request.WithQueryParameter("AL09", m3AL09.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK10.HasValue)
				request.WithQueryParameter("OK10", m3OK10.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK11.HasValue)
				request.WithQueryParameter("OK11", m3OK11.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK12.HasValue)
				request.WithQueryParameter("OK12", m3OK12.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK13.HasValue)
				request.WithQueryParameter("OK13", m3OK13.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK14.HasValue)
				request.WithQueryParameter("OK14", m3OK14.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK15.HasValue)
				request.WithQueryParameter("OK15", m3OK15.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK16.HasValue)
				request.WithQueryParameter("OK16", m3OK16.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK17.HasValue)
				request.WithQueryParameter("OK17", m3OK17.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK18.HasValue)
				request.WithQueryParameter("OK18", m3OK18.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK19.HasValue)
				request.WithQueryParameter("OK19", m3OK19.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK20.HasValue)
				request.WithQueryParameter("OK20", m3OK20.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK21.HasValue)
				request.WithQueryParameter("OK21", m3OK21.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK22.HasValue)
				request.WithQueryParameter("OK22", m3OK22.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK23.HasValue)
				request.WithQueryParameter("OK23", m3OK23.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK24.HasValue)
				request.WithQueryParameter("OK24", m3OK24.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK25.HasValue)
				request.WithQueryParameter("OK25", m3OK25.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK26.HasValue)
				request.WithQueryParameter("OK26", m3OK26.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK27.HasValue)
				request.WithQueryParameter("OK27", m3OK27.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK28.HasValue)
				request.WithQueryParameter("OK28", m3OK28.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK29.HasValue)
				request.WithQueryParameter("OK29", m3OK29.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK30.HasValue)
				request.WithQueryParameter("OK30", m3OK30.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK31.HasValue)
				request.WithQueryParameter("OK31", m3OK31.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK32.HasValue)
				request.WithQueryParameter("OK32", m3OK32.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK33.HasValue)
				request.WithQueryParameter("OK33", m3OK33.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK34.HasValue)
				request.WithQueryParameter("OK34", m3OK34.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK35.HasValue)
				request.WithQueryParameter("OK35", m3OK35.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK36.HasValue)
				request.WithQueryParameter("OK36", m3OK36.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK37.HasValue)
				request.WithQueryParameter("OK37", m3OK37.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK38.HasValue)
				request.WithQueryParameter("OK38", m3OK38.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK39.HasValue)
				request.WithQueryParameter("OK39", m3OK39.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK40.HasValue)
				request.WithQueryParameter("OK40", m3OK40.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK41.HasValue)
				request.WithQueryParameter("OK41", m3OK41.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK42.HasValue)
				request.WithQueryParameter("OK42", m3OK42.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK43.HasValue)
				request.WithQueryParameter("OK43", m3OK43.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK44.HasValue)
				request.WithQueryParameter("OK44", m3OK44.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK45.HasValue)
				request.WithQueryParameter("OK45", m3OK45.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK46.HasValue)
				request.WithQueryParameter("OK46", m3OK46.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK47.HasValue)
				request.WithQueryParameter("OK47", m3OK47.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK48.HasValue)
				request.WithQueryParameter("OK48", m3OK48.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK49.HasValue)
				request.WithQueryParameter("OK49", m3OK49.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK50.HasValue)
				request.WithQueryParameter("OK50", m3OK50.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK51.HasValue)
				request.WithQueryParameter("OK51", m3OK51.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK52.HasValue)
				request.WithQueryParameter("OK52", m3OK52.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK53.HasValue)
				request.WithQueryParameter("OK53", m3OK53.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK54.HasValue)
				request.WithQueryParameter("OK54", m3OK54.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK55.HasValue)
				request.WithQueryParameter("OK55", m3OK55.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK56.HasValue)
				request.WithQueryParameter("OK56", m3OK56.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK57.HasValue)
				request.WithQueryParameter("OK57", m3OK57.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK58.HasValue)
				request.WithQueryParameter("OK58", m3OK58.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK59.HasValue)
				request.WithQueryParameter("OK59", m3OK59.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK60.HasValue)
				request.WithQueryParameter("OK60", m3OK60.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK61.HasValue)
				request.WithQueryParameter("OK61", m3OK61.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK62.HasValue)
				request.WithQueryParameter("OK62", m3OK62.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK63.HasValue)
				request.WithQueryParameter("OK63", m3OK63.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK64.HasValue)
				request.WithQueryParameter("OK64", m3OK64.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK65.HasValue)
				request.WithQueryParameter("OK65", m3OK65.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK66.HasValue)
				request.WithQueryParameter("OK66", m3OK66.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK67.HasValue)
				request.WithQueryParameter("OK67", m3OK67.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK68.HasValue)
				request.WithQueryParameter("OK68", m3OK68.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK69.HasValue)
				request.WithQueryParameter("OK69", m3OK69.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK70.HasValue)
				request.WithQueryParameter("OK70", m3OK70.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK71.HasValue)
				request.WithQueryParameter("OK71", m3OK71.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK72.HasValue)
				request.WithQueryParameter("OK72", m3OK72.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK73.HasValue)
				request.WithQueryParameter("OK73", m3OK73.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK74.HasValue)
				request.WithQueryParameter("OK74", m3OK74.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK75.HasValue)
				request.WithQueryParameter("OK75", m3OK75.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK76.HasValue)
				request.WithQueryParameter("OK76", m3OK76.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK77.HasValue)
				request.WithQueryParameter("OK77", m3OK77.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK78.HasValue)
				request.WithQueryParameter("OK78", m3OK78.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK79.HasValue)
				request.WithQueryParameter("OK79", m3OK79.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK80.HasValue)
				request.WithQueryParameter("OK80", m3OK80.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK81.HasValue)
				request.WithQueryParameter("OK81", m3OK81.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK82.HasValue)
				request.WithQueryParameter("OK82", m3OK82.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK83.HasValue)
				request.WithQueryParameter("OK83", m3OK83.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK84.HasValue)
				request.WithQueryParameter("OK84", m3OK84.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK85.HasValue)
				request.WithQueryParameter("OK85", m3OK85.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK86.HasValue)
				request.WithQueryParameter("OK86", m3OK86.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK87.HasValue)
				request.WithQueryParameter("OK87", m3OK87.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK88.HasValue)
				request.WithQueryParameter("OK88", m3OK88.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK89.HasValue)
				request.WithQueryParameter("OK89", m3OK89.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK90.HasValue)
				request.WithQueryParameter("OK90", m3OK90.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK91.HasValue)
				request.WithQueryParameter("OK91", m3OK91.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK92.HasValue)
				request.WithQueryParameter("OK92", m3OK92.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK93.HasValue)
				request.WithQueryParameter("OK93", m3OK93.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK94.HasValue)
				request.WithQueryParameter("OK94", m3OK94.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK95.HasValue)
				request.WithQueryParameter("OK95", m3OK95.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK96.HasValue)
				request.WithQueryParameter("OK96", m3OK96.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK97.HasValue)
				request.WithQueryParameter("OK97", m3OK97.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK98.HasValue)
				request.WithQueryParameter("OK98", m3OK98.Value.ToString(CultureInfo.CurrentCulture));
			if (m3OK99.HasValue)
				request.WithQueryParameter("OK99", m3OK99.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK01.HasValue)
				request.WithQueryParameter("KK01", m3KK01.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK02.HasValue)
				request.WithQueryParameter("KK02", m3KK02.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK03.HasValue)
				request.WithQueryParameter("KK03", m3KK03.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK04.HasValue)
				request.WithQueryParameter("KK04", m3KK04.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK05.HasValue)
				request.WithQueryParameter("KK05", m3KK05.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK06.HasValue)
				request.WithQueryParameter("KK06", m3KK06.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK07.HasValue)
				request.WithQueryParameter("KK07", m3KK07.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK08.HasValue)
				request.WithQueryParameter("KK08", m3KK08.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK09.HasValue)
				request.WithQueryParameter("KK09", m3KK09.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK10.HasValue)
				request.WithQueryParameter("KK10", m3KK10.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK11.HasValue)
				request.WithQueryParameter("KK11", m3KK11.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK12.HasValue)
				request.WithQueryParameter("KK12", m3KK12.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK13.HasValue)
				request.WithQueryParameter("KK13", m3KK13.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK14.HasValue)
				request.WithQueryParameter("KK14", m3KK14.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK15.HasValue)
				request.WithQueryParameter("KK15", m3KK15.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK16.HasValue)
				request.WithQueryParameter("KK16", m3KK16.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK17.HasValue)
				request.WithQueryParameter("KK17", m3KK17.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK18.HasValue)
				request.WithQueryParameter("KK18", m3KK18.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK19.HasValue)
				request.WithQueryParameter("KK19", m3KK19.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK20.HasValue)
				request.WithQueryParameter("KK20", m3KK20.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK21.HasValue)
				request.WithQueryParameter("KK21", m3KK21.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK22.HasValue)
				request.WithQueryParameter("KK22", m3KK22.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK23.HasValue)
				request.WithQueryParameter("KK23", m3KK23.Value.ToString(CultureInfo.CurrentCulture));
			if (m3KK24.HasValue)
				request.WithQueryParameter("KK24", m3KK24.Value.ToString(CultureInfo.CurrentCulture));

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
