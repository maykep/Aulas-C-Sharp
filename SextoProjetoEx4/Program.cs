using System;
using System.Globalization;

namespace SextoProjetoEx4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar?");
            Console.WriteLine();
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar?");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            double result = ConversorDeMoeda.DolarParaReal(cotacao, quantia);
            Console.WriteLine("Valor a ser pago em reais= " + result.ToString("F2", CultureInfo.InvariantCulture)); ;

        }
    }
}
