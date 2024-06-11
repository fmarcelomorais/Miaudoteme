using Miaudoteme.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miaudoteme.Domain.Models
{
    public class Abrigo : Entidade
    {
        public string? NomeAbrigo { get; private set; }
        public string? CNPJ { get; private set; }
        public string? Contato { get; private set; }
        public string Email {  get; private set; }
        public Endereco? Endereco { get; private set; }
        public Licenca? Licenca { get; private set; }
        public SituacaoAbrigo SituacaoAbrigo { get; private set; }
        public List<Animal>? Animais { get; private set; }
        public Guid UsuarioId { get; private set; }
        public Usuario? Usuario { get; private set; }

        public Abrigo(string nomeAbrigo, string cNPJ, string contato, string email, Endereco endereco, Licenca licenca, Guid usuarioId)
        {
            NomeAbrigo = Nome.ValidaNome(nomeAbrigo);
            CNPJ = Documento.ValidaDocumento(cNPJ);
            Contato = contato;
            Email = ValueObjects.Email.ValidaEmail(email);
            Endereco = endereco;
            Licenca = licenca;
            SituacaoAbrigo = validarSituacaoDoAbrigo(licenca);
            Animais = new List<Animal>();
            UsuarioId = usuarioId;
        }

        private SituacaoAbrigo validarSituacaoDoAbrigo(Licenca licenca)
        {

            // Verifica se o abrigo realmente existe
            // Essa validação evita possiveis cadastro de pessoas má intencionadas.

            return SituacaoAbrigo.Licenciado;
        }
    }
}
