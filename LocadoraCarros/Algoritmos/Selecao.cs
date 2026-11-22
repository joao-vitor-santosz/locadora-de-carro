
using System;
using System.Collections.Generic;
using LocadoraCarros.Models;

namespace LocadoraCarros.Algoritmos
{
    public static class Selecao
    {
        public static List<Carro> SelecionarDisponiveis(List<Carro> carros)
        {
            var resultado = new List<Carro>();

            foreach (var carro in carros)
            {
                if (carro.Disponivel)
                {
                    resultado.Add(carro);
                }
            }

            return resultado;
        }

        public static List<Carro> SelecionarPorCategoria(List<Carro> carros, string categoria)
        {
            var resultado = new List<Carro>();

            foreach (var carro in carros)
            {
                if (string.Equals(carro.Categoria, categoria, StringComparison.OrdinalIgnoreCase))
                {
                    resultado.Add(carro);
                }
            }

            return resultado;
        }
    }
}
