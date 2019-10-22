namespace HomeworkSerialization
{
    using System.Collections.Generic;
    using LibraryOfProject;

    public class OutputTasks
    {
        private IConsole Output;

        public OutputTasks(IConsole Output)
        {
            this.Output = Output;
        }

        public void RunTasks()
        {
            List<Client> clientb = new List<Client>();
            clientb.Add(new Client { Id = 23, Name = "Binary1" });
            clientb.Add(new Client { Id = 31, Name = "Binary2" });

            Serializator serialize = new Serializator();
            serialize.SerializeBinary(clientb);
            List<Client> deserialize = new List<Client>();
            deserialize = serialize.DeserializeBinary();
            foreach (var clients in deserialize)
            {
                this.Output.Write(clientb.ToString());
            }

            List<Client> clientx = new List<Client>();
            clientx.Add(new Client { Id = 23, Name = "XML1" });
            clientx.Add(new Client { Id = 31, Name = "XML2" });
            serialize.SerializeXML(clientx);
            deserialize = new List<Client>();
            deserialize = serialize.DeserializeXML();
            foreach (var clients in deserialize)
            {
                this.Output.Write(clientx.ToString());
            }

            List<Client> clientj = new List<Client>();
            clientj.Add(new Client { Id = 23, Name = "JSON1" });
            clientj.Add(new Client { Id = 31, Name = "JSON2" });
            string jsonClient = serialize.SerializeJson(clientj);
            deserialize = new List<Client>();
            deserialize = serialize.DeserializeJson(jsonClient);
            foreach (var clients in deserialize)
            {
                this.Output.Write(clientj.ToString());
            }
        }
    }
}
