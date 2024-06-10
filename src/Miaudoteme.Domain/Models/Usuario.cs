using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miaudoteme.Domain.ValueObjects;

namespace Miaudoteme.Domain.Models;

public class Usuario : Entidade
{
    
    public string Nome { get; private set; }
    public string Email { get; private set; }
    public string Senha { get; private set; }
    public TipoUsuario TipoUsuario { get; private set; }

    public Usuario(Parameters)
    {
        
    }
}
