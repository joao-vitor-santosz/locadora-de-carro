using LocadoraCarros.Models;
namespace LocadoraCarros.Algoritmos;

// Responsável: Marcus
// REGRAS:
// 1. NÃO altere nome, parâmetros ou tipo de retorno dos métodos.
// 2. NÃO modifique a lista recebida; trabalhe numa cópia.
// 3. NÃO use Sort(), OrderBy(), Where(), Find() nem BinarySearch().
//    Métodos de string (ToUpper, Contains, CompareTo) podem.
// 4. Teste pelo menu (dotnet run) antes de subir.
// categorias válidas: Sedan, Hatch, SUV, Picape.

public static class Selecao
{

    /// <summary>
    /// Seleciona apenas os carros disponíveis (Disponivel == true).
    /// Retorna uma lista nova, ou lista vazia se não houver nenhum (nunca null).
    /// </summary>
    public static List<Carro> SelecionarDisponiveis(List<Carro> carros)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Seleciona os carros de uma categoria, ignorando maiúsculas/minúsculas
    /// ("suv" encontra "SUV"). Retorna lista vazia se a categoria
    /// não existir ou não tiver carros (nunca null).
    /// </summary>
    public static List<Carro> SelecionarPorCategoria(List<Carro> carros, string categoria)
    {
        throw new NotImplementedException();
    }
}