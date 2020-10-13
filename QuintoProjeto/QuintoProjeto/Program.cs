using System;
using System.Globalization;

namespace QuintoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            Console.WriteLine("Entre os dados do produto:");

            Console.Write("Nome:");
            p.Nome = Console.ReadLine();
            
            Console.Write("Preco:");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           
            Console.Write("Quantidade no Estoque:");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Dados do produto:" + p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser adicionado no estoque: ");
            int qte= int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados:" + p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser removidos no estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados:" + p);
        }
    }
}
