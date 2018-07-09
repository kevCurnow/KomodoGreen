using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoGreen.UI
{
    public interface IConsole
    {
        void WriteLine(string message);
        void Write(string message);
        string ReadLine();
        void WriteLine(Object o);
    }
}
