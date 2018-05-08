using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args == null) throw new ArgumentNullException(nameof(args));
        }

        public int P1 { get; set; }
    }
}
