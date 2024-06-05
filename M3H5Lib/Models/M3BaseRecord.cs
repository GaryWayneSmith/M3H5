using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace M3H5Lib.Models
{
    public abstract class M3BaseRecord : IM3Record
    {
        public int RowIndex { get; set; }

        [JsonProperty("NameValue")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "This can be set by the caller when needed")]
        public IList<M3Field> Fields { get; set; } = new List<M3Field>();

        public bool HasConversionError { get; set; }
        public string ConversionErrorMessage { get; set; }

        public bool ContainsField(string key)
        {
            return Fields.Any(fv => fv.Key == key);
        }

        public virtual void TrimResults() { }

        public int Count { get { return Fields.Count; } }

        public string this[string key]
        {
            get
            {
                return Fields
                    .Where(fv => string.Equals(fv.Key, key, StringComparison.OrdinalIgnoreCase))
                    .Select(fv => fv.Value)
                    .DefaultIfEmpty(null)
                    .First();
            }
            set
            {
                M3Field field = Fields.FirstOrDefault(fv => fv.Key == key);
                if (field == null)
                {
                    Fields.Add(new M3Field { Key = key, Value = value });
                }
                else
                {
                    field.Value = value;
                }
            }
        }

        internal void CleanResults()
        {
            if (Fields == null)
                Fields = new List<M3Field>();

            foreach (M3Field Field in Fields)
                Field.CleanValue();
        }

        public override string ToString()
        {
            if (Fields == null)
                Fields = new List<M3Field>();

            return $"RowIndex:{RowIndex},HasConversionError:{HasConversionError},ConversionErrorMessage:{ConversionErrorMessage},Fields:[{string.Join(";", Fields.Select(fv => fv.ToString()))}]";
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

                hashCode = hashCode * 59 + RowIndex.GetHashCode();
                hashCode = hashCode * 59 + HasConversionError.GetHashCode();
                if (ConversionErrorMessage != null)
                    hashCode = hashCode * 59 + ConversionErrorMessage.GetHashCode();

                foreach (M3Field field in Fields)
                    hashCode = hashCode * 59 + field.GetHashCode();
                return hashCode;
            }
        }

        #region Protected Conversion methods

        protected string GetString(string key)
        {
            string value = this[key];
            if (!string.IsNullOrWhiteSpace(value))
                return value.Trim();
            else
                return string.Empty;
        }

        protected DateTime GetDateTime(string key)
        {
            string value = this[key];
            if (!string.IsNullOrWhiteSpace(value))
                return DateTime.ParseExact(value, "yyyyMMdd", CultureInfo.InvariantCulture);
            else
                return DateTime.MinValue.Date;
        }

        protected DateTime? GetNullableDateTime(string key)
        {
            string value = this[key];
            if (!string.IsNullOrWhiteSpace(value))
                return DateTime.ParseExact(value, "yyyyMMdd", CultureInfo.InvariantCulture);
            else
                return null;
        }

        protected int GetInt(string key)
        {
            string value = this[key];
            if (!string.IsNullOrWhiteSpace(value))
                return Convert.ToInt32(this[key], CultureInfo.CurrentCulture);
            else
                return 0;
        }

        protected int? GetNullableInt(string key)
        {
            string value = this[key];
            if (!string.IsNullOrWhiteSpace(value))
                return Convert.ToInt32(this[key], CultureInfo.CurrentCulture);
            else
                return null;
        }

        protected long GetLong(string key)
        {
            string value = this[key];
            if (!string.IsNullOrWhiteSpace(value))
                return Convert.ToInt64(this[key], CultureInfo.CurrentCulture);
            else
                return 0;
        }

        protected long? GetNullableLong(string key)
        {
            string value = this[key];
            if (!string.IsNullOrWhiteSpace(value))
                return Convert.ToInt64(this[key], CultureInfo.CurrentCulture);
            else
                return null;
        }

        protected decimal GetDecimal(string key)
        {
            string value = this[key];
            if (!string.IsNullOrWhiteSpace(value))
                return Convert.ToDecimal(this[key], CultureInfo.CurrentCulture);
            else
                return 0m;
        }

        protected decimal? GetNullableDecimal(string key)
        {
            string value = this[key];
            if (!string.IsNullOrWhiteSpace(value))
                return Convert.ToDecimal(this[key], CultureInfo.CurrentCulture);
            else
                return null;
        }

        #endregion Protected Conversion methods
    }
}