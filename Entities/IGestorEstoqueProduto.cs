namespace ControleEstoque.Entities{

    interface IGestorEstoqueProduto{
        void AdicionarEstoque();
        void RemoverEstoque();
        string ExibirInformacoes();

    }

}