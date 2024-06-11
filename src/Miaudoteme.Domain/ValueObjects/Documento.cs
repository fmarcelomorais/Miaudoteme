using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miaudoteme.Domain.ValueObjects
{
    public static class Documento
    {
        public static string ValidaDocumento(string documento)
        {
            if(documento.Length <= 11)
            {
                if(!ValidaCPF(documento)) throw new ArgumentException("CPF Invalido.");
                return documento;
            }
            else
            {
                if (!ValidaCNPJ(documento)) throw new ArgumentException("CNPJ Invalido.");
                return documento;
            }
        }

        private static bool ValidaCPF(string cpf)
        {
            
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
                return false;

            bool allDigitsEqual = true;
            for (int i = 1; i < cpf.Length; i++)
            {
                if (cpf[i] != cpf[i - 1])
                {
                    allDigitsEqual = false;
                    break;
                }
            }
            if (allDigitsEqual)
                return false;

            // Calcular o primeiro dígito verificador
            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                sum += int.Parse(cpf[i].ToString()) * (10 - i);
            }
            int firstDigit = sum % 11;
            if (firstDigit < 2)
                firstDigit = 0;
            else
                firstDigit = 11 - firstDigit;

            // Verificar o primeiro dígito verificador
            if (int.Parse(cpf[9].ToString()) != firstDigit)
                return false;

            // Calcular o segundo dígito verificador
            sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += int.Parse(cpf[i].ToString()) * (11 - i);
            }
            int secondDigit = sum % 11;
            if (secondDigit < 2)
                secondDigit = 0;
            else
                secondDigit = 11 - secondDigit;

            // Verificar o segundo dígito verificador
            if (int.Parse(cpf[10].ToString()) != secondDigit)
                return false;

            return true;
        }
    
        private static bool ValidaCNPJ(string cnpj)
        {
            // Eliminar caracteres não numéricos
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

            // Verificar se o CNPJ tem 14 dígitos
            if (cnpj.Length != 14)
                return false;

            // Verificar se todos os dígitos são iguais
            bool allDigitsEqual = true;
            for (int i = 1; i < cnpj.Length; i++)
            {
                if (cnpj[i] != cnpj[i - 1])
                {
                    allDigitsEqual = false;
                    break;
                }
            }
            if (allDigitsEqual)
                return false;

            // Calcular o primeiro dígito verificador
            int sum = 0;
            int[] weights = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            for (int i = 0; i < 12; i++)
            {
                sum += int.Parse(cnpj[i].ToString()) * weights[i];
            }
            int firstDigit = sum % 11;
            firstDigit = firstDigit < 2 ? 0 : 11 - firstDigit;

            // Verificar o primeiro dígito verificador
            if (int.Parse(cnpj[12].ToString()) != firstDigit)
                return false;

            // Calcular o segundo dígito verificador
            sum = 0;
            weights = new int[] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            for (int i = 0; i < 13; i++)
            {
                sum += int.Parse(cnpj[i].ToString()) * weights[i];
            }
            int secondDigit = sum % 11;
            secondDigit = secondDigit < 2 ? 0 : 11 - secondDigit;

            // Verificar o segundo dígito verificador
            if (int.Parse(cnpj[13].ToString()) != secondDigit)
                return false;

            return true;
        }
    }
}
