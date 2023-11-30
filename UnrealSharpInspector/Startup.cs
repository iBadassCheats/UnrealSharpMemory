using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnrealSharpInspector
{
    internal class Startup
    {
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form_Inspector());
        }
    }
}
