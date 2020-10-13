using System;
using System.Globalization;

namespace SextoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();
            Console.WriteLine("Entre a largura e altura do retângulo: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Altura= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Area = " + r.Area());
            Console.WriteLine("Perimetro = " + r.Perimetro());
            Console.WriteLine("Diagonal = " + r.Diagonal());
        }
    }
}
