using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionExample
{
    class Math
    {
        public void Sum()
        {
            Console.WriteLine("\nSUM method");
        }
        public void Sub()
        {
            Console.Write("\nSUB Method");
        }
    }
    static class MathExtension
    {
        public static void Div(this Math mathobj1 )
        {
            Console.WriteLine("\nDIV method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Math mathobj = new Math();
            mathobj.Sub();
            mathobj.Sum();
            mathobj.Div();
            Console.ReadKey();
        }
    }
}
