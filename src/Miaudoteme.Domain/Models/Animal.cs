using Miaudoteme.Domain.ValueObjects;

namespace Miaudoteme.Domain.Models;

public class Animal : Entidade
{
    public string? Nome { get; private set; }
    public string? Raca { get; private set; }
    public Genero Genero { get; private set; }
    public int AnoNascimento { get; private set; }
    public int Idade { get; private set; }
    public string? Sobre { get; private set; }

    public Animal(string nome, string? raca, Genero genero, int anoNascimento, string? sobre)
    {
        Nome = ValueObjects.Nome.ValidaNome(nome);
        Raca = raca;
        Genero = genero;
        AnoNascimento = anoNascimento;
        Idade = Math.Abs(DateTime.Now.Year - anoNascimento);
        Sobre = sobre;
    }
}
