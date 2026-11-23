using LocadoraCarros.Models;
namespace LocadoraCarros.Algoritmos;

public static class Busca
{
    public static Carro? BuscarPorPlaca(List<Carro> carros, string placa)
    {
        var lista = new List<Carro>(carros);

        for (int i = 0; i < lista.Count - 1; i++)
        {
            for (int j = 0; j < lista.Count - 1 - i; j++)
            {
                if (string.Compare(lista[j].Placa, lista[j + 1].Placa, StringComparison.OrdinalIgnoreCase) > 0)
                {
                    (lista[j], lista[j + 1]) = (lista[j + 1], lista[j]);
                }
            }
        }
        int inicio = 0;
        int fim = lista.Count - 1;

        while (inicio <= fim)
        {
            int meio = (inicio + fim) / 2;

            int comparacao = string.Compare(lista[meio].Placa, placa, StringComparison.OrdinalIgnoreCase);

            if (comparacao == 0)
            {
                return lista[meio];
            }
            else if (comparacao < 0)
            {
                inicio = meio + 1;
            }
            else
            {
                fim = meio - 1;
            }
        }

        return null;
    }

    public static List<Carro> BuscarPorModelo(List<Carro> carros, string termo)
    {
        var resultado = new List<Carro>();

        if (string.IsNullOrWhiteSpace(termo))
        {
            return resultado;
        }

        foreach (var carro in carros)
        {
            if (carro.Modelo.Contains(termo, StringComparison.OrdinalIgnoreCase))
            {
                resultado.Add(carro);
            }
        }

        return resultado;
    }
}