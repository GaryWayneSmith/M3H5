using M3H5Lib.Models;
using System;
using System.Runtime.Serialization;

namespace M3H5Lib
{
	public class M3Exception<T> : Exception where T : M3BaseRecord
	{
		public readonly M3Response<T> M3Response;

		public M3Exception(M3Response<T> m3Response)
			: base(m3Response.Message)
		{
			M3Response = m3Response;
		}

		public M3Exception(M3Response<T> m3Response, string message)
			: base(message)
		{
			M3Response = m3Response;
		}

		public M3Exception(M3Response<T> m3Response, Exception innerException)
			: base(m3Response.Message, innerException)
		{
			M3Response = m3Response;
		}

		public M3Exception(M3Response<T> m3Response, string message, Exception innerException)
			: base(message, innerException)
		{
			M3Response = m3Response;
		}

		protected M3Exception(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{

		}

		public override string ToString()
		{
			return $"Message: {M3Response.Message}";
		}
	}
}
