namespace HomeworkSerialization
{
    using System.Collections.Generic;

    public interface Iserialize<T>
    {
        void SerializeBinary(List<T> objects);

        void SerializeXML(List<T> objects);

        string SerializeJson(List<T> objects);

        List<T> DeserializeBinary();

        List<T> DeserializeXML();

        List<T> DeserializeJson(string jsonData);
    }
}
