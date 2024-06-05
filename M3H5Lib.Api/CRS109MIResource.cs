/// **********************************************************************
/// Created by: Gary Smith
/// Updated: 20240309-1226
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
			payloadFactory = new PayloadFactory();
		}

		/// <summary>
		/// Name DelField
		/// Description Delete field group field
		/// Version Release: 15.0
		/// </summary>
		/// <param name="m3_MGRP">Field group (Required)</param>
		/// <param name="m3_OBJC">Field (Required)</param>
		/// <param name="maxRecords">Maximum number of records to return</param>
		/// <param name="includeMetadata">Include Metadata records in response (default false)</param>
		/// <param name="trimResults">Trim result data (default true)</param>
		/// <param name="outputColumns">List of columns to return, null or empty for all columns</param>
		/// <param name="cancellationToken"></param>
		/// <returns>M3Response<M3Record></returns>
		/// <exception cref="M3Exception<M3Record>"></exception>
		public async Task<M3Response<M3Record>> DelField(
			string m3_MGRP, 
			string m3_OBJC, 
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
				EndpointUri = $"{M3Config.BasePath}/{ProgramName}/DelField",
			};

			// Validate mandatory parameters
			if (string.IsNullOrWhiteSpace(m3_MGRP))
				throw new ArgumentNullException("m3_MGRP");
			if (string.IsNullOrWhiteSpace(m3_OBJC))
				throw new ArgumentNullException("m3_OBJC");

			// Set mandatory parameters
			request
				.WithQueryParameter("MGRP", m3_MGRP.Trim())
				.WithQueryParameter("OBJC", m3_OBJC.Trim());

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
