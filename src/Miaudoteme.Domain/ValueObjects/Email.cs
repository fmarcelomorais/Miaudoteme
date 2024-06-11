using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Miaudoteme.Domain.ValueObjects
{
    public static class Email
    {
        public static string ValidaEmail(string email)
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                       + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)+)"
                       + @"(?<!\.)@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z\.]*[a-z]$";

            // Comprobamos si el correo electrónico coincide con el patrón
            Match match = Regex.Match(email, pattern, RegexOptions.IgnoreCase);

            return match.Success ? email : throw new ArgumentNullException("Email inválido.");
        }
    }
}