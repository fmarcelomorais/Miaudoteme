using Miaudoteme.Domain.ValueObjects;

namespace Miaudoteme.Domain.Models;

public class Usuario : Entidade
{
    public string NomeCompleto { get; private set; }
    public string Email { get; private set; }
    public string Senha { get; private set; }
    public TipoUsuario TipoUsuario { get; private set; }
    
    public Usuario(string nome, string email, string senha, TipoUsuario tipoUsuario)
    {
        NomeCompleto = Nome.ValidaNome(nome);
        Email = ValueObjects.Email.ValidaEmail(email);
        Senha = ValueObjects.Senha.ValidaSenha(senha);
        TipoUsuario = tipoUsuario;
    }

  
}
