using System;
using System.Globalization;

namespace ProjetoEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Entre os dados do Produto:");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + produto);

            Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qte);
            Console.WriteLine("\nDados atualizados: " + produto);

            Console.Write("Digite o numero de produtos a ser removido do estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qtd);
            Console.WriteLine("\nDados atualizados: " + produto);

        }
    }
}
