namespace M3H5Lib.Models
{
    public interface IM3Record
    {
        int RowIndex { get; }
        bool ContainsField(string key);
        string this[string index] { get; }
        void TrimResults();
        int Count { get; }  
    }
}
