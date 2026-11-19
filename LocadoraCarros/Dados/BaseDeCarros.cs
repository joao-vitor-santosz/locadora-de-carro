using LocadoraCarros.Models;
namespace LocadoraCarros.Dados;

public static class BaseDeCarros
{
    public static List<Carro> ObterCarros()
    {
        return new List<Carro>
        {
            new Carro { Placa = "ABC1D34", Modelo = "Civic", Categoria = "Sedan", Marca = "Honda", Ano = 2020, ValorDiaria = 150.00m, Disponivel = true },
            new Carro { Placa = "XYZ5F78", Modelo = "Corolla", Categoria = "Sedan", Marca = "Toyota", Ano = 2019, ValorDiaria = 140.00m, Disponivel = false },
            new Carro { Placa = "DEF9H12", Modelo = "Fiesta", Categoria = "Hatch", Marca = "Ford", Ano = 2021, ValorDiaria = 130.00m, Disponivel = true },
            new Carro { Placa = "GHI2J56", Modelo = "Onix", Categoria = "Hatch", Marca = "Chevrolet", Ano = 2022, ValorDiaria = 120.00m, Disponivel = true },
            new Carro { Placa = "KLM7N89", Modelo = "Compass", Categoria = "SUV", Marca = "Jeep", Ano = 2021, ValorDiaria = 240.00m, Disponivel = false },
            new Carro { Placa = "OPQ3R45", Modelo = "HB20", Categoria = "Hatch", Marca = "Hyundai", Ano = 2020, ValorDiaria = 120.00m, Disponivel = true },
            new Carro { Placa = "STU8V12", Modelo = "Hilux", Categoria = "Picape", Marca = "Toyota", Ano = 2023, ValorDiaria = 320.00m, Disponivel = true },
            new Carro { Placa = "WXY4Z67", Modelo = "Onix", Categoria = "Hatch", Marca = "Chevrolet", Ano = 2020, ValorDiaria = 130.00m, Disponivel = false },
            new Carro { Placa = "BRA1C23", Modelo = "T-Cross", Categoria = "SUV", Marca = "Volkswagen", Ano = 2022, ValorDiaria = 200.00m, Disponivel = true },
            new Carro { Placa = "BRA4D56", Modelo = "Argo", Categoria = "Hatch", Marca = "Fiat", Ano = 2021, ValorDiaria = 140.00m, Disponivel = true },
            new Carro { Placa = "BRA7E89", Modelo = "Ranger", Categoria = "Picape", Marca = "Ford", Ano = 2020, ValorDiaria = 280.00m, Disponivel = false },
            new Carro { Placa = "BRA2F34", Modelo = "Sentra", Categoria = "Sedan", Marca = "Nissan", Ano = 2022, ValorDiaria = 180.00m, Disponivel = true },
            new Carro { Placa = "BRA5G67", Modelo = "Creta", Categoria = "SUV", Marca = "Hyundai", Ano = 2021, ValorDiaria = 220.00m, Disponivel = true },
            new Carro { Placa = "BRA8H90", Modelo = "Mobi", Categoria = "Hatch", Marca = "Fiat", Ano = 2019, ValorDiaria = 100.00m, Disponivel = false },
            new Carro { Placa = "BRA3J45", Modelo = "S10", Categoria = "Picape", Marca = "Chevrolet", Ano = 2022, ValorDiaria = 300.00m, Disponivel = true },
            new Carro { Placa = "BRA6K78", Modelo = "Kicks", Categoria = "SUV", Marca = "Nissan", Ano = 2020, ValorDiaria = 200.00m, Disponivel = true },
            new Carro { Placa = "BRA9L12", Modelo = "Virtus", Categoria = "Sedan", Marca = "Volkswagen", Ano = 2021, ValorDiaria = 150.00m, Disponivel = true },
            new Carro { Placa = "BRA4M56", Modelo = "Toro", Categoria = "Picape", Marca = "Fiat", Ano = 2021, ValorDiaria = 260.00m, Disponivel = true },
            new Carro { Placa = "BRA7N89", Modelo = "City", Categoria = "Sedan", Marca = "Honda", Ano = 2020, ValorDiaria = 180.00m, Disponivel = true }
        };
    }
}