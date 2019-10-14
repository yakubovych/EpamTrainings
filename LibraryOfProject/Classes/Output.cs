namespace LibraryOfProject
{
    using System;

    public class Output : IConsole
    {
        public string Read()
        {
            return Console.ReadLine();
        }

        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
