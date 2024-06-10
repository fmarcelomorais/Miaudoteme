using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Miaudoteme.Domain.ValueObjects
{
    public class Nome
    {
        private string _nome { get; private set; }

        public Nome(string nome)
        {
            _nome = nome;
            ValidaNome();
        }

        private void ValidaNome()
        {
            if(_nome == null) throw new Exception("Nome não pode ser nulo.")
            if(_nome.Length < 3) throw new Exception("Nome deve conter mais de 2 caracteres.")
            VerificaSeTemNumeroNoNome();
            VerificaSeTemNomeESobrenome();
            
        }
        private void VerificaSeTemNumeroNoNome()
        {
            foreach(char c in _nome)
            {
                if(char.IsDigit(c))
                    throw new Exception("Nome deve conter valores numéricos.")
            }
        }
        private void VerificaSeTemNomeESobrenome()
        {
            int quantidadeDeEspacos = 0;
            foreach(char c in _nome)
            {
                if(c == ' ') quantidadeDeEspacos++;
            }
            if(quantidadeDeEspacos < 2) throw new Exception("Nome está faltando Sobrenome");
        }
    }
}