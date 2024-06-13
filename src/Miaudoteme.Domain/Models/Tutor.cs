using Miaudoteme.Domain.ValueObjects;

namespace Miaudoteme.Domain.Models
{
    public class Tutor : Entidade
    {
        public string? NomeCompleto { get; private set; }
        public string? CPF { get; private set; }
        public Endereco Endereco { get; private set; } // Agregacao
        public Guid EnderecoId { get; private set; }
        public Guid UsuarioId { get; private set; }
        public Usuario? Usuario { get; private set; } // prop. Navegação

        public Adocao Adocao { get; private set; } // prop Navegacao

        public Tutor()
        {
            
        }

        public Tutor(string nomeCompleto, string cPF, Endereco endereco, Guid usuarioId)
        {
            NomeCompleto = Nome.ValidaNome(nomeCompleto);
            CPF = Documento.ValidaDocumento(cPF);
            Endereco = endereco;
            UsuarioId = usuarioId;
            EnderecoId = endereco.Id;
        }
    }
}
