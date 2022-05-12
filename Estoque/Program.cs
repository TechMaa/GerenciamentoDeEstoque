using System;
using System.Globalization;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1;

            Console.WriteLine("ENTRE COM OS DADOS DO PRODUTO:");
            Console.Write("NOME DO PRODUTO: ");
            string Nome = Console.ReadLine();
            Console.Write("PREÇO DO PRODUTO: R$");
            double Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("QUANTIDADE DO PRODUTO: ");
            int Quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(Nome, Preco, Quantidade);

            Console.WriteLine();
            Console.WriteLine("DADOS DO PRODUTO: " + p);
            Console.WriteLine();
            Console.Write("DIGITE O NUMERO DE PRODUTOS A SEREM ADICIONADOS NO ESTOQUE: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("DADOS ATUALIZADOS: " + p);
            Console.WriteLine();
            Console.WriteLine("QUER RETIRAR ALGUMA QUANTIDADE DO ESTOQUE?");
            Console.WriteLine("DIGITE 1: SIM");
            Console.WriteLine("DIGITE 2: NÃO");
            n1 = int.Parse(Console.ReadLine());

            if(n1 == 1)
            {
                Console.Write("DIGITE O NUMERO DE PRODUTOS QUE QUEIRA RETIRAR DO ESTOQUE: ");
                qte = int.Parse(Console.ReadLine());
                p.RemoverProdutos(qte);
                Console.WriteLine();
                Console.WriteLine("Dados atualizados: " + p);
            }
            else
            {
                Console.WriteLine("Dados atualizados: " + p);
            }
        }
    }
}