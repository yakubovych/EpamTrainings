namespace HomeworkSerialization
{
    using System;

    [Serializable]
    public class Client
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public void Info()
        {
            Console.WriteLine($"Id of client: {Id}, Name: {Name}.");
        }
    }
}
