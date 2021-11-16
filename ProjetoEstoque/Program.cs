using System;
using System.Globalization;

namespace ProjetoEstoque
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto produto = new Produto("TV", 500.00, 10);
            Console.WriteLine(produto.Nome);
            produto.Nome = "TV 4K";
            Console.WriteLine(produto.Nome);










            //Console.WriteLine("Entre os dados do Produto:");
            //Console.Write("Nome: ");
            //string nome = Console.ReadLine();
            //Console.Write("Preço: ");
            //double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Produto produto = new Produto(nome, preco);

            //Console.WriteLine("Dados do produto: " + produto);

            //Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
            //int qte = int.Parse(Console.ReadLine());
            //produto.AdicionarProdutos(qte);
            //Console.WriteLine("\nDados atualizados: " + produto);

            //Console.Write("Digite o numero de produtos a ser removido do estoque: ");
            //int qtd = int.Parse(Console.ReadLine());
            //produto.RemoverProdutos(qtd);
            //Console.WriteLine("\nDados atualizados: " + produto);

        }
    }
}
