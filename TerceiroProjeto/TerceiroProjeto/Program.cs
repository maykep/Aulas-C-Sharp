using System;
using System.Globalization;

namespace TerceiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            /* usando split com entrada de dados
            string[] vet = Console.ReadLine().Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            */
            //------------------------------
            /*convertendo string digitada
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine()); // para valor real com virgula separando
            double n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // para valor geral com ponto separando

            Console.WriteLine(ch);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3.ToString("F2", CultureInfo.InvariantCulture)); // para mostrar com . e não ,
            */
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
