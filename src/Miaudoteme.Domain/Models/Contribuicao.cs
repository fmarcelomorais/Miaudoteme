using Miaudoteme.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miaudoteme.Domain.Models
{
    public class Contribuicao : Entidade
    {
        public FormaDePagamento FormaDePagamento { get; private set; }
        public string? NumeroCartao { get; private set; }
        public string? ChavePix { get; private set; }
        public decimal Valor {  get; private set; }
        public int Parcelas { get; private set; }

        public Contribuicao(FormaDePagamento formaDePagamento, string numeroCartao, string? chavePix, decimal valor, int parcelas = 1)
        {
            FormaDePagamento = formaDePagamento;
            NumeroCartao = ValidaCartao(numeroCartao);           
            ChavePix = chavePix;
            Valor = valor;
            Parcelas = parcelas;

        }

        private string ValidaCartao(string creditCardNumber)
        {
            
            string sanitizedNumber = creditCardNumber.Replace(" ", "").Replace("-", "");
            
            if (sanitizedNumber.Length < 13 || !System.Text.RegularExpressions.Regex.IsMatch(sanitizedNumber, @"^\d+$"))
                throw new ArgumentException("Número do cartão invalido");

            int sum = 0;
            bool doubleDigit = false;

          
            for (int i = sanitizedNumber.Length - 1; i >= 0; i--)
            {
                int digit = sanitizedNumber[i] - '0';

                if (doubleDigit)
                {
                    digit *= 2;
                    if (digit > 9)
                        digit -= 9;
                }

                sum += digit;
                doubleDigit = !doubleDigit;
            }
          
            return sum % 10 == 0 ? creditCardNumber : throw new ArgumentException("Número do cartão invalido"); ;
        }
    }
}
