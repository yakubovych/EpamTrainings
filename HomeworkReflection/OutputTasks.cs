namespace HomeworkReflection
{
    using System;
    using System.Reflection;
    using LibraryOfProject;

    public class OutputTasks
    {
        private IConsole Output;
        Assembly asm = Assembly.LoadFrom(@"C:\repo\EpamTrainings\HomeworkStructures\bin\Debug\netcoreapp2.1\HomeworkStructures.dll");

        public OutputTasks(IConsole Output)
        {
            this.Output = Output;
        }

        public void RunTasks()
        {
            foreach (Type t in asm.GetExportedTypes())
            {
                Console.WriteLine($"{t.ToString()}");
                foreach (MemberInfo m in t.GetMembers())
                {
                    if (m.MemberType == MemberTypes.Method)
                    {
                        foreach (ParameterInfo p in ((MethodInfo)m).GetParameters())
                        {
                            Output.Write($"Method type: {m}, ParametreInfo: {p}");
                        }
                    }
                }

                Console.WriteLine();
            }
        }
    }
}