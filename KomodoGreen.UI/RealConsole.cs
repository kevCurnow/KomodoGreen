using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoGreen.UI
{
    [ExcludeFromCodeCoverage]
    class RealConsole : IConsole
    {
        public void WriteLine(string message)
        {
            System.Console.WriteLine(message);
        }

        public void Write(string message)
        {
            System.Console.Write(message);
        }

        public string ReadLine()
        {
            return System.Console.ReadLine();
        }

        public void WriteLine(object o)
        {
            System.Console.WriteLine(o.ToString());
        }
    }
}
