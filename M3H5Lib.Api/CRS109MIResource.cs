/// **********************************************************************
/// This class is auto-generated.  If you need to make changes it's
/// advised to create a new method in a separate partial class.
/// Updated: 20240605-0741
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
using System.Globalization;

namespace M3H5Lib.Api
{

	/// <summary>
	/// Name: CRS109MI
	/// Component Name: FieldGroup
	/// Description: Api: Field group interface
	/// Version Release: 15.0
	///</summary>
	public partial class CRS109MIResource : M3BaseResourceEndpoint
	{
		public CRS109MIResource(ApiClient apiClient)
			: base(apiClient)
		{
			ProgramName = "CRS109MI";
			PayloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name DelField
		/// Description Delete field group field
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3MGRP">Field group (Required)</param>
		/// <param name="m3OBJC">Field (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelField(
			string m3MGRP, 
			string m3OBJC, 
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
				EndpointUri = $"{Config.BasePath}/{ProgramName}/DelField",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3MGRP))
				throw new ArgumentNullException(nameof(m3MGRP));
			if (string.IsNullOrWhiteSpace(m3OBJC))
				throw new ArgumentNullException(nameof(m3OBJC));

			// Set mandatory parameters
			request
				.WithQueryParameter("MGRP", m3MGRP.Trim())
				.WithQueryParameter("OBJC", m3OBJC.Trim());

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
