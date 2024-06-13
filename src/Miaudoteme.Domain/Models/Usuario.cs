using Miaudoteme.Domain.ValueObjects;

namespace Miaudoteme.Domain.Models;

public class Usuario : Entidade
{
    public string? NomeCompleto { get; private set; }
    public string? Email { get; private set; }
    public string? Senha { get; private set; }
    public TipoUsuario TipoUsuario { get; private set; }    
    
    public Abrigo Abrigo { get; private set; } // prop navegacao
    public Tutor Tutor { get; private set; } // prop navegacao

    public Usuario(string nomeCompleto, string email, string senha, TipoUsuario tipoUsuario)
    {

        NomeCompleto = ValueObjects.Nome.ValidaNome(nomeCompleto);
        Email = ValueObjects.Email.ValidaEmail(email);
        Senha = ValueObjects.Senha.ValidaSenha(senha);
        TipoUsuario = tipoUsuario;
    }

  
}
