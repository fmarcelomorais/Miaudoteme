using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miaudoteme.Domain.ValueObjects
{
    public enum FormaDePagamento
    {
        CartaoDeCredito = 1,
        CartaoDeDebito = 2,
        Carnê = 3,
        Pix = 4,
        Dinheiro = 5,
        Outro = 6

    }
}
