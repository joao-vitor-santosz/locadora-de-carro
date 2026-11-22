
using LocadoraCarros.Models;
namespace LocadoraCarros.Algoritmos;

public static class Ordenacao
{
    public static List<Carro> OrdenarPorValorDiaria(List<Carro> carros)
    {
        var lista = new List<Carro>(carros);

        for (int i = 0; i < lista.Count - 1; i++)
        {
            for (int j = 0; j < lista.Count - 1 - i; j++)
            {
                if (lista[j].ValorDiaria > lista[j + 1].ValorDiaria)
                {
                    (lista[j], lista[j + 1]) = (lista[j + 1], lista[j]);
                }
            }
        }

        return lista;
    }

    public static List<Carro> OrdenarPorAno(List<Carro> carros)
    {
        var lista = new List<Carro>(carros);

        for (int i = 0; i < lista.Count - 1; i++)
        {
            int indiceMaisNovo = i;

            for (int j = i + 1; j < lista.Count; j++)
            {
                if (lista[j].Ano > lista[indiceMaisNovo].Ano)
                {
                    indiceMaisNovo = j;
                }
            }

            if (indiceMaisNovo != i)
            {
                (lista[i], lista[indiceMaisNovo]) =
                    (lista[indiceMaisNovo], lista[i]);
            }
        }

        return lista;
    }
}
