/*

Sistema de Controle de Estoque
Objetivo: Criar um sistema para gerenciar o estoque de produtos de uma loja.

Requisitos:
Adicionar, remover e listar produtos no estoque.
Atualizar a quantidade de produtos no estoque.
OK Utilizar enums para representar a categoria dos produtos.
OK Implementar uma interface IProdutoEstoque com métodos como AdicionarEstoque, RemoverEstoque e ExibirInformacoes.

*/

using System.Globalization;
using ControleEstoque.Entities;
using ControleEstoque.Entities.enums;

namespace ControleEstoque {

    public class Program {

        static void Main(string[]args ){

        List<Product> produtos = new List<Product>();
        
        bool continuar = true;
        while (continuar) {

            Console.Write("Digite o ID do Produto: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Digite o Nome do produto: ");
            string? name = Console.ReadLine();

            Console.Write("Digite o Preço do Produto: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite a Categoria do Produto: ");
            Category categoria = (Category)Enum.Parse(typeof(Category), Console.ReadLine());

            produtos.Add(new Product(id, name, price, categoria));
        
            Console.Write("Deseja adicionar outro produto? [S/N]");
            string usuarioContinuar = Console.ReadLine().ToLower();

            if (usuarioContinuar == "n" || usuarioContinuar == "nao"){
                continuar = false;
            }


            }

            foreach (Product produto in produtos){
                Console.WriteLine(produto.ExibirInformacoes());
            }

        }
    }
}
