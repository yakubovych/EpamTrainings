namespace HomeworkSerialization
{
    using System.Collections.Generic;
    using System.Configuration;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Xml.Serialization;
    using Newtonsoft.Json;
    using LibraryOfProject;

    public class Serializator : Iserialize<Client>
    {
        public string PathForBinary = ConfigurationManager.AppSettings["PathForBinary"].ToString();

        public string PathForXml = ConfigurationManager.AppSettings["PathForXml"].ToString();

        public void SerializeBinary(List<Client> objects)
        {
            using (FileStream fs = new FileStream(this.PathForBinary, FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, objects);
            }
        }

        public void SerializeXML(List<Client> objects)
        {
            using (FileStream fs = new FileStream(this.PathForXml, FileMode.Create))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<Client>));
                formatter.Serialize(fs, objects);
            }
        }

        public string SerializeJson(List<Client> objects)
        {
            string jsonSerializeData = JsonConvert.SerializeObject(objects);

            return jsonSerializeData;
        }

        public List<Client> DeserializeBinary()
        {
            using (FileStream fs = new FileStream(this.PathForBinary, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                List<Client> newClient;
                newClient = (List<Client>)formatter.Deserialize(fs);
                return newClient;
            }
        }

        public List<Client> DeserializeXML()
        {
            using (FileStream fs = new FileStream(this.PathForXml, FileMode.Open))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<Client>));
                List<Client> newClient;
                newClient = (List<Client>)formatter.Deserialize(fs);
                return newClient;
            }
        }

        public List<Client> DeserializeJson(string jsonSerializeData)
        {
            return JsonConvert.DeserializeObject<List<Client>>(jsonSerializeData);
        }
    }
}
