using ControleEstoque.Entities.enums;

namespace ControleEstoque.Entities {

    public class Product : IProduto {
        public int Id {get; private set;}
        public string Name {get; private set;}
        public double Price {get; set;}
        public Category Category {get; set;}

        public Product() { }

        public Product(int id, string name, double price, Category category) {
            Name = name;
            Id = id;
            Price = price;
            Category = category;

         }

        public void AdicionarEstoque(){



        }

        public void RemoverEstoque(){

            

        }

        public string ExibirInformacoes(){

            return $"ID: {Id}\nNome: {Name}\nPreço: {Price}\nCategoria: {Category}";

        }

    }

}