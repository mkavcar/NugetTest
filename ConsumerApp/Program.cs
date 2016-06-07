using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NugetTestLib;

namespace ConsumerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
                Console.WriteLine(Serializer.toJson(new { Field1 = args[0] }));

            Console.ReadLine();
        }
    }
}
