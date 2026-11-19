using LocadoraCarros.Models;
using LocadoraCarros.Dados;
using LocadoraCarros.Algoritmos;

Console.OutputEncoding = System.Text.Encoding.UTF8;

var carros = BaseDeCarros.ObterCarros();
int opcao;
do
{
    Console.Clear();
    Console.WriteLine("Escolha uma opção: ");

    Console.WriteLine("1 - Listar todos os carros");
    Console.WriteLine("2 - Ordenar por valor da diária");
    Console.WriteLine("3 - Ordenar por ano");
    Console.WriteLine("4 - Buscar por placa");
    Console.WriteLine("5 - Buscar por modelo");
    Console.WriteLine("6 - Carros disponíveis");
    Console.WriteLine("7 - Carros por categoria");
    Console.WriteLine("0 - Sair");

    opcao = int.TryParse(Console.ReadLine(), out opcao) ? opcao : -1;

    try
    {
        switch (opcao)
        {
            case 1:
                Console.WriteLine("Todos os carros:");
                ExibirLista(carros);
                break;
            case 2:
                Console.WriteLine("Carros ordenados por valor da diária:");
                ExibirLista(Ordenacao.OrdenarPorValorDiaria(carros));
                break;
            case 3:
                Console.WriteLine("Carros ordenados por ano:");
                ExibirLista(Ordenacao.OrdenarPorAno(carros));
                break;
            case 4:
                var placa = LerTexto("Digite a placa do carro: ");
                Console.WriteLine();
                var carroEncontrado = Busca.BuscarPorPlaca(carros, placa);
                if (carroEncontrado != null)
                {
                    Console.WriteLine("Carro encontrado:");
                    Console.WriteLine(carroEncontrado);
                }
                else
                {
                    Console.WriteLine("Carro não encontrado.");
                }
                break;
            case 5:
                var modelo = LerTexto("Digite o modelo do carro: ");
                Console.WriteLine();
                var carrosEncontrados = Busca.BuscarPorModelo(carros, modelo);
                Console.WriteLine($"Carros do modelo {modelo}:");
                ExibirLista(carrosEncontrados);
                break;
            case 6:
                Console.WriteLine("Carros disponíveis:");
                ExibirLista(Selecao.SelecionarDisponiveis(carros));
                break;
            case 7:
                var categoria = LerTexto("Digite a categoria do carro (Sedan, Hatch, SUV, Picape): ");
                Console.WriteLine();
                Console.WriteLine($"Carros da categoria {categoria}:");
                ExibirLista(Selecao.SelecionarPorCategoria(carros, categoria));
                break;
            case 0:
                Console.WriteLine("Saindo...");
                break;
            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;

        }
    }
    catch (NotImplementedException)
    {
        Console.WriteLine("Funcionalidade em desenvolvimento.");
    }

    if (opcao != 0)
    {
        Console.WriteLine("Pressione Enter para continuar...");
        Console.ReadLine();
    }
} while (opcao != 0);

static void ExibirLista(List<Carro> lista)
{

    if (lista.Count > 0)
    {
        foreach (var carro in lista)
        {
            Console.WriteLine(carro);
        }
    }
    else
    {
        Console.WriteLine("Nenhum carro encontrado.");
    }
}

static string LerTexto(string mensagem)
{
    Console.Write(mensagem);
    return (Console.ReadLine() ?? "").Trim();
}