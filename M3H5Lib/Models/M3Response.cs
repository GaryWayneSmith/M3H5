using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace M3H5Lib.Models
{
	[DataContract]
	public class M3Response<T> where T : M3BaseRecord
	{
		//{"@code":"XAU0008","@field":"CONO","@type":"ServerReturnedNOK","Message":"Not authorized for company 0   
		//{"@code":"XIM0002","@type":"ServerReturnedNOK","Message":"Customer number is invalid   

		public bool Success
		{
			get
			{
				if (!string.IsNullOrWhiteSpace(Code)
				   || !string.IsNullOrWhiteSpace(ReturnCode)
					   && ReturnCode.ToUpper().Contains("ServerReturnedNOK")
				   || !string.IsNullOrWhiteSpace(Message))
				{
					return false;
				}
				return true;
			}
		}
		public M3QueryParameters QueryParameters { get; internal set; } = new M3QueryParameters();
		public int? MaxRecords { get; internal set; }

		#region HttpError

		public M3HttpStatus HttpStatus { get; internal set; } = new M3HttpStatus();

		#endregion HttpError

		#region M3 Error

		[JsonProperty("@code")]
		[DataMember(Name = "@code", EmitDefaultValue = false)]
		public string Code { get; set; }

		[JsonProperty("@field")]
		[DataMember(Name = "@field", EmitDefaultValue = false)]
		public string ErrorField { get; set; }

		[JsonProperty("@type")]
		[DataMember(Name = "@type", EmitDefaultValue = false)]
		public string ReturnCode { get; set; }

		#endregion

		[JsonProperty("Message")]
		[DataMember(Name = "Message", EmitDefaultValue = false)]
		public string Message { get; set; }

		[JsonProperty("Metadata")]
		[DataMember(Name = "Metadata", EmitDefaultValue = false)]
		public M3Metadata Metadata { get; set; } = new M3Metadata();

		[JsonProperty("MIRecord")]
		[DataMember(Name = "MIRecord", EmitDefaultValue = false)]
		public M3RecordList<T> Rows { get; set; } = new M3RecordList<T>();

		internal void CleanResults()
		{
			// Revist this and determine if we can pull this as an action of the reuqest.
			Code = Code?.Replace("  ", " ").Trim();
			ReturnCode = ReturnCode?.Replace("  ", " ").Trim();
			ErrorField = ErrorField?.Replace("  ", " ").Trim();
			Message = Message?.Replace("  ", " ").Trim();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			if (Rows == null)
				Rows = new M3RecordList<T>();
			if (Metadata == null)
				Metadata = new M3Metadata();
			if (HttpStatus == null)
				HttpStatus = new M3HttpStatus();

			return $"Code:{Code},ErrorField:{ErrorField},ReturnCode:{ReturnCode},Message:{Message},ReturnCode:{ReturnCode},MaxRecords:{MaxRecords.GetValueOrDefault()},Success:{Success},HttpStatus:{HttpStatus},QueryParameters:{QueryParameters},Metadata:[{Metadata}],Rows:[{Rows}]";
		}

		/// <summary>
		/// Gets the hash code
		/// </summary>
		/// <returns>Hash code</returns>
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;

				hashCode = hashCode * 59 + MaxRecords.GetValueOrDefault().GetHashCode();
				hashCode = hashCode * 59 + Success.GetHashCode();
				if (QueryParameters != null)
					hashCode = hashCode * 59 + QueryParameters.GetHashCode();
				if (HttpStatus != null)
					hashCode = hashCode * 59 + HttpStatus.GetHashCode();
				if (Code != null)
					hashCode = hashCode * 59 + Code.GetHashCode();
				if (ErrorField != null)
					hashCode = hashCode * 59 + ErrorField.GetHashCode();
				if (ReturnCode != null)
					hashCode = hashCode * 59 + ReturnCode.GetHashCode();
				if (Message != null)
					hashCode = hashCode * 59 + Message.GetHashCode();
				if (Metadata != null)
					hashCode = hashCode * 59 + Metadata.GetHashCode();
				if (Rows != null)
					hashCode = hashCode * 59 + Rows.GetHashCode();

				return hashCode;
			}
		}
	}
}