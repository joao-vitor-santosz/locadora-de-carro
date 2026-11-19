namespace LocadoraCarros.Models;

public class Carro
{
    public required string Placa { get; set; }
    public required string Modelo { get; set; }
    public required string Categoria { get; set; }
    public required string Marca { get; set; }
    public required int Ano { get; set; }
    public required decimal ValorDiaria { get; set; }
    public required bool Disponivel { get; set; }

    public override string ToString()
    {
        return $"Placa: {Placa}, Modelo: {Modelo}, Categoria: {Categoria}, Marca: {Marca}, Ano: {Ano}, ValorDiaria: R${ValorDiaria:F2}, Disponivel: {(Disponivel ? "Sim" : "Não")}";
    }
}