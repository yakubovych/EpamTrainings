namespace HomeworkStyleCoding
{
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
            int x, y, width, height;
            bool brake = false;
            Output.Write("Build to left bottom point, height and length");
            Output.Write("Input command what you want:\nMove Change Show Union Exit");
            Output.Write("Input x: ");
            int.TryParse(Output.Read(), out x);
            Output.Write("Input y: ");
            int.TryParse(Output.Read(), out y);
            Output.Write("Input width: ");
            int.TryParse(Output.Read(), out width);
            Output.Write("Input height: ");
            int.TryParse(Output.Read(), out height);
            int x2 = 3, y2 = 2, width2 = 3, height2 = 2;
            Rectangle rectangle = new Rectangle(x, y, width, height);

            // Here change for moves and changes.
            int changex = 1, changey = 1;
            int movex = 1, movey = 1;
            Output.Write("Input command: ");
            do
            {
                switch (Output.Read())
                {
                    case "Move": rectangle.Move(movex, movey, ref x, ref y); break;
                    case "Change": rectangle.Change(changex, changey, ref width, ref height); break;
                    case "Union": rectangle.Union(x, x2, y, y2, width, width2, height, height2); break;
                    case "Exit": brake = true; break;
                    default: Output.Write("Error input!"); break;
                }
            }
            while (!brake);
        }
    }
}