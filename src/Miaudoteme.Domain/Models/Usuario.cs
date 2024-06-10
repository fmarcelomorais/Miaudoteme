using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miaudoteme.Domain.ValueObjects;

namespace Miaudoteme.Domain.Models;

public class Usuario : Entidade
{
    public Nome NomeCompleto { get; private set; }
    public Email Email { get; private set; }
    public Senha Senha { get; private set; }
    public TipoUsuario TipoUsuario { get; private set; }
    
    public Usuario(Nome nome, Email email, Senha senha, TipoUsuario tipoUsuario)
    {
        NomeCompleto = nome;
        Email = email;
        Senha = senha;
        TipoUsuario = tipoUsuario;
    }        
    

}
