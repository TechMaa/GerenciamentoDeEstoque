using System;
using System.Globalization;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produtos p = new Produtos(); 

            Console.WriteLine("Entre com os dadoas do produto: ");
            Console.Write("NOME: ");
            p.Nome = Console.ReadLine();
            Console.Write("PREÇO: R$");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("QUANTIDADE DO PRODUTO: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("DADOS DO PRODUTO: " + p);

            Console.WriteLine();
            Console.Write("DIGITE A QUANTIDADE DE PRODUTOS A SEREM ADICIONADOS NO ESTOQUE: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);


            Console.WriteLine();
            Console.WriteLine("QUANTIDADE ADICIONADA / DADOS ATUALIZADOS: " + p);
            Console.WriteLine();

            Console.Write("DIGITE A QUANTIDADE DE PRODUTOS A SEREM REMOVIDOS NO ESTOQUE: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("QUANTIDADE REMOVIDA / DADOS ATUALIZADOS: " + p);

        }
    }
}