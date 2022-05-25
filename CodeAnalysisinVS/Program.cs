using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAnalysisinVS
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "John","Boby","Charig","Denis","Alfee","Bond" };
            var namesOfB = names.Where(n => n.StartsWith("B"));
        }
    }
}
