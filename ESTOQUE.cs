using System;
using System.Globalization;

namespace Estoque
{
    class Produtos
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            return Nome + ", R$" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " Unidades, Total = R$ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
