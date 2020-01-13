using System;
using McMaster.Extensions.CommandLineUtils;

namespace Consola
{
    internal class Program
    {
        private static void Main(string[] args) => CommandLineApplication.Execute<Program>(args);

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Code Quality", "IDE0051:Remove unused private members", Justification = "Private member is invoked from .Execute<Program>")]
        private void OnExecute()
        {
            Console.WriteLine($"Hello world!");

            if (System.Diagnostics.Debugger.IsAttached)
                Console.Read();
        }
    }
}
