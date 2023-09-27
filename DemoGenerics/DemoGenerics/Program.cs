using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Generics<int> generics = new Generics<int>(10);
            Generics<string> genericString = new Generics<string>("uday");
            Generics<double> genericDouble = new Generics<double>(10.09);
            Console.WriteLine();
            generics.DemoMethod(721);
            genericString.DemoMethod("kumar");
            genericDouble.DemoMethod(99.45);
            Generic generic = new Generic();
            generic.GenericMethod(5);
            generic.GenericMethod("uday");
            generic.GenericMethod(93.94);
            generic.GenericMethod<int>(5);
            generic.GenericMethod<string>("uday");
            generic.GenericMethod<double>(93.94);
            Console.ReadLine();
        }
    }
}
