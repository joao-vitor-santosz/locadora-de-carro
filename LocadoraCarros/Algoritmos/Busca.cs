using LocadoraCarros.Models;
namespace LocadoraCarros.Algoritmos;

// Responsável: Vinicius
// REGRAS:
// 1. NÃO altere nome, parâmetros ou tipo de retorno dos métodos.
// 2. NÃO modifique a lista recebida; trabalhe numa cópia.
// 3. NÃO use Sort(), OrderBy(), Where(), Find() nem BinarySearch().
//    Métodos de string (ToUpper, Contains, CompareTo) podem.
// 4. Teste pelo menu (dotnet run) antes de subir.

public static class Busca
{
    /// <summary>
    /// Busca BINÁRIA pela placa exata. Antes de buscar, ordene uma CÓPIA
    /// da lista por placa (a busca binária só funciona em lista ordenada).
    /// Ignora maiúsculas/minúsculas ("abc1d34" encontra "ABC1D34").
    /// Retorna o carro encontrado ou null se não existir.
    /// </summary>
    public static Carro? BuscarPorPlaca(List<Carro> carros, string placa)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Busca LINEAR pelo modelo. Aceita termo parcial e ignora
    /// maiúsculas/minúsculas ("oni" encontra os dois Onix).
    /// Retorna todos os carros encontrados, ou lista vazia (nunca null).
    /// </summary>
    public static List<Carro> BuscarPorModelo(List<Carro> carros, string termo)
    {
        throw new NotImplementedException();
    }
}