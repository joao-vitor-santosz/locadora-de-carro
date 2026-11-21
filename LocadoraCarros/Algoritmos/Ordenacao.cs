
using LocadoraCarros.Models;

namespace LocadoraCarros.Algoritmos;

// Responsável: Bernardo
// REGRAS:
// 1. NÃO altere nome, parâmetros ou tipo de retorno dos métodos.
// 2. NÃO modifique a lista recebida; trabalhe numa cópia.
// 3. NÃO use Sort(), OrderBy(), Where(), Find() nem BinarySearch().
// 4. Teste pelo menu (dotnet run) antes de subir.

public static class Ordenacao
{
    /// <summary>
    /// Ordena os carros pelo valor da diária,
    /// do MAIS BARATO para o mais caro.
    /// Retorna uma lista nova.
    /// </summary>
    public static List<Carro> OrdenarPorValorDiaria(List<Carro> carros)
    {
        // Cria uma cópia da lista original
        var lista = new List<Carro>(carros);

        // Algoritmo Bubble Sort
        for (int i = 0; i < lista.Count - 1; i++)
        {
            for (int j = 0; j < lista.Count - 1 - i; j++)
            {
                // Compara o valor da diária de dois carros
                if (lista[j].ValorDiaria > lista[j + 1].ValorDiaria)
                {
                    // Troca os carros de posição
                    (lista[j], lista[j + 1]) = (lista[j + 1], lista[j]);
                }
            }
        }

        // Retorna a lista ordenada
        return lista;
    }

    /// <summary>
    /// Ordena os carros pelo ano,
    /// do MAIS NOVO para o mais antigo.
    /// Retorna uma lista nova.
    /// </summary>
    public static List<Carro> OrdenarPorAno(List<Carro> carros)
    {
        // Cria uma cópia da lista original
        var lista = new List<Carro>(carros);

        // Algoritmo Selection Sort
        for (int i = 0; i < lista.Count - 1; i++)
        {
            // Considera o primeiro carro como o mais novo
            int indiceMaisNovo = i;

            // Procura o carro mais novo no restante da lista
            for (int j = i + 1; j < lista.Count; j++)
            {
                if (lista[j].Ano > lista[indiceMaisNovo].Ano)
                {
                    indiceMaisNovo = j;
                }
            }

            // Troca o carro mais novo para a posição correta
            if (indiceMaisNovo != i)
            {
                (lista[i], lista[indiceMaisNovo]) =
                    (lista[indiceMaisNovo], lista[i]);
            }
        }

        // Retorna a lista ordenada
        return lista;
    }
}
