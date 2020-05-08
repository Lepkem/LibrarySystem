namespace LibraryStandard.Interfaces
{
    using LibraryStandard.Helpers;

    public interface IDataOperator
    {
        DataOperator Instance { get; }

        T DeserializeJson<T>(string strValue);

        string SerializeJson(object objToSave);

        string ReadFromFile(string filepath);

        void WriteToFile(string content, string filepath);
    }
}