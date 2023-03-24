using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class ProtectedStudent
    {
        // Kui meetod on protected siis ei saa seda kasutada teistest classides
        protected void DoSomething()
        {
            Console.WriteLine("asdasdasdasdasd");
        }
    }
}
