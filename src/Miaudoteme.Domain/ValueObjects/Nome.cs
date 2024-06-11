namespace Miaudoteme.Domain.ValueObjects
{
    public static class Nome
    {
       
        public static string ValidaNome(string nome)
        {
            if (nome == null) throw new Exception("Nome não pode ser nulo.");
            if (nome.Length < 3) throw new Exception("Nome deve conter mais de 2 caracteres.");
            VerificaSeTemNumeroNoNome(nome);
            VerificaSeTemNomeESobrenome(nome);
            return nome;
            
        }
        private static void VerificaSeTemNumeroNoNome(string nome)
        {
            foreach(char c in nome)
            {
                if (char.IsDigit(c))
                    throw new Exception("Nome deve conter valores numéricos.");
            }
        }
        private static void VerificaSeTemNomeESobrenome(string nome)
        {
            int quantidadeDeEspacos = 0;
            foreach(char c in nome)
            {
                if(c == ' ') quantidadeDeEspacos++;
            }
            if(quantidadeDeEspacos < 2) throw new Exception("Nome está faltando Sobrenome");
        }
    }
}