using ClasseProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ClasseAdicionar
{
    class AdicionandoProduto
    {
        public int Adicionar(Produto Adicionaproduto)
        {
            Console.Write("Digite a quantidade dos produtos a acrescentar: ");
            int acrescentando = int.Parse(Console.ReadLine());

            int quantidadeExistente = Adicionaproduto.quantidade;
            int soma = quantidadeExistente + acrescentando;

            Adicionaproduto.quantidade = soma; // atualiza o valor dentro do objeto

            if (soma > quantidadeExistente)
            {
                Console.WriteLine("Produto adicionado com sucesso!");
            }

            return soma; // retorna a nova quantidade total


        }


        public int Remover(Produto produto)
        {
            Console.WriteLine("Digite a quantidade dos produtos a remover: ");
            int quantidadeRemovida = int.Parse(Console.ReadLine());

            int quantidadeExistente = produto.quantidade;

            int subtracao = quantidadeExistente - quantidadeRemovida;

            produto.quantidade = subtracao; // atualiza o valor dentro do objeto


            if (quantidadeExistente < subtracao)
            {
                Console.WriteLine("Produto removido com sucesso!");
            }

            return subtracao; // retorna a nova quantidade total
        }

    }

}
