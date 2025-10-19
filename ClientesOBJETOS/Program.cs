using System;
using System.Globalization;
using ClasseProduto;
using ClasseAdicionar;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.Write("Nome do produto: ");
            produto.nome = Console.ReadLine();

            Console.Write("Preço: ");
            produto.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade inicial: ");
            produto.quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"\ Produto cadastrado: {produto.nome}, {produto.quantidade} unidades, Preço: R${produto.preco:F2}\n");

            AdicionandoProduto manipulador = new AdicionandoProduto();

            manipulador.Adicionar(produto);
            Console.WriteLine($"Quantidade atual: {produto.quantidade}");

            manipulador.Remover(produto);
            Console.WriteLine($"Quantidade atual: {produto.quantidade}");
        }
    }
}
