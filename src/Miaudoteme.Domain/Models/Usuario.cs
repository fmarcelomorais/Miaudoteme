using Miaudoteme.Domain.ValueObjects;

namespace Miaudoteme.Domain.Models;

public class Usuario : Entidade
{
<<<<<<< HEAD
    public Nome NomeCompleto { get; private set; }
    public Email Email { get; private set; }
    public Senha Senha { get; private set; }
=======
    public string NomeCompleto { get; private set; }
    public string Email { get; private set; }
    public string Senha { get; private set; }
>>>>>>> 888954cf5b1b2dbebdf770ee080d41c9f2ba29ac
    public TipoUsuario TipoUsuario { get; private set; }
    
    public Usuario(string nome, string email, string senha, TipoUsuario tipoUsuario)
    {
<<<<<<< HEAD
        NomeCompleto = nome;
        Email = email;
        Senha = senha;
=======
        NomeCompleto = Nome.ValidaNome(nome);
        Email = ValueObjects.Email.ValidaEmail(email);
        Senha = ValueObjects.Senha.ValidaSenha(senha);
>>>>>>> 888954cf5b1b2dbebdf770ee080d41c9f2ba29ac
        TipoUsuario = tipoUsuario;
    }

  
}
