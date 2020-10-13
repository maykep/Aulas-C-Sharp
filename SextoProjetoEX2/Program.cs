using System;
using System.Globalization;

namespace SextoProjetoEX2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionario: " + f);

            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double per = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(per);

            Console.WriteLine("Dados Atualizados: " + f);
        }
    }
}
