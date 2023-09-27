using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtvExtra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Filipe", "Rafael", "Rosen" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");

                Console.WriteLine($"Hello {name.ToLower()}!");

                Console.WriteLine($"Hello {name.Length}!");
            }
        }
    }
}
