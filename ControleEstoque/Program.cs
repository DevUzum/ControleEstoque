using ControleEstoque;

//Opção que será informada pelo usuário.
int opcao;

//Configurando o indice inicial como 1
int indiceListaProdutos = 1;

//Lista dos produtos em estoque
List<Produto> produtos = new List<Produto>();

//Fluxo principal onde são apresentadas as opções para a interação do usuário
do
{
    Console.WriteLine("\r [1] Novo \r\n [2] Listar Produtos \r\n [3] Remover Produtos \r\n [4] Entrada Estoque \r\n [5] Saída Estoque \r\n [0] Sair");

    if (int.TryParse(Console.ReadLine(), out opcao))
    {
        switch (opcao)
        {
            case 1:
                CadastrarProduto(produtos);
                break;
            case 2:
                ListarProdutos(indiceListaProdutos, produtos);
                break;
            case 3:
                RemoverProduto(produtos);
                break;
            case 4:
                IncluirNoEstoque(produtos);
                break;
            case 5:
                RemoverDoEstoque(produtos);
                break;
            case 0:
                break;
            default:
                Console.WriteLine("Opção inválida. Escolha novamente.");
                break;
        }
    }
    else
    {
        Console.WriteLine("Opção inválida. Escolha novamente.");
    }

    Console.WriteLine();
} while (opcao != 0);

//Métodos abaixo para manipulação dos dados de produto/estoque
static void CadastrarProduto(List<Produto> produtos)
{
    Console.WriteLine("\nInforme o nome do perfume:");
    var nomePerfume = Console.ReadLine();

    Console.WriteLine("\nInforme o preço:");
    var precoPerfume = Console.ReadLine();

    Console.WriteLine("\nInforme a quantidade:");
    var quantidadePerfume = Console.ReadLine();

    Console.WriteLine("\nInforme a descrição:");
    var descricaoPerfume = Console.ReadLine();

    Console.WriteLine("\nInforme a categoria:");
    var categoriaPerfume = Console.ReadLine();

    Console.WriteLine("\nInforme a fabricante:");
    var fabricantePerfume = Console.ReadLine();

    produtos.Add(new Produto
    {
        Nome = nomePerfume,
        Preco = Convert.ToDecimal(precoPerfume),
        QuantidadeEstoque = Convert.ToInt32(quantidadePerfume),
        Descricao = descricaoPerfume,
        Categoria = categoriaPerfume,
        Fabricante = fabricantePerfume
    });
}

static void ListarProdutos(int indiceListaProdutos, List<Produto> produtos)
{
    Console.WriteLine("\n:::Produtos no estoque");

    foreach (Produto produto in produtos)
    {
        Console.WriteLine(
            $"{indiceListaProdutos}. " +
            $"{produto.Nome} " +
            $"(R${produto.Preco}) - " +
            $"Estoque: {produto.QuantidadeEstoque} - " +
            $"Descrição: {produto.Descricao} - " +
            $"Categoria: {produto.Categoria} - " +
            $"Fabricante: {produto.Fabricante}");

        indiceListaProdutos++;
    }
}

static void RemoverProduto(List<Produto> produtos)
{
    Console.WriteLine("Informe a posição do perfume a ser removido:");
    var posicao = Convert.ToInt32(Console.ReadLine());
    produtos.RemoveAt(posicao - 1);
}

static void IncluirNoEstoque(List<Produto> produtos)
{
    Console.WriteLine("\nInforme a posição do perfume:");
    var posicaoPerfume = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\nInforme a quantidade de Entrada:");
    var quantidadeEntrada = Convert.ToInt32(Console.ReadLine());

    var produtoEscolhido = produtos[posicaoPerfume - 1];
    produtoEscolhido.QuantidadeEstoque += quantidadeEntrada;
}

static void RemoverDoEstoque(List<Produto> produtos)
{
    Console.WriteLine("\nInforme a posição do perfume:");
    var posicaoPerfume = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\nInforme a quantidade de Saída:");

    var quantidadeEntrada = Convert.ToInt32(Console.ReadLine());
    var produtoEscolhido = produtos[posicaoPerfume - 1];
    produtoEscolhido.QuantidadeEstoque -= quantidadeEntrada;
}