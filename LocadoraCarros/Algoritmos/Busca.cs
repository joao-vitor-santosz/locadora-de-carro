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
        // Cria uma cópia da lista original
        var lista = new List<Carro>(carros);

        // Etapa 1: ordena a cópia por placa (Bubble Sort)
        for (int i = 0; i < lista.Count - 1; i++)
        {
            for (int j = 0; j < lista.Count - 1 - i; j++)
            {
                // Se a placa da esquerda vem depois da placa da direita, troca
                if (string.Compare(lista[j].Placa, lista[j + 1].Placa, StringComparison.OrdinalIgnoreCase) > 0)
                {
                    (lista[j], lista[j + 1]) = (lista[j + 1], lista[j]);
                }
            }
        }

        // Etapa 2: busca binária na cópia ordenada
        int inicio = 0;
        int fim = lista.Count - 1;

        while (inicio <= fim)
        {
            // Pega a posição do meio do trecho que ainda sobra
            int meio = (inicio + fim) / 2;

            int comparacao = string.Compare(lista[meio].Placa, placa, StringComparison.OrdinalIgnoreCase);

            if (comparacao == 0)
            {
                // Achou a placa
                return lista[meio];
            }
            else if (comparacao < 0)
            {
                // A placa do meio vem antes da procurada: descarta a metade da esquerda
                inicio = meio + 1;
            }
            else
            {
                // A placa do meio vem depois da procurada: descarta a metade da direita
                fim = meio - 1;
            }
        }

        // O laço terminou sem achar
        return null;
    }

    /// <summary>
    /// Busca LINEAR pelo modelo. Aceita termo parcial e ignora
    /// maiúsculas/minúsculas ("oni" encontra os dois Onix).
    /// Retorna todos os carros encontrados, ou lista vazia (nunca null).
    /// </summary>
    public static List<Carro> BuscarPorModelo(List<Carro> carros, string termo)
    {
        // Lista vazia para guardar o resultado
        var resultado = new List<Carro>();

        // Se nada foi digitado, não há o que buscar
        if (string.IsNullOrWhiteSpace(termo))
        {
            return resultado;
        }

        // Busca linear: olha carro por carro, do primeiro ao último
        foreach (var carro in carros)
        {
            // Verifica se o modelo contém o termo digitado
            if (carro.Modelo.Contains(termo, StringComparison.OrdinalIgnoreCase))
            {
                resultado.Add(carro);
            }
        }

        // Retorna os carros encontrados
        return resultado;
    }
}